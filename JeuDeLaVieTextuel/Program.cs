using JeuDeLaVieTextuel;
using System;
namespace JeuDeLaVie
{
    static class Program
    {
        static void Main()
        {
           

            Game game = new Game(11, 10);
            game.RunGameConsole();
        }
    }
}