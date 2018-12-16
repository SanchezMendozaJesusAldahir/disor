
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GameOfLife
{
    /// <summary>
    /// Strutura de celulas. contiene coordenadas X y Y :(
    /// </summary>
    public struct Cell
    {
        public int X;
        public int Y;

        public override bool Equals(object obj)
        {
            Cell c = (Cell)obj;

            if (X == c.X && Y == c.Y)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return string.Format("{0}_{1}", X, Y).GetHashCode();
        }
    }

    /// <summary>
    /// Tablero
    /// </summary>
    public class Board
    {
        /// <summary>
        /// Estado actual de las celulas en el tablero
        /// </summary>
        protected HashSet<Cell> _currentState = new HashSet<Cell>();

        /// <summary>
        /// HashSet temporal usado para verificar si una nueva célula debe nacer.
        /// </summary>
        private HashSet<Cell> _tmpCheckedCell = new HashSet<Cell>();

        /// <summary>
        /// Cola temporal utilizada para recolectar todas las celulas que nacerán en el siguiente estado.
        /// </summary>
        private Queue<Cell> _nextStateGiveLife = new Queue<Cell>();

        /// <summary>
        /// Cola temporal utilizada para recopilar todas las celdas que se eliminarán en el siguiente estado.
        /// </summary>
        private Queue<Cell> _nextStateKillLife = new Queue<Cell>();

        /// <summary>
        /// Celda temporal utilizada para muchas situaciones.
        /// </summary>
        private Cell tmpCell = new Cell();

        /// <summary>
        /// Contador de método ejecutado en una etapa.
        /// </summary>
        private int _counterMethod_GiveLifeToNeighboursIfPossible = 0;
        public int CounterMethod_GiveLifeToNeighboursIfPossible { 
            get 
            {
                return _counterMethod_GiveLifeToNeighboursIfPossible;
            }
            private set 
            {
                _counterMethod_GiveLifeToNeighboursIfPossible = value;
            } 
        }
        

        /// <summary>
        /// Agregar nueva celula a la tabla si no está allí.
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        public void AddCell(int x, int y)
        {
            tmpCell.X = x;
            tmpCell.Y = y;

            // Un HashSet es una colección que no contiene elementos duplicados
            _currentState.Add(tmpCell);
        }

        /// <summary>
        /// Elimina una celula de la tabla
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        public void RemoveCell(int x, int y)
        {
            tmpCell.X = x;
            tmpCell.Y = y;

            _currentState.Remove(tmpCell);
        }
               
        /// <summary>
        /// checa si la celula existe en la tabla
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        /// <returns>bool</returns>
        public bool IsCellExist(int x, int y)
        {
            return _currentState.Contains(new Cell() { X = x, Y = y });
        }

        /// <summary>
        /// Devuelve la cantidad actual de celulas en la tabla.
        /// </summary>
        /// <returns>int</returns>
        public int CountCells()
        {
            return _currentState.Count;
        }

        /// <summary>
        ///Calcula el siguiente estado del juego y configúralo como estado actual.
        /// </summary>
        public void NextState()
        {
            // se establece en cero cada vez que ejecutamos el método NextState
            CounterMethod_GiveLifeToNeighboursIfPossible = 0;

            int tmpNeighbours = 0;
            foreach (Cell cell in _currentState)
            {
                tmpNeighbours = CountNeighbours(cell.X, cell.Y);
                if (tmpNeighbours < 2 || tmpNeighbours > 3)
                    // agregar celula para matar la cola
                    AddCellToNextStateKillLife(cell);

                // comprobando si los vecinos muertos pueden nacer
                GiveLifeToNeighboursIfPossible(cell.X, cell.Y);

                // Borrar temp HashSet utilizado en el método anterior
                _tmpCheckedCell.Clear();
            }

            // matar celulas
            while (_nextStateKillLife.Count > 0)
            {
                tmpCell = _nextStateKillLife.Dequeue();
                RemoveCell(tmpCell.X, tmpCell.Y);
            }

            // borra celulas         
            while (_nextStateGiveLife.Count > 0)
            {
                tmpCell = _nextStateGiveLife.Dequeue();
                AddCell(tmpCell.X, tmpCell.Y);
            }
        }

        /// <summary>
        /// Compruebe si los vecinos muertos pueden nacer. Sólo las células muertas que tenían 3 vecinos vivos pueden nacer.
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        private void GiveLifeToNeighboursIfPossible(int x, int y)
        {
            CounterMethod_GiveLifeToNeighboursIfPossible++;

            // 1,1      2,1     3,1
            // 1,2      2,2     3,2
            // 1,3      2,3     3,3            
            int tmpX = 0;
            int tmpY = 0;
            
            for (int i = 0; i < 8; i++)
            {                
                switch(i)
                {
                    case 0:
                        tmpX = x - 1;
                        tmpY = y - 1;
                        break;
                    case 1:
                        tmpX = x;
                        tmpY = y - 1;
                        break;
                    case 2:
                        tmpX = x + 1;
                        tmpY = y - 1;
                        break;
                    case 3:
                        tmpX = x - 1;
                        tmpY = y;
                        break;
                    case 4:
                        tmpX = x + 1;
                        tmpY = y;
                        break;
                    case 5:
                        tmpX = x - 1;
                        tmpY = y + 1;
                        break;
                    case 6:
                        tmpX = x;
                        tmpY = y + 1;
                        break;
                    case 7:
                        tmpX = x + 1;
                        tmpY = y + 1;
                        break;
                    default:
                        throw new Exception("Wrong variable i.");                        
                }

                // la verificación es celda ya marcada y negativa de celda porque se comprueba si solo pueden nacer células muertas
                if (!_tmpCheckedCell.Contains(new Cell() { X = tmpX, Y = tmpY }) && !IsCellExist(tmpX, tmpY) && CountNeighbours(tmpX, tmpY) == 3)
                {
                    // célula muerta nacida
                    AddCellToNextStateGiveLife(new Cell() { X = tmpX, Y = tmpY });
                }

                // marca tmpX tmpY como celda que ya verificamos
                _tmpCheckedCell.Add(new Cell() { X = tmpX, Y = tmpY });
            }
        }

        /// <summary>
        /// Cuenta vecinos de celula
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        /// <returns>int</returns>
        public int CountNeighbours(int x, int y)
        {
            // 1,1      2,1     3,1
            // 1,2      2,2     3,2
            // 1,3      2,3     3,3
            int neighbours = 0;

            if (IsCellExist(x - 1, y - 1))
                neighbours++;

            if (IsCellExist(x, y - 1))
                neighbours++;

            if (IsCellExist(x + 1, y - 1))
                neighbours++;

            if (IsCellExist(x - 1, y))
                neighbours++;

            if (IsCellExist(x + 1, y))
                neighbours++;

            if (IsCellExist(x - 1, y + 1))
                neighbours++;

            if (IsCellExist(x, y + 1))
                neighbours++;

            if (IsCellExist(x + 1, y + 1))
                neighbours++;

            return neighbours;
        }
        
        /// <summary>
        /// Agregar celula a la cola de celulas. Estas celulas serán matadas en el próximo estado de juego.
        /// </summary>
        /// <param name="cell">Cell object</param>
        private void AddCellToNextStateKillLife(Cell cell)
        {
            // si no contiene una celula, entonces agrega una celula a la cola
            if (!_nextStateKillLife.Contains(new Cell() { X = cell.X, Y = cell.Y }))
                _nextStateKillLife.Enqueue(cell);
        }

        /// <summary>
        /// Agregar celula a la cola de celulas. Estas células nacerán en próximo estado de juego..
        /// </summary>
        /// <param name="cell">Cell object</param>
        private void AddCellToNextStateGiveLife(Cell cell)
        {
            // si no contiene una celula, entonces agrega una celula a la cola
            if (!_nextStateGiveLife.Contains(new Cell() { X = cell.X, Y = cell.Y }))
                _nextStateGiveLife.Enqueue(cell);
        }
    }
}
