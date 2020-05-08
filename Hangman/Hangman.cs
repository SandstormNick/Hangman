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

        public void SetAttempts(char difficulty)
        {
            switch (difficulty)
            {
                case 'H':
                    Attempts = 5;
                    break;
                case 'M':
                    Attempts = 6;
                    break;
                default:
                    Attempts = 8;
                    break;
            }
        }
    }
}
