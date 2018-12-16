using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
    /// <summary>
    /// Interfaz para visualizar la clase de tablero.
    /// </summary>
    public interface IBoardVisualizer
    {
        /// <summary>
        /// Mostrar el estado actual del tablero en la pantalla.
        /// </summary>
        void DisplayCurrentStateOfBoard();

        /// <summary>
        /// Jugar juego en bucle infinito
        /// </summary>
        void PlayGame();
    }
}
