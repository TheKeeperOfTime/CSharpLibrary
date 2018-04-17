using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Collections_Lists {
    class Program {
        static void Main(string[] args) {
            var namesList = new List<string>();
            namesList.Add("Spencer");
            namesList.Add("Quincy");
            namesList.Add("Aaron M");
            namesList.Add("Paul");
            namesList.Add("Bob");

            foreach(var name in namesList) {
                Console.WriteLine(name);
            }

            List<String> fruits = new List<string>() {
                "Banana", "Jackfruit", "Durian", "Tomato", "Mango"
            };

            Console.WriteLine(namesList.Capacity);
            Console.ReadLine();
        }
    }
}
