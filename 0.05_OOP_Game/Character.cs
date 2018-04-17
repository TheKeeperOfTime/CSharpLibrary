using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOP_Game {
    public class Character {

        //Properties
        public String Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public string Type { get; set; }
        public bool IsLowOnPower { get; set; }
        public int CurrentPower { get; set; }
    }
}
