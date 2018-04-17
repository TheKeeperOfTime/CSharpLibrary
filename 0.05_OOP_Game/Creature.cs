using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOP_Game {
    public class Creature : Character {

        public Creature(string creatureName, string type, int health, int level, int currentPower) {
            this.CreatureName = creatureName;
            this.CreatureHealth = health;
            this.CreatureLevel = level;
            this.CreatureCurrentPower = currentPower;
            this.CreatureType = type;
        }

        public string CreatureName { get; set; }
        public int CreatureHealth { get; set; }
        public int CreatureCurrentPower { get; set; }
        public int CreatureLevel { get; set; }
        public string CreatureType { get; set; }
    }
}
