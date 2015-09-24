using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            //synth.Speak("Hello");
            Console.WriteLine("Please Enter Your Name: ");
            string name = Console.ReadLine();
            synth.Speak("Hello " + name + " Welcome to our calculator");
            UserInterface test = new UserInterface();
            while (true)
            {
                test.Display();
            }
        }
    }
}
