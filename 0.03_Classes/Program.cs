using System;
using System.Speech.Synthesis;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Classes {
    class Program {
        static void Main(string[] args) {

            Donut spencerDonut = new Donut();
            spencerDonut.Type = "Glazed";
            spencerDonut.HasCream = false;
            spencerDonut.Price = 3.99m;
            spencerDonut.Sprinkles = false;

            spencerDonut.printDonut();
            Console.ReadLine();

            SpeechSynthesizer speak = new SpeechSynthesizer();

            speak.Speak(spencerDonut.Type);
        }
    }
}
