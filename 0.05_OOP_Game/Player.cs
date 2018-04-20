using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOP_Game {

    enum PlayerClasses {
        Fighter,
        Rogue,
        Mage
    }

    class Player : Character {

        //Properties 

        //Constructor
        public Player(string name, string playerClass, int health, int level) {
            this.Name = name;
            this.CharacterClass = playerClass;
            this.Level = level;
            this.Health = health;
        }

        public void Attack(int points, string weaponType) {
            Console.WriteLine("The player attacked with a {1} for {0} hitpoints!", points, weaponType);
        }
    }
}
