using System;
using System.Collections.Generic;
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

        public Cell[,] TabCells;

        
        public Grid(int nbCells, List<Coords> AliveCellsCoords)
        {
            // TODO : initialiser n et TabCells
            // TODO : remplissage du tableau avec à chaque emplacement une instance
            //d’une cellule Cell créée vivante(true) si les coordonnées sont dans la liste
            //AliveCellsCoords ou absente(false) sinon.
        }
        // ★★☆ Méthode : retourne le nombre de cellules vivantes autour d'une
        //cellule
        public int getNbAliveNeighboor(int i, int j)
        {
            return 0;
        }
        
        public List<Coords> getCoordsCellsAlive()
        {
            return new List<Coords>();
        }
        
        public void DisplayGrid()
        {
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
