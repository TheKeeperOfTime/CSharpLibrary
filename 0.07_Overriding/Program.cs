using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Overriding {
    class Program {
        static void Main(string[] args) {

            Character spencer = new Character();
            spencer.HealAlly();

            Player paul = new Player();
            paul.HealAlly();

            Enemy zombie = new Enemy();
            zombie.HealAlly();

            Console.ReadLine();

        }
    }
}
