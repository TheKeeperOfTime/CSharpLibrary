using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Enums {
    class Program {
        static void Main(string[] args) {

            PlayerTypes playerType = PlayerTypes.Assassin;

            switch (playerType) {
                case PlayerTypes.Adventurer:
                    break;
                case PlayerTypes.Warrior:
                    break;
                case PlayerTypes.Rogue:
                    break;
                case PlayerTypes.Assassin:
                    break;
                case PlayerTypes.Mage:
                    break;
                case PlayerTypes.Witch:
                    break;
                case PlayerTypes.Monk:
                    break;
                case PlayerTypes.Despised:
                    break;
                case PlayerTypes.Barbara:
                    break;
                case PlayerTypes.Programmer:
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }

    enum PlayerTypes {
        Adventurer,
        Warrior,
        Rogue,
        Assassin,
        Mage,
        Witch,
        Monk,
        Despised,
        Barbara,
        Programmer
    }

}
