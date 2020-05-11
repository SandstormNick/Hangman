using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Word word = new Word();
            Hangman hangMan = new Hangman();

            //Get Word Before Game Starts
            word.PromptWord();
            word.SetWord(Console.ReadLine());
            word.SetWordLength();
            word.CreateWordArray(word.GetWord());
            word.CreateStateArray();
            //TO DO: put all this setup into a constructor

            //Set Difficulty
            word.PromptDifficulty();
            hangMan.SetAttempts(Console.ReadLine());
            hangMan.SetHangman(word.GetWrongAnswerCount());
            hangMan.SetHangmanArea();

            //Start Game
            Game theGame = new Game();
            
            //GameStatus and CheckManStatus must be true
            while (theGame.GetGameStatus())
            {
                theGame.ClearConsoleWindow();
                if (word.GetWordCompleted() || hangMan.CheckManStatus() == false)
                {
                    theGame.ChangeGameStatus();
                }
                Console.WriteLine(hangMan.GetHangmanArea());
                Console.WriteLine(theGame.PrintWord(word.GetWordLength(), word.GetWordArray(), word.GetWordState()));
                Console.WriteLine(theGame.EnterGuess());
                theGame.SetUserGuess(Console.ReadLine());
                word.CheckGuessAgainstWord(theGame.GetUserGuess(), theGame.GetValidGuessState());
                word.SetWordCompleted();
                hangMan.SetHangman(word.GetWrongAnswerCount());
                hangMan.SetHangmanArea();
            }

            if (word.GetWordCompleted())
            {
                theGame.DisplayVictoryMessage();
            }
            else
            {
                theGame.DisplayDefeatMessage();
            }

            Console.ReadKey();
        }
    }
}

//TO DO:
//Kepp track of the letters entered
//If they enter the same letter twice, don't count it
//Option to restart another game
