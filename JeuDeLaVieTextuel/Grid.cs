using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JeuDeLaVieTextuel
{
    public class Grid
    {
        private int _n;
        public int N
        {
            get { return _n; }
            set { _n = value; }
        }

        public Cell[,] TabCells; // [,] veut dire tableau à 2 dimensions

        
        public Grid(int nbCells, List<Coords> AliveCellsCoords)
        {
            N = nbCells;
            TabCells = new Cell[N, N];

            for (int x = 0; x < N; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    if (AliveCellsCoords.Contains(new Coords(x, y)))
                    {
                        TabCells[x, y] = new Cell(true); // Si les coordnées sont dans la liste, on crée une nouvelle cellule vivante
                        
                    }
                    else
                    {
                        TabCells[x, y] = new Cell(false); // Sinon on crée une cellule morte
                    }
                }

            }

                }

        
       
        public int getNbAliveNeighboor(int i, int j) //retourne le nombre de cellules vivantes autour d'une cellule
        {
            int nbAlive = 0;

            foreach (int dx in new int[] { -1, 0, 1 })
            {
                foreach (int dy in new int[] { -1, 0, 1 })
                {
                    if (dx == 0 && dy == 0)
                    {
                        continue; // Pour ne pas que ça compte la case de la cellule
                    }

                    int nx = i + dx;
                    int ny = j + dy;


                    if (nx >= 0 && nx < N && ny >= 0 && ny < N) // Eviter de sortir de la grille
                    {
                        if (TabCells[nx, ny].IsAlive == true)
                        {
                            nbAlive++;
                        }
                    }
                }
            }

            return nbAlive;
        }
        
        public List<Coords> getCoordsCellsAlive()
        {
            List<Coords> coordCells = new List<Coords>();

            for (int x = 0; x < N; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    if (TabCells[x, y].IsAlive == true)
                    {
                        coordCells.Add(new Coords(x, y));
                    }


                }
            }


            return coordCells;
        }
        
        public void DisplayGrid()
        {

            for (int x = 0; x < N; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    Console.Write("+---");


                }
                Console.WriteLine("+");
                for (int y = 0; y < N; y++)
                {
                    Console.Write("| ");

                    // Cellule ou Vide :

                    if (TabCells[x, y].IsAlive == true)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write("  "); // deux espaces pour indenter
                    }
                }
                Console.WriteLine("|");
            }

            for (int y = 0; y < N; y++) // dernière ligne
            {
                Console.Write("+---");


            }
            Console.WriteLine("+");
        }
       
        public void UpdateGrid()
        {
            // Méthode qui parcourt chaque cellule et qui met à jour leur attribut
            //_nextStep, via son accesseur en écriture, en fonction des règles de la simulation.
            //L’attribut est mis à true si la cellule reste en vie ou apparaît et à false si la
       //cellule à cet emplacement disparaît ou reste absente. Une fois toute la grille
       //parcourue, une deuxième passe est effectué pour associer la valeur de nexStep à
       //l’attribut isAlive de chaque cellule.
        // TODO : première passe : calculer nextState pour chaque cellule
        // TODO : deuxième passe : appliquer nextState à _isAlive
 }


    }
}
