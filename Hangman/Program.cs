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
            Console.WriteLine("Enter Word");
            word.SetWord(Console.ReadLine());
            word.SetWordLength();
            //Set Difficulty
            Console.WriteLine("Choose Difficulty: Easy(E) OR Medium(M) OR Hard(H)");
            hangMan.SetAttempts(Console.ReadLine());


            //Start Game
            Game theGame = new Game();
            //GameStatus and CheckManStatus must be true
            while (theGame.GetGameStatus() && hangMan.CheckManStatus())
            {
                for(int i = 0; i < word.GetWordLength(); i++)
                {
                    Console.Write("_ ");
                }
                Console.WriteLine();
                Console.Write("Enter a letter: ");
                Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
