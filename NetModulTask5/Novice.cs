using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModulTask5
{
    public abstract class Novice
    {
        private int _health;
        private int _mana;

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }
        public int Mana
        {
            get { return _mana;  }
            set { _mana = value; }
        }
        public abstract void  Attack(Monster enemy);
    }
}
