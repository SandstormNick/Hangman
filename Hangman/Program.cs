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

                //Get Word Before Game Starts
                Word word = new Word();
                Hangman hangMan = new Hangman();

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
                        theGame.DisplayGuessStrings();
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
        }
    }
}
