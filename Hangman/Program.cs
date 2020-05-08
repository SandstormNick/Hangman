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

            Console.WriteLine("Enter Word");
            //Console.ReadKey();
            word.SetWord(Console.ReadLine());
            word.SetWordLength();

            Console.WriteLine("Choose Difficulty: Easy(E) OR Medium(M) OR Hard(H)");
            hangMan.SetAttempts(Console.ReadLine());

            Console.WriteLine(word.GetWord());
            Console.ReadKey();
        }
    }
}
