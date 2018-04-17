using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_ClassChallenge {
    public class Hotel {
        public string RoomNumber { get; set; }
        public int NumBeds { get; set; }
        public bool IsAvailable { get; set; }

        public void printInfo() {

            Console.WriteLine("Room Number: " + this.RoomNumber);
            Console.WriteLine("Beds: " + this.NumBeds);

            if (IsAvailable)
                Console.WriteLine("Looks like {0} is available...welcome to Hell!", RoomNumber); //This is string interpolation
            else
                Console.WriteLine("Well, off to purgatory for you...");
        }
    }
}
