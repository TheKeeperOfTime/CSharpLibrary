using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOP_Game {
    class Program {

        static void Main(string[] args) {

            //Start the game
            Console.WriteLine("Welcome, traveler! What is your name?");
            string playerName = Console.ReadLine();

            Console.WriteLine("What would you like your gamername to be?");
            string gamerName = Console.ReadLine();

            Console.WriteLine("What would you like to be?\n" +
                "1: Warrior\n" +
                "2: Assassin\n" +
                "3: Wizard");

            //int parseType = int.Parse(Console.ReadLine());

            Console.WriteLine(gamerName);

            //Player choices

            //Fight

            //Deal with points 

            //Death

            Player spencer = new Player("Spencer", "Assassin", 100, 1, 10);
            
            Creature zed = new Creature("Zed", "Zombie", 200, 10, 20);
        }
    }
}
