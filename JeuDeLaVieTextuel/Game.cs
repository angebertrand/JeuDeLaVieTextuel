using JeuDeLaVieTextuel;
using System;
using System.Collections.Generic; // Pour List<T>
using System.Threading; // Pour Thread.Sleep
public class Game
{
    // Taille de la grille
    private int n;
    // Nombre d'itérations de la simulation
    private int iter;
    // Grille contenant toutes les cellules
    public Grid grid;
    // Liste des coordonnées des cellules vivantes au départ
    public List<Coords> AliveCellsCoords;


    
    public Game(int nbCells, int nbIterations)
    {
        n = nbCells;
        iter = nbIterations;

        /*
        // Emergence d'un cercle sur une grille 5,5
        AliveCellsCoords = new List<Coords> {
         new Coords(n/2, n/2),
         new Coords(n/2+1, n/2),
         new Coords(n/2, n/2+1),
         new Coords(1,1)
        };
        */

        // Evolution d'une croix sur une grille 11,11
        AliveCellsCoords = new List<Coords> {
         new Coords(5, 5),
         new Coords(5, 4),
         new Coords(5, 6),
         new Coords(4, 5),
         new Coords(6, 5),
        };


        grid = new Grid(n, AliveCellsCoords);
        
       
    }
    
    public void RunGameConsole()
    {
        grid.DisplayGrid();

        
        // Boucle sur le nombre d'itérations
        for (int i = 0; i < iter; i++)
        {
            grid.UpdateGrid();
            grid.DisplayGrid();
            Thread.Sleep(1000);
            
        }
    }
}