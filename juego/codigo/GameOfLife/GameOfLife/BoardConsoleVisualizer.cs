using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GameOfLife
{
    class BoardConsoleVisualizer : Board, IBoardVisualizer
    {
        /// <summary>
        /// Tamaño del tablero en vertical. El tamaño horizontal es 4 veces más grande que AreaSize.
        /// </summary>
        public int AreaSize { get; set; }

        /// <summary>
        ///Milisegundos entre la próxima actualización del estado del juego.
        /// </summary>
        public int TimeSleep;

        /// <summary>
        /// Si es verdadero, escriba la información de la consola sobre las coordenadas de todas las celdas 
        /// después de cada estado de bucle en el método PlayGame
        /// </summary>
        public bool DisplayCurrentCoordinates;


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="areaSize">Tamaño del tablero en vertical. El tamaño horizontal es 4 veces más grande. Si no se configura entonces se utilizará esto.</param>
        /// <param name="timeSleep">Milisegundos entre la próxima actualización del estado del juego.</param>
        /// <param name="displayCurrentCoordinates">Predeterminado como falso</param>
        public BoardConsoleVisualizer(int? areaSize = null, int timeSleep = 250, bool displayCurrentCoordinates = false) 
        {
            if(areaSize == null)
                AreaSize = 5;  
            else
                AreaSize = (int)areaSize;

            if (timeSleep > 0)
                TimeSleep = timeSleep;
            else
                throw new ArgumentException("timeSleep must be bigger then zero.");

            DisplayCurrentCoordinates = displayCurrentCoordinates;
        }

        /// <summary>
        /// Jugar juego en bucle infinito
        /// </summary>       
        public void PlayGame()
        {
            // tablero después de establecer todas las celdas
            DisplayCurrentStateOfBoard();

            if (DisplayCurrentCoordinates)
                PrintCurrentStateCoordinates();

            Thread.Sleep(TimeSleep);
            while (true)
            {
                //Console.Clear();
                Console.SetCursorPosition(1, 0);

                NextState();
                DisplayCurrentStateOfBoard();

                if (DisplayCurrentCoordinates)
                    PrintCurrentStateCoordinates();

                Thread.Sleep(TimeSleep);
            }
        }

        /// <summary>
        ///Escribir en consola todas las celdas de forma visual.
        /// </summary>        
        public void DisplayCurrentStateOfBoard()
        {
            Console.WriteLine();

            for (int i = (int)-AreaSize; i < AreaSize * 2; i++)
            {
                for (int j = (int)-AreaSize * 4; j < AreaSize * 4; j++)
                {
                    if (IsCellExist(j, i))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // Usar PadLeft ayuda cuando reescribimos en la consola buffer.
            // (motivo de los problemas: Console.SetCursorPosition (1, 0) en el método PlayGame)
            // PadLeft nos rescata de un número diferente de señales que aparecen en la pantalla.
            Console.WriteLine("Cells on board: " + Convert.ToString(_currentState.Count).PadLeft(10, '0') + "\n");
        }

        /// <summary>
        /// Escribe en la consola información sobre las coordenadas de todas las celdas.
        /// </summary>
        public void PrintCurrentStateCoordinates()
        {
            Console.WriteLine();

            foreach (Cell cell in _currentState)
            {
                Console.WriteLine("X: " + cell.X + ", Y: " + cell.Y);
            }

            // Por qué usar PadLeft se describió en el método PrintCurrentBoard.
            Console.WriteLine("Cells on board: " + Convert.ToString(_currentState.Count).PadLeft(10, '0') + "\n");
        }
    }
}
