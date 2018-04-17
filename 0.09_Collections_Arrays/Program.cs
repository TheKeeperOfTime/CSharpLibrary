using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Collections_Arrays {
    class Program {
        static void Main(string[] args) {

            //Arrays are strongly typed. You can't add a string to an int array and vice versa
            //Arrays are immutable in C#
            //You never really use arrays in C#
            int[] scores = new int[] { 48, 92, 81, 50 };

            foreach (int i in scores) {
                System.Console.Write("{0} ", i);
            }

            Console.ReadLine();

        }
    }
}
