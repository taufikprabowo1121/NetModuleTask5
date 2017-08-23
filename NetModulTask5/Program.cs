using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModulTask5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Monster musuh = new Monster();
            Swordman swordman = new Swordman();
            Archer archer = new Archer();
            int choose;
            int fungsi;

            Console.WriteLine("Pilih Pilihan Anda");
            Console.WriteLine("1.Archer");
            Console.WriteLine("2.Swordman");
            Console.Write("Pilih Pilihan Anda : ");
            choose = int.Parse(Console.ReadLine());
            if(choose == 1)
            {
              
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Your Choose Archer");
                    Console.WriteLine("1.Attack");
                    Console.WriteLine("2.AttackRange");
                    Console.WriteLine("3.Heal");
                    
                
                while ((archer.Health > 0))
                {
                  
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine(" Your Static Player ");
                    Console.WriteLine("HP : " + archer.Health);
                    Console.WriteLine("Mana : " + archer.Mana);
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Your Enemy Health :" + musuh.Hp);
                    Console.WriteLine("Your Enemy Mana :" + musuh.Mp);
                    Console.WriteLine("Choose Your function : ");
                    fungsi = int.Parse(Console.ReadLine());
                    
                    if(fungsi == 1)
                    {
                        archer.Attack(musuh);
                        
                    }
                    else if( fungsi == 2)
                    {
                        archer.AttackRange(musuh);
                    }
                    else
                    {
                        archer.Heal();

                    } 
                 

                }
                if (archer.Health > musuh.Hp)
                {
                    Console.WriteLine("You Win");
                }
                else
                {
                    Console.WriteLine("You Lose");
                }   
            }
            else
            {
                while ((swordman.Health > 0))
                {

                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine(" Your Static Player ");
                    Console.WriteLine("HP : " + swordman.Health);
                    Console.WriteLine("Mana : " + swordman.Mana);
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Your Enemy Health :" + musuh.Hp);
                    Console.WriteLine("Your Enemy Mana :" + musuh.Mp);
                    Console.WriteLine("Choose Your function : ");
                    fungsi = int.Parse(Console.ReadLine());

                    if (fungsi == 1)
                    {
                        swordman.Attack(musuh);

                    }
                    else if (fungsi == 2)
                    {
                        swordman.AttackRange(musuh);
                    }
                    else
                    {
                        swordman.Heal();

                    }


                }
                if (swordman.Health > musuh.Hp)
                {
                    Console.WriteLine("You Win");
                }
                else
                {
                    Console.WriteLine("You Lose");
                }
            }
            Console.ReadKey();
        }
    }
}
