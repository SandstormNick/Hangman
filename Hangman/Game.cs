using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hangman
{
    class Game
    {
        private bool GameRun = true;
        private char UserGuess { get; set; }
        private bool ValidGuess { get; set; }
        Regex regex = new Regex("^[a-zA-Z0-9]*$");

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
            if (regex.IsMatch(theGuess) && theGuess != "")
            {
                char[] userString = theGuess.ToUpper().ToCharArray();
                UserGuess = userString[0];
                ValidGuess = true;
            }
            else
            {
                ValidGuess = false;
            }
            
        }

        public char GetUserGuess()
        {
            return UserGuess;
        }

        public void ClearConsoleWindow()
        {
            Console.Clear();
        }

        public bool GetValidGuessState()
        {
            return ValidGuess;
        }

        public void DisplayVictoryMessage()
        {
            Console.WriteLine("Well Done! You figured out the word!");
        }

        public void DisplayDefeatMessage()
        {
            Console.WriteLine("The man has been hung! Unlucky!");
        }
        #endregion
    }
}
