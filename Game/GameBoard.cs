using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Interfaces;

namespace TicTacToe.Game
{
    public class GameBoard : gameForm
    {
        /// <summary>
        /// Winner = 0
        /// Loser = 1
        /// Draw = 2
        /// Playing = 3
        /// </summary>
        public enum Results
        {
            winner,
            loser,
            draw,
            playing
        }

        public List<bool> checkedCells = new List<bool>();
        public GameBoard() { }

        

        public bool CheckWinner()
        {
            return true;
        }
    }
}
