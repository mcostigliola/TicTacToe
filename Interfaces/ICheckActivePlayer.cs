using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Interfaces
{
    public interface ICheckActivePlayer
    {
        /// <summary>
        /// Check if the current player is active or none.
        /// </summary>
        /// <returns></returns>
        bool isActivePlayer();
    }
}
