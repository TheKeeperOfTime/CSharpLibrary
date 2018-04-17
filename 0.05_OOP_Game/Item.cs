using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOP_Game {
    class Item {
        public Item(string itemName, decimal weight, string description) {
            this.ItemName = itemName;
            this.Weight = weight;
            this.Description = description;
        }

        public string ItemName { get; set; }
        public decimal Weight { get; set; }
        public string Description { get; set; }

    }
}
