using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_ClassChallenge {
    class Program {
        static void Main(string[] args) {
            Hotel hell = new Hotel();
            hell.RoomNumber = "666";
            hell.NumBeds = 0;
            hell.IsAvailable = true;

            hell.printInfo();

            Console.ReadLine();
        }
    }
}
