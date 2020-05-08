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
        #endregion
    }
}
