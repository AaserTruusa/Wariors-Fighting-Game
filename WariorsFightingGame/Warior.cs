using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WariorsFightingGame
{
    class Warior
    {
        // Assigns properties for characters
        public string name { get; set; }
        public int health { get; set; }
        public int minDamage { get; set; }
        public int maxDamage { get; set; }

        // Sets input values
        public Warior(string name, int health, int minDamage, int maxDamage)
        {
            this.name = name;
            this.health = health;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
        }


    }
}
