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

            // Premier parcours de cellules :

            for (int x = 0; x < N; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    int nbNeighbor = getNbAliveNeighboor(x, y); // Compte le nbr de voisins

                    Cell cellule = TabCells[x, y];

                    if (cellule.IsAlive == false) // Si pas de cellule
                    {
                        if (nbNeighbor == 3)
                        {
                            cellule.ComeAlive(); // Si il y a trois voisins, elle "nait"
                        }
                        else
                        {
                            cellule.PassAway(); // Sinon elle reste morte
                        }
                    }

                    if (cellule.IsAlive == true) // Si cellule vivante 
                    {
                        if (nbNeighbor == 2 || nbNeighbor == 3)
                        {
                            cellule.ComeAlive(); // Si il y a deudx ou trois voisins elle vit
                        }
                        else
                        {
                            cellule.PassAway(); // Sinon elle disparait
                        }
                    }
                }

            }

            // Deuxième parcours de cellules :

            for (int x = 0; x < N; x++)
            {
                for (int y = 0; y < N; y++)
                {

                    Cell cellule = TabCells[x, y];

                    cellule.Update();

                }

            }

        }


    }
}
