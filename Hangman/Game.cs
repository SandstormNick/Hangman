using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Game
    {
        private bool GameRun = true;
        private string UserGuess { get; set; }

        #region Methods
        public bool GetGameStatus()
        {
            return GameRun;
        }

        public string PrintWord(int wordLength)
        {
            string wordPlaceholder = "";
            for (int i = 0; i < wordLength; i++)
            {
                wordPlaceholder += "_ ";
            }
            return wordPlaceholder;
        }

        public string EnterGuess()
        {
            return ("Enter a letter: ");
        }

        public void GetUserGuess(string theGuess)
        {
            UserGuess = theGuess.Substring(0, 1);
        }

        public void ClearConsoleWindow()
        {
            Console.Clear();
        }
        #endregion
    }
}
