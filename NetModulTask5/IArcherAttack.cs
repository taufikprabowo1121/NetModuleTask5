using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModulTask5
{
   public interface IArcherAttack
    {
        void AttackRange(Monster enemy);
        void Heal();
    }
}
