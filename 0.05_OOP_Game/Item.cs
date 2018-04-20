using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOP_Game {
    class Item {

        //Properties
        public string name;
        private bool useable;
        private bool needsItem;
        private string description;

        //Item constructor
        public Item(string _name, bool canUse, string _description) {
            name = _name;
            useable = canUse;
            description = _description;
        }

        //Getters and setters
        public string Name {
            get { return name; }
        }

        public bool Useable {
            get { return useable; }
        }

        public string Description {
            get { return description; }
        }
    }
}
