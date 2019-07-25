using System;
using Speller;
namespace Spell
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine($"Enter a number upto {int.MaxValue}");
                var number = 0;
                int.TryParse(Console.ReadLine(), out number);
                var spltotext = new SpellToText(); 

                try
                {    
                    Console.WriteLine(spltotext.Spell(number));
                }
                catch (NegativeIntegerException ex)
                {
                    Console.WriteLine($"[{number}]: {ex.Message}");
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
