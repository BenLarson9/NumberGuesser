using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuesser
{
    class Player
    {
        Game game = new Game();
        private int playerNum;
        public void SetPlayer(int i)
        {
            playerNum = i;
            
        }
        public void UseGuess(int i)
        {
            game.CheckNumber(i);
        }
        public int getPlayerNum()
        {
            return playerNum;
        }
    }
}
