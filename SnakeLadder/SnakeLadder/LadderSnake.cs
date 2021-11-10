using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    class LadderSnake
    {
       public const int PLAYER_POSITION = 0;
        public void DiceRoll()
        {
            Random random = new Random();
            int result = random.Next(1, 7);
            Console.WriteLine("player is in the position:"+result);


        }
    }
}
