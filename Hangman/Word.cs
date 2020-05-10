﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Word
    {
        private string ChosenWord { get; set; }
        private int WordLength { get; set; }
        private char[] WordArray { get; set; }
        private int[] WordState { get; set; }
        private int WrongAnswer { get; set; }
        private bool WordCompleted { get; set; }

        public Word()
        {
            WordCompleted = false;
            WrongAnswer = 0;
        }

        #region Methods
        public void PromptWord()
        {
            Console.WriteLine("Enter Word");
        }

        public void PromptDifficulty()
        {
            Console.WriteLine("Choose Difficulty: Easy(E) OR Medium(M) OR Hard(H)");
        }

        public void SetWord(string userWord)
        {
            ChosenWord = userWord;
        }

        public string GetWord()
        {
            return ChosenWord;
        }

        public void SetWordLength()
        {
            WordLength = ChosenWord.Length;
        }

        public int GetWordLength()
        {
            return WordLength;
        }

        public void CreateWordArray(string word)
        {
            WordArray = word.ToCharArray();
        }

        public char[] GetWordArray()
        {
            return WordArray;
        }

        public void CreateStateArray()
        {
            WordState = new int[WordArray.Length];
            for (int i = 0; i < WordState.Length; i++)
            {
                WordState[i] = 0;
            }
        }

        public int[] GetWordState()
        {
            return WordState;
        }

        public char GetCharFromArray(int charPosition)
        {
            return WordArray[charPosition];
        }

        public void CheckGuessAgainstWord(char userGuess)
        {
            bool correctGuess = false;
            for(int i = 0; i < WordLength; i++)
            {
                if (WordArray[i] == userGuess)
                {
                    WordState[i] = 1;
                    correctGuess = true;
                }
            }

            if (correctGuess == false)
            {
                UpdateWrongAnswerCount();
            }
        }

        public void UpdateWrongAnswerCount()
        {
            WrongAnswer++;
        }

        public int GetWrongAnswerCount()
        {
            return WrongAnswer;
        }

        public void SetWordCompleted()
        {
            bool wordIsComplete = true;
            for (int i = 0; i < WordState.Length; i++)
            {
                if (WordState[i] == 0)
                {
                    wordIsComplete = false;
                    break;
                }
            }

            if (wordIsComplete)
            {
                WordCompleted = true;
            }
        }

        public bool GetWordCompleted()
        {
            return WordCompleted;
        }
        #endregion

    }
}
