using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Dynamic;
using System.ComponentModel;

namespace Hangman
{
    class Game
    {
        private bool  PlayGame { get; set; }
        private bool GameRun { get; set; }
        private char UserGuess { get; set; }
        private bool ValidGuess { get; set; }
        Regex regex = new Regex("^[a-zA-Z]*$");
        private char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private int[] AlphaGuess { get; set; }
        private string CorrectGuesses { get; set; }
        private string IncorrectGuesses { get; set; }
        private string GuessStrings { get; set; }
        private int WrongAnswer { get; set; }

        public Game()
        {
            PlayGame = true;
            GameRun = true;
            WrongAnswer = 0;
            AlphaGuess = new int[alphabet.Length];
            for (int i = 0; i < AlphaGuess.Length; i++)
            {
                AlphaGuess[i] = 0;
            }
            CorrectGuesses = "Correct Guesses:\n";
            IncorrectGuesses = "Incorrect Guesses:\n";
        }

        #region Methods
        public bool GetPlayGameStatus()
        {
            return PlayGame;
        }

        public void PromptUserToPlayAgain()
        {
            Console.WriteLine("If you want to play again hit P button or hit any other button to exit.");
        }

        public void SetPlayGameStatus(char userChoice)
        {
            if (userChoice != 'P')
            {
                PlayGame = false;
            }
        }
        public bool GetGameStatus()
        {
            return GameRun;
        }

        public void ChangeGameStatus()
        {
            GameRun = false;
        }

        public void RestartGameStatus()
        {
            GameRun = true;
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

        public void SetAlphaGuess(bool correctGuess)
        {
            if (ValidGuess)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (alphabet[i] == UserGuess)
                    {
                        if (AlphaGuess[i] == 0 && !correctGuess)
                        {
                            UpdateWrongAnswerCount();
                        }
                        AlphaGuess[i] = 1;
                    }
                }
            }
        }

        public void SetGuessStrings(bool correctGuess)
        {
            bool addToString = false;
            if (ValidGuess)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (alphabet[i] == UserGuess)
                    {
                        if (AlphaGuess[i] == 0)
                        {
                            addToString = true;
                            break;
                        }
                    }
                }

                if (addToString)
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

        public void UpdateWrongAnswerCount()
        {
            WrongAnswer++;
        }

        public int GetWrongAnswerCount()
        {
            return WrongAnswer;
        }
        #endregion
    }
}
