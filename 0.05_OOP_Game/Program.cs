using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOP_Game {
    class Program {

        static void Main(string[] args) {

            Game _Game = new Game();

            //Start our game loop
            while (_Game.isRunning) {
                _Game.Update();
            }
        }
    }
}
