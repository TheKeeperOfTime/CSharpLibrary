using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Dictionaries {
    class Program { 

        static void Main(string[] args) {
            Dictionary<string, string> winners = new Dictionary<string, string>();
            winners.Add("2000", "American Beauty");
            winners.Add("2001", "Gladiator");
            winners.Add("2002", "A Beautiful Mind");
            winners.Add("2003", "Chicago");
            winners.Add("2004", "Lord of the Rings");
            winners.Add("2005", "Million Dollar Baby");

            foreach (KeyValuePair<string, string> w in winners) {
                Console.WriteLine(w.Key + ": " + w.Value);
            }

            string userInput = Console.ReadLine();

            Console.ReadLine();
        }
    }
}
