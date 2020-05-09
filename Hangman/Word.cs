using System;
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

        #region Methods
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

        public void CreateStateArray()
        {
            WordState = new int[WordArray.Length];
            for (int i = 0; i < WordState.Length; i++)
            {
                WordState[i] = 0;
            }
        }

        public char GetCharFromArray(int charPosition)
        {
            return WordArray[charPosition];
        }

        public void CheckGuessAgainstWord(char userGuess)
        {
            for(int i = 0; i < WordLength; i++)
            {
                if (WordArray[i] == userGuess)
                {
                    WordState[i] = 1;
                }
                Console.Write(WordState[i]);
            }

        }
        #endregion

    }
}
