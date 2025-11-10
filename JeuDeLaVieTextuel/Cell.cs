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


    }
}
