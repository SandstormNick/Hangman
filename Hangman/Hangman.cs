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
        private string HangmanFigure { get; set; }

        private const string FullHangman = "           _______\n          |       |\n          |       |\n          |       O\n          |      /|\\\n          |       |\n          |      / \\\n          |\n__________|__________\n";
        private const string HangmanNoLegs = "           _______\n          |       |\n          |       |\n          |       O\n          |      /|\\\n          |       |\n          |\n          |\n__________|__________\n";
        private const string HangmanNoArms = "           _______\n          |       |\n          |       |\n          |       O\n          |       |\n          |       |\n          |\n          |\n__________|__________\n";
        private const string HangmanOnlyHead = "           _______\n          |       |\n          |       |\n          |       O\n          |\n          |\n          |\n          |\n__________|__________\n";
        private const string HangmanRope = "           _______\n          |       |\n          |       |\n          |\n          |\n          |\n          |\n          |\n__________|__________\n";
        private const string HangmanBeam = "           _______\n          |\n          |\n          |\n          |\n          |\n          |\n          |\n__________|__________\n";
        private const string HangmanPost = "          |\n          |\n          |\n          |\n          |\n          |\n          |\n__________|__________\n";
        private const string HangmanBase = "____________________\n";

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
            return HangmanFigure;
        }

        public void SetHangman(int wrongAnswer, char difficulty)
        {
            if (difficulty == 'E')
            {
                switch (wrongAnswer)
                {
                    case 1:
                        HangmanFigure = HangmanBase;
                        break;
                    case 2:
                        HangmanFigure = HangmanPost;
                        break;
                    case 3:
                        HangmanFigure = HangmanBeam;
                        break;
                    case 4:
                        HangmanFigure = HangmanRope;
                        break;
                    case 5:
                        HangmanFigure = HangmanOnlyHead;
                        break;
                    case 6:
                        HangmanFigure = HangmanNoArms;
                        break;
                    case 7:
                        HangmanFigure = HangmanNoLegs;
                        break;
                    case 8:
                        HangmanFigure = FullHangman;
                        break;
                }
            }
            else if (difficulty == 'M')
            {
                
            }
            else
            {

            }
        }

        #endregion
    }
}
