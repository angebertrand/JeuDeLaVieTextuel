using JeuDeLaVieTextuel;
using System;
namespace JeuDeLaVie
{
    static class Program
    {
        static void Main()
        {
            Grid grid = new Grid(2, new List<Coords>());
            grid.DisplayGrid();

            //Game game = new Game(4, 10);
            //game.RunGameConsole();
        }
    }
}