using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            LadderSnake ladder = new LadderSnake();
            ladder.DiceRoll();
            Console.ReadLine();
        }
    }
}
