using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeLaVieTextuel
{
    public class Cell
    {
        private bool _isAlive;
        public bool IsAlive
        {
            get { return _isAlive; }
            set { _isAlive = value; }
        }

        private bool _nextState;
        public bool NextSate
        {
            get { return _nextState; }
            set { _nextState = value; }
        }


        
        public Cell(bool state)
        {
            IsAlive = state;
        }
        
        public void ComeAlive()
        {
            NextSate = true;
        }
        
        public void PassAway()
        {
            NextSate = false;
        }
        
        public void Update()
        {
            IsAlive = NextSate;
        }


    }
}
