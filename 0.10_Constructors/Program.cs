using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Constructors {
    class Program {
        static void Main(string[] args) {

            Character paul = new Character("Paul", 40, 100);

            Character ken = new Character("Ken", 30);

            Character spencer = new Character("Spencer");

            GreetUserByUsername(paul.UserName);

            Console.ReadLine();

        }
        public static void GreetUserByUsername(string name) {
            Console.WriteLine("Hello, {0}", name);
        }
    }
}
