using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Constructors {
    public class Character {
        public Character(string userName, int age, int health) {
            this.UserName = userName;
            this.Age = age;
            this.Health = health;
        }

        public Character(string userName, int age) {
            this.UserName = userName;
            this.Age = age;
        }

        public Character(string userName) {
            this.UserName = userName;
        }

        //Properties
        public string UserName { get; set; }
        public int Age { get; set; }
        public int Health { get; set; }
    }
}
