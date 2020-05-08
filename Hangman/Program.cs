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

            Console.WriteLine("Enter Word");
            //Console.ReadKey();
            word.SetWord(Console.ReadLine());
            word.SetWordLength();
            Console.WriteLine(word.GetWord());
            Console.ReadKey();
        }
    }
}
