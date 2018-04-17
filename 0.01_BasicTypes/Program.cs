using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._01_BasicTypes {
    class Program {
        static void Main(string[] args) {
            int i = 0;
            short sh = 32767; // Max value for short 
            byte by = 255; // Max value for byte
            string str = "Hello World!";

            char c = 'i'; //It has to be single quotes for this

            // Declared
            bool isTired;
            // Initialized
            isTired = false;

            if(isTired) {
                Console.WriteLine("Get some fucking coffee, man!");
            } else {
                Console.WriteLine("Get some coffee anyway, bitch!");
            }

            // Or

            if(isTired)
                Console.WriteLine("Pour a bucket of cold water on your fucking head!");
            else
                Console.WriteLine("Fuck off, then!");

            double doub = 7.80;
            float flo = 8.75f;
            long log = 7000;

            int? n = null; // Not sure about the question mark 

 
            // Console.WriteLine(); *cw tab tab* will auto complete this
            Console.ReadLine(); // The read loine will make the console stop so you can see your code
        }
    }
}
