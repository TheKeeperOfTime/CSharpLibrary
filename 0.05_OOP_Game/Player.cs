using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOP_Game {
    class Player : Character {

        //Props
        public string PlayerName { get; set; }
        public int PlayerLevel { get; set; }
        public int PlayerCurrentPower { get; set; }
        public int PlayerHealth { get; set; }
        public string PlayerType { get; set; }

        //Constructor
        public Player(string firstName, string playerType, int health, int level, int currentPower) {
            this.PlayerName = firstName;
            this.PlayerType = playerType;
            this.PlayerLevel = level;
            this.PlayerCurrentPower = currentPower;
            this.PlayerHealth = health;
        }

        public void Attack(int points, string weaponType) {
            Console.WriteLine("The player attacked with a {1} for {0} hitpoints!", points, weaponType);
        }
    }
}
