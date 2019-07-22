using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WariorsFightingGame
{
    class Battle
    {
        public static void StartFight(Warior w1, Warior w2)
        {
            bool end = false;
            string turn = "w1";
            Random rn = new Random();
            int damage;

            bool fast = false; //If Game is Fast or Slow
            int speed = 250; //Game Speed

            // Attacking untill death
            while (end != true)
            {
                if (turn == "w1" && end != true)
                {
                    // Damage 
                    damage = rn.Next(w1.minDamage, w1.maxDamage);
                    w2.health -= damage;

                    // Damage Report
                    if (fast != true) Thread.Sleep(speed); // Pause Between Attacks
                    Console.WriteLine("{0} Attacks {1} and Deals {2} Damage", w1.name, w2.name, damage);
                    Console.WriteLine("{0} Has {1} Health \n", w2.name, w2.health);

                    // Is opponent alive?
                    if (w2.health > 0)
                    {
                        // Yes. Oponent's Turn
                        turn = "w2";
                        continue;
                    }
                    else
                    {
                        // No. You Won!!!
                        if (fast != true) Thread.Sleep(speed); // Pause Between Attacks
                        Console.WriteLine("{0} has Died and {1} is Victorious", w2.name, w1.name);
                        break;
                    }

                }
                if (turn == "w2" && end != true)
                {
                    // Damage 
                    damage = rn.Next(w2.minDamage, w2.maxDamage);
                    w1.health -= damage;

                    // Damage Report
                    if (fast != true) Thread.Sleep(speed); // Pause Between Attacks
                    Console.WriteLine("{0} Attacks {1} and Deals {2} Damage", w2.name, w1.name, damage);
                    Console.WriteLine("{0} Has {1} Health \n", w1.name, w1.health);

                    // Is opponent alive?
                    if (w1.health > 0)
                    {
                        // Yes. Oponent's Turn
                        turn = "w1";
                        continue;
                    }
                    else
                    {
                        // No. You Won!!!
                        if (fast != true) Thread.Sleep(speed); // Pause Between Attacks
                        Console.WriteLine("{0} has Died and {1} is Victorious", w1.name, w2.name);
                        break;
                    }
                }
                else { break; }
            }
            if (fast != true) Thread.Sleep(speed); // Pause Between Attacks
            Console.WriteLine("\nThe End!");

        }
    }
}
