using _0._05_OOP_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Encapsulation {
    class Program {
        static void Main(string[] args) {
            BankPublic bankPublic = new BankPublic();
            decimal amount = bankPublic.GetAmount();
            Console.WriteLine("Your balence is: ${0}", amount);

            BankProtected bankProtected = new BankProtected();
            bankProtected.CloseAccount();

            //This is showing how you can reference things from different projects all together
            Creature steve = new Creature("The Thing", "Huge Fucking Monster", 10000, 100, 500);

            //Public is open to the namespace
            //Protected is open to the class and all derived classes
            //Private is open only to the class itself

            Console.ReadLine();
        }
    }
}
