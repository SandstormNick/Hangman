using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Dynamic;

namespace Hangman
{
    class Game
    {
        private bool GameRun = true;
        private char UserGuess { get; set; }
        private bool ValidGuess { get; set; }
        Regex regex = new Regex("^[a-zA-Z]*$");
        private char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private int[] AlphaGuess { get; set; }
        private string CorrectGuesses { get; set; }
        private string IncorrectGuesses { get; set; }
        private string GuessStrings { get; set; }

        public Game()
        {
            AlphaGuess = new int[alphabet.Length];
            for (int i = 0; i < AlphaGuess.Length; i++)
            {
                AlphaGuess[i] = 0;
            }
            CorrectGuesses = "Correct Guesses:\n";
            IncorrectGuesses = "Incorrect Guesses:\n";
        }

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
                SetAlphaGuess();
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

        public void SetAlphaGuess()
        {
            if (ValidGuess)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (alphabet[i] == UserGuess)
                    {
                        AlphaGuess[i] = 1;
                    }
                }
            }
        }

        public void SetGuessStrings(bool correctGuess)
        {
            if (ValidGuess)
            {
                if (correctGuess)
                {
                    CorrectGuesses += UserGuess.ToString() + "  ";
                }
                else
                {
                    IncorrectGuesses += UserGuess.ToString() + "  ";
                }
            }
        }

        public void SetGuessStrings()
        {
            GuessStrings = CorrectGuesses + "\n\n" + IncorrectGuesses;
        }

        public string DisplayGuessStrings()
        {
            SetGuessStrings();
            return GuessStrings;
        }
        #endregion
    }
}
