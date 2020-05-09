using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Hangman
    {
        private int Attempts { get; set; }
        private bool Alive = true;

        private string FullHangman = "           _______\n          |       |\n          |       |\n          |       O\n          |      /|\\\n          |       |\n          |      / \\\n          |\n__________|__________\n";
        private string HangmanNoLegs = "           _______\n          |       |\n          |       |\n          |       O\n          |      /|\\\n          |       |\n          |\n          |\n__________|__________\n";
        private string HangmanNoArms = "           _______\n          |       |\n          |       |\n          |       O\n          |       |\n          |       |\n          |\n          |\n__________|__________\n";
        private string HangmanOnlyHead = "           _______\n          |       |\n          |       |\n          |       O\n          |\n          |\n          |\n          |\n__________|__________\n";
        private string HangmanRope = "           _______\n          |       |\n          |       |\n          |\n          |\n          |\n          |\n          |\n__________|__________\n";
        private string HangmanBeam = "           _______\n          |\n          |\n          |\n          |\n          |\n          |\n          |\n__________|__________\n";
        private string HangmanPost = "          |\n          |\n          |\n          |\n          |\n          |\n          |\n__________|__________\n";
        private string HangmanBase = "____________________\n";

        #region Methods
        public void SetAttempts(string difficulty)
        {
            switch (difficulty)
            {
                case "H":
                    Attempts = 5;
                    break;
                case "M":
                    Attempts = 6;
                    break;
                default:
                    Attempts = 8;
                    break;
            }
        }

        public void UpdateAttempts()
        {
            Attempts--;
        }

        public bool CheckManStatus()
        {
            return Alive;
        }

        public string GetHangman()
        {
            return HangmanBase;
        }

        #endregion
    }
}
