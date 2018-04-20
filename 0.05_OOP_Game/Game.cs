using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOP_Game {
    class Game {

        public bool isRunning = true;
        private bool gameOver = false;

        private List<Item> inventory;

        public Game() {

            inventory = new List<Item>();

            //Start the game
            Console.WriteLine("Welcome, traveler! What is your name?");
            string playerName = Console.ReadLine();

            Console.WriteLine("Ahh hello there, {0}! You'll need to choose a class to continue...what do you desire to be??", playerName);
            string playerClass = Console.ReadLine();

            Console.WriteLine(playerName);

            Console.ReadLine();

        }

        //Input handling
        public void doAction(string command) {
            
            //Help command
            if (command == "help" || command == "h") {
                Console.WriteLine("Welcome to the text adventure!");
                Console.WriteLine("'l' / 'look':        Shows you the room, its exits, and any items it contains.");
                Console.WriteLine("'Look at X':         Gives you information about a specific item in your \n                     inventory, where X is the items name.");
                Console.WriteLine("'pick up X':         Attempts to pick up an item, where X is the items name.");
                Console.WriteLine("'use X':             Attempts to use an item, where X is the items name.");
                Console.WriteLine("'i' / 'inventory':   Allows you to see the items in your inventory.");
                Console.WriteLine("'q' / 'quit':        Quits the game.");
                Console.WriteLine();
                Console.WriteLine("Directions can be input as either the full word, or the abbriviation, \ne.g. 'North or N'");
                return;
            }

            //If statement to access player inventory
            if (command == "inventory" || command == "i") {
                showInventory();
                Console.WriteLine();
                return;
            }
        }

        //Show inventory method 
        private void showInventory() {

            if (inventory.Count > 0) {
                Console.WriteLine("\nA quick look in your bag reaveals the follwing:\n");

                foreach (Item item in inventory) {
                    Console.WriteLine(item.name);
                }

            } else {
                Console.WriteLine("\nYour bag is empty.\n");
            }
        }

        //Update Method
        public void Update() {
            string currentCommand = Console.ReadLine().ToLower();

            //Instantly check for a quit
            if (currentCommand == "quit" || currentCommand == "q") {
                isRunning = false;
                return;
            }

            //Game Over
            if (!gameOver) {
                doAction(currentCommand);
            }
            else {
                Console.WriteLine("\nNope. Time to quit.\n")
            }
        }
    }
}

