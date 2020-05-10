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

        public void ChangeGameStatus()
        {
            GameRun = false;
        }

        public string PrintWord(int wordLength, char[] wordArray, int[] wordState)
        {
            string wordPlaceholder = "";
            for (int i = 0; i < wordLength; i++)
            {
                if (wordState[i] == 1)
                {
                    wordPlaceholder += wordArray[i].ToString() + " ";
                }
                else
                {
                    wordPlaceholder += "_ ";
                }
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
