using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModulTask5
{
    public class Swordman : Novice
    {
        public Swordman()
        {
            Health = 660;
            Mana = 140;
        }
        public override void Attack(Monster enemy)
        {
            Mana = Mana - 10;
            enemy.Hp = enemy.Hp - 45;
            Health = Health - 35;
            enemy.Mp = enemy.Mp - 5;
        }
        public void AttackRange(Monster enemy)
        {
            Mana = Mana - 15;
            enemy.Hp = enemy.Hp - 75;
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
