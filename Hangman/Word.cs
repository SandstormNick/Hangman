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
        #endregion

    }
}
