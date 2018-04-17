using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Overloading {
    class Player {
        //There is always a constructor in a class

        public void Attack() {
            Console.WriteLine("The player attacked!");
        }

        public void Attack(int points) {
            Console.WriteLine("The player attacked for {0} points!", points);
        }

        public void Attack(int points, string weaponType) {
            Console.WriteLine("The player attacked with a {1} for {0} points!", points, weaponType);
        }

        public void Defend() {
            Console.WriteLine("The player defended!");
        }
        
    }
}
