using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Classes {
    public class Donut {
        //Properties
        public string Type { get; set; } //"prop" *tab tab* will genarate a get and set method
        public bool HasCream { get; set; } //Always capitalize the names too 
        public decimal Price { get; set; }
        public bool Sprinkles { get; set; }

        //Methods
        public void printDonut() {
            Console.WriteLine("Type: " + this.Type);
            Console.WriteLine("Cream: " + this.HasCream);
            Console.WriteLine("Sprinkles: " + this.Sprinkles);
            Console.WriteLine("Price: $" + this.Price);
        }
    }
}
