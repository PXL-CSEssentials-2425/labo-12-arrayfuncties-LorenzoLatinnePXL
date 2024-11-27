using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFArrayFuncties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namen = { "Peter", "Tom", "Piet", "Ahmed", "Benny", "Anna", "Jane", "Ali", "John", "Tom" };

            Console.Write("Geef een naam: ");
            string naam = Console.ReadLine();

            Console.WriteLine($"De naam {naam} staat op index: {Array.IndexOf(namen, naam)}.");

            Console.Write("Geef een letter: ");
            string letterVanNaam = Console.ReadLine().ToUpper();
            string[] nameStartsWithLetter = Array.FindAll(namen, name => name.StartsWith(letterVanNaam));

            Console.Write($"Namen die beginnen met {letterVanNaam}: ");
            foreach ( string name in nameStartsWithLetter )
            {
                Console.Write(name + " ");
            }
            Console.ReadLine();


        }
    }
}
