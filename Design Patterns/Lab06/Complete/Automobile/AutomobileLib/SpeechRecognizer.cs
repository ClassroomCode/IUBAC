using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileLib
{
    public class SpeechRecognizer
    {
        private IVoiceCommand upCommand, downCommand;

        public void SetCommands(IVoiceCommand upCommand, IVoiceCommand downCommand)
        {
            this.upCommand = upCommand;
            this.downCommand = downCommand;
        }

        public void HearUpSpoken()
        {
            upCommand.Execute();
        }

        public void HearDownSpoken()
        {
            downCommand.Execute();
        }
    }
}
