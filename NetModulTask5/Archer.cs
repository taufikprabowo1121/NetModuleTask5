using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModulTask5
{
    public class Archer : Novice
    {
        public Archer()
        {
            Health = 400;
            Mana = 270;
        }
        public override void Attack(Monster enemy)
        {
            Mana = Mana - 10;
            enemy.Hp = enemy.Hp - 20;
            Health = Health - 35;
            enemy.Mp = enemy.Mp - 5;
        }
        public void AttackRange(Monster enemy)
        {
            Mana = Mana - 15;
            enemy.Hp = enemy.Hp - 65;
            Health = Health - 35;
            enemy.Mp = enemy.Mp - 5;
        }
        public void Heal()
        {
            Health = Health + 15;
            Mana = Mana - 10;
        }

       
    }
}
