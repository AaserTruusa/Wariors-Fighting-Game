using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace WariorsFightingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates Characters
            Warior bob = new Warior(name: "Bob", health: 100, minDamage: 5, maxDamage: 15);
            Warior maximus = new Warior(name: "Maximus", health: 100, minDamage: 5, maxDamage: 15);

            Console.WriteLine("Press <Enter> to start the fight...");
            Console.ReadLine();
            Battle.StartFight(bob, maximus);

            Console.WriteLine("\nPress <Enter> to close the game...");
            Console.ReadLine();
        }
    }
}
