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
            Console.WriteLine(hangMan.GetHangman());
            //Get Word Before Game Starts
            Console.WriteLine("Enter Word");
            word.SetWord(Console.ReadLine());
            word.SetWordLength();
            word.CreateWordArray(word.GetWord());
            word.CreateStateArray();
            //TO DO: put all this setup into a constructor

            //Set Difficulty
            Console.WriteLine("Choose Difficulty: Easy(E) OR Medium(M) OR Hard(H)");
            hangMan.SetAttempts(Console.ReadLine());


            //Start Game
            Game theGame = new Game();
            theGame.ClearConsoleWindow();
            //GameStatus and CheckManStatus must be true
            while (theGame.GetGameStatus() && hangMan.CheckManStatus())
            {
                Console.WriteLine(theGame.PrintWord(word.GetWordLength(), word.GetWordArray(), word.GetWordState()));
                Console.WriteLine(theGame.EnterGuess());
                theGame.SetUserGuess(Console.ReadLine());
                word.CheckGuessAgainstWord(theGame.GetUserGuess());
                theGame.ClearConsoleWindow();
            }

            Console.ReadKey();
        }
    }
}
