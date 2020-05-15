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
            //Start Game
            Game theGame = new Game();
            
            while (theGame.GetPlayGameStatus())
            {
                theGame = new Game();
                theGame.RestartGameStatus();
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
                hangMan.SetHangman(0);
                hangMan.SetHangmanArea();

                theGame.ClearConsoleWindow();
                theGame.DisplayExitInfo();
                Console.ReadLine();
                while (theGame.GetGameStatus())
                {
                    theGame.ClearConsoleWindow();
                    if (word.GetWordCompleted() || hangMan.CheckManStatus() == false)
                    {
                        theGame.ChangeGameStatus();
                    }
                    else
                    {
                        theGame.DisplayRemainingTurns(hangMan.GetAttempts());
                        hangMan.DisplayHangmanArea();
                        theGame.PrintWord(word.GetWordLength(), word.GetWordArray(), word.GetWordState());
                        Console.WriteLine(theGame.DisplayGuessStrings());
                        theGame.EnterGuess();
                        theGame.SetUserGuess(Console.ReadKey());
                        word.CheckGuessAgainstWord(theGame.GetUserGuess(), theGame.GetValidGuessState());
                        theGame.SetGuessStrings(word.GetCorrectGuessState());
                        theGame.SetAlphaGuess(word.GetCorrectGuessState());
                        word.SetWordCompleted();
                        hangMan.SetHangman(theGame.GetWrongAnswerCount());
                        hangMan.SetHangmanArea();
                    }
                }

                hangMan.DisplayHangmanArea();
                if (word.GetWordCompleted())
                {
                    theGame.DisplayVictoryMessage();
                }
                else
                {
                    theGame.DisplayDefeatMessage();
                }
                theGame.PromptUserToPlayAgain();
                theGame.SetPlayGameStatus(Console.ReadKey().KeyChar);
                theGame.ClearConsoleWindow();
            }

            //Console.ReadKey();
        }
    }
}

//TO DO:
//4) Some code refactoring -- make it neater --make get rid of all the cw's
// Finish these 4 and then start another little proj
