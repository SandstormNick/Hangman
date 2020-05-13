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
        private bool Alive { get; set; }
        private string HangmanFigure { get; set; }
        private string HangmanArea { get; set; }

        private const string FullHangman = "           _______\n          |       |\n          |       |\n          |       O\n          |      /|\\\n          |       |\n          |      / \\\n          |\n__________|__________\n";
        private const string HangmanNoLegs = "           _______\n          |       |\n          |       |\n          |       O\n          |      /|\\\n          |       |\n          |\n          |\n__________|__________\n";
        private const string HangmanNoArms = "           _______\n          |       |\n          |       |\n          |       O\n          |       |\n          |       |\n          |\n          |\n__________|__________\n";
        private const string HangmanOnlyHead = "           _______\n          |       |\n          |       |\n          |       O\n          |\n          |\n          |\n          |\n__________|__________\n";
        private const string HangmanRope = "           _______\n          |       |\n          |       |\n          |\n          |\n          |\n          |\n          |\n__________|__________\n";
        private const string HangmanBeam = "           _______\n          |\n          |\n          |\n          |\n          |\n          |\n          |\n__________|__________\n";
        private const string HangmanPost = "          |\n          |\n          |\n          |\n          |\n          |\n          |\n__________|__________\n";
        private const string HangmanBase = "____________________\n";

        public Hangman()
        {
            Alive = true;
        }
        #region Methods
        public void SetAttempts(string difficulty)
        {
            switch (difficulty.ToUpper())
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

        public void SetHangman(int wrongAnswer)
        {
            if (Attempts == 8)
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
                        Alive = false;
                        break;
                    default:
                        HangmanFigure = "";
                        break;
                }
            }
            else if (Attempts == 6)
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
                        HangmanFigure = HangmanRope;
                        break;
                    case 4:
                        HangmanFigure = HangmanOnlyHead;
                        break;
                    case 5:
                        HangmanFigure = HangmanNoLegs;
                        break;
                    case 6:
                        HangmanFigure = FullHangman;
                        Alive = false;
                        break;
                    default:
                        HangmanFigure = "";
                        break;
                }
            }
            else
            {
                switch (wrongAnswer)
                {
                    case 1:
                        HangmanFigure = HangmanBase;
                        break;
                    case 2:
                        HangmanFigure = HangmanBeam;
                        break;
                    case 3:
                        HangmanFigure = HangmanOnlyHead;
                        break;
                    case 4:
                        HangmanFigure = HangmanNoLegs;
                        break;
                    case 5:
                        HangmanFigure = FullHangman;
                        Alive = false;
                        break;
                    default:
                        HangmanFigure = "";
                        break;
                }
            }
        }

        public void SetHangmanArea()
        {
            HangmanArea = "========================\n";
            HangmanArea += GetHangman();
            HangmanArea += "========================\n";
        }

        public string GetHangmanArea()
        {
            return HangmanArea;
        }

        #endregion
    }
}
