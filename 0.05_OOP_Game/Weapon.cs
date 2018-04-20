using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOP_Game {
    class Weapon {

        //Top weapon class for others to inherit from

        //Properties
        public string WeaponName { get; set; }
        public int Damage { get; set; }
        public decimal Weight { get; set; }
        public int CoinValue { get; set; }

    }
}
