using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_Conditionals {
    class Program {
        static void Main(string[] args) {

            string student = "Isaac";

            switch (student) {
                case "Isaac":
                    Console.WriteLine("Sup");
                    break;
                case "Fred":
                    Console.WriteLine("What's up?");
                    break;
                case "Spencer":
                    Console.WriteLine("Hey Bro, that's me!");
                    break;
                default:
                    Console.WriteLine("Alrighty then!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
