using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WPFArrayFuncties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namen = { "Peter", "Tom", "Piet", "Ahmed", "Benny", "Anna", "Jane", "Ali", "John", "Tom" };

            Deel1(namen);
            Deel2(namen);
            Deel3(namen);

            Console.ReadLine();

        }

        private static void Deel1(string[] names)
        {

            Console.Write("Geef een naam: ");
            string naam = Console.ReadLine();

            Console.WriteLine($"De naam {naam} staat op index: {Array.IndexOf(names, naam)}.");
        }

        private static void Deel2(string[] names)
        {
            Console.Write("Geef een letter: ");
            string inputLetter = Console.ReadLine().ToUpper();
            string[] nameStartsWithLetter = Array.FindAll(names, 
                name => name.StartsWith(inputLetter));

            Console.Write($"Namen die beginnen met {inputLetter}: ");
            foreach (string name in nameStartsWithLetter)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }

        private static void Deel3(string[] names)
        {
            int firstNumber = -1;
            int secondNumber = -1;

            do
            {
                do
                {
                    Console.Write("Geef eerste getal: ");
                    if (!int.TryParse(Console.ReadLine(), out firstNumber) || firstNumber < 0 || firstNumber > names.Length - 1)
                    {
                        Console.WriteLine("Geef een geldig getal");
                        firstNumber = -1;
                    }
                } while (firstNumber == -1);

                do
                {
                    Console.Write("Geef tweede getal: ");
                    if (!int.TryParse(Console.ReadLine(), out secondNumber) || secondNumber < 0 || secondNumber > names.Length - 1)
                    {
                        Console.WriteLine("Geef een geldig getal");
                        secondNumber = -1;
                    }
                } while (secondNumber == -1);

            } while (firstNumber + secondNumber > names.Length);


            Console.WriteLine($"Ongesorteerde array: {string.Join(", ", names)}");
            Array.Sort(names, firstNumber, secondNumber);
            Console.WriteLine($"Gesorteerde array: {string.Join(", ", names)}");
        }
    }
}
