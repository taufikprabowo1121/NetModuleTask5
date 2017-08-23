using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModulTask5
{
    public class Monster
    {
        private int _hp;
        private int _mp;

        public int Hp
        {
            get { return _hp; }
            set { _hp = value; }
        }
        public int Mp
        {
            get { return _mp; }
            set { _mp = value; }
        }
        public Monster()
        {
            Hp = 740;
            Mp = 150;
        }
        
    }
}
