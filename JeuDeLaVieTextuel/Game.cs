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


    // ★★★ Constructeur : initialise la simulation
    public Game(int nbCells, int nbIterations)
    {
        // TODO : initialiser n et iter
        // TODO : initialiser AliveCellsCoords avec une configuration initiale
        // TODO : créer une nouvelle grille Grid(n, AliveCellsCoords)
        // (quelques exemples de configuration de départ sont fournis en fin de
        //sujet)
 }
    // ★★★ Méthode : exécute la simulation dans la console
    public void RunGameConsole()
    {
        // TODO : afficher la grille initiale avec grid.DisplayGrid()
        // Boucle sur le nombre d'itérations
        for (int i = 0; i < iter; i++)
        {
            // TODO : mettre à jour la grille avec grid.UpdateGrid()
            // TODO : afficher la grille après mise à jour avec grid.DisplayGrid()
            // TODO : mettre en pause 1 seconde avec Thread.Sleep(1000)
        }
    }
}