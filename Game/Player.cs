using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Interfaces;

namespace TicTacToe.Game
{
    public class Player : ICheckActivePlayer
    {
        // TODO - manage future int parzialPoint;
        const int MAX_PLAYER = 2;
        int totalPoint = 0;
        string playerName = "";
        string playerCharacter = "";
        bool activePlayer = false;
        /// <summary>
        /// Player constructor
        /// </summary>
        /// <param name="totalPoint"></param>
        /// <param name="playerName"></param>
        /// <param name="activePlayer"></param>
        public Player(int totalPoint, string playerName, bool activePlayer) 
        {
            this.totalPoint = totalPoint;
            this.playerName = playerName;
            this.activePlayer = activePlayer;
        }

        public string toString()
        {
            return $"{this.playerName} has {this.totalPoint} points";
        }

        public int getPoint() 
        {
            return this.totalPoint;
        }

        public string setCharacter(string playerCharacter)
        {
            this.playerCharacter = playerCharacter;
            return this.playerCharacter;
        }

        public bool setActive()
        {
            activePlayer = true;
            return activePlayer;
        }

        public bool setNotActive()
        {
            activePlayer = false;
            return activePlayer;
        }

        public bool isActivePlayer()
        {
            return activePlayer;
        }
    }
}
