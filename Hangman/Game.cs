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
        private char UserGuess { get; set; }

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

        public void SetUserGuess(string theGuess)
        {
            char[] userString = theGuess.ToCharArray();
            UserGuess = userString[0];
        }

        public char GetUserGuess()
        {
            return UserGuess;
        }

        public void ClearConsoleWindow()
        {
            Console.Clear();
        }
        #endregion
    }
}
