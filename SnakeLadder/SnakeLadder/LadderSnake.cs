using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    class LadderSnake
    {
        public const int NO_PlAY = 0, LADDER = 1, SNAKE = 2;
        int PlayerPosition;
        public int DiceRoll()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
        public void PlayerCheck()
        {
            Random random = new Random();
            int result = random.Next(0, 3);
            switch (result)
            {
                case NO_PlAY:
                    break;
                case LADDER:
                    PlayerPosition += DiceRoll();
                    break;
                case SNAKE:
                    PlayerPosition -= DiceRoll();
                    break;
            }


        }
    }
}
