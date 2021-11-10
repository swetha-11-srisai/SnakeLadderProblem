using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    class LadderSnake
    {
        public const int NO_PlAY = 0, LADDER = 1, SNAKE = 2, WINNING = 100,START=0;
        int PlayerPosition;
        public int DiceRoll()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
        public void CheckPosition()
        {
            while (PlayerPosition < 100)
            {
                Random random = new Random();
                int result = random.Next(0, 3);
                switch (result)
                {
                    case NO_PlAY:
                        break;
                    case LADDER:
                        PlayerPosition += DiceRoll();
                        if (PlayerPosition > WINNING)
                        {
                            PlayerPosition -= DiceRoll();
                        }
                        break;
                    case SNAKE:
                        PlayerPosition -= DiceRoll();
                        if (PlayerPosition < START)
                        {
                            PlayerPosition = 0;
                        }
                        break;
                }


            }
        }
    }
}
