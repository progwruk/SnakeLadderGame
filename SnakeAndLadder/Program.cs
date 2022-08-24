using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.DieRoll();
            Console.WriteLine(game.DieRoll());
        }
    }
}

