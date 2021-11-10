using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    class LadderSnake
    {
        public const int PLAYER_POSITION = 0;
        public void Position()
        {
            Random random = new Random();
            if (random.Next(0, 1) == PLAYER_POSITION)
            {
                Console.WriteLine("the player is at starting Position");
            }
        }
    }
}
