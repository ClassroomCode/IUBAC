using AutomobileLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.SwitchOn();
            IVoiceCommand volumeUpCommand = new VolumeUpCommand(radio);
            IVoiceCommand volumeDownCommand = new VolumeDownCommand(radio);

            ElectricWindow window = new ElectricWindow();
            IVoiceCommand windowUpCommand = new WindowUpCommand(window);
            IVoiceCommand windowDownCommand = new WindowDownCommand(window);

            SpeechRecognizer speechRecognizer = new SpeechRecognizer();
            speechRecognizer.SetCommands(volumeUpCommand, volumeDownCommand);
            Console.WriteLine("Speech recognition controlling the radio");
            speechRecognizer.HearUpSpoken();
            speechRecognizer.HearUpSpoken();
            speechRecognizer.HearUpSpoken();
            speechRecognizer.HearDownSpoken();

            speechRecognizer.SetCommands(windowUpCommand, windowDownCommand);
            Console.WriteLine("Speech recognition controlling the window");
            speechRecognizer.HearDownSpoken();
            speechRecognizer.HearUpSpoken();

            Console.ReadKey();
        }
    }
}
