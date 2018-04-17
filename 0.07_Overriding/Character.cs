using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Overriding {
    class Character {
        public virtual void HealAlly() {
            Console.WriteLine("The character healed the ally!");
        }
    }
}
