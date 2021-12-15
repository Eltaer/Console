using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication41
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите строку:");
                string text = Console.ReadLine();
                string[] splitted = text.Split(new[] { ' ', '.', '?', '!', ')', '(', ',', ':' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine("Введите символ:");
                char symbol = char.Parse(Console.ReadLine());
                foreach (string s in splitted)
                {
                    if (s.Contains(symbol))
                    {
                        text = text.Replace(s, string.Empty);
                    }
                }
                Console.WriteLine(text);
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            Console.ReadKey();
        }
    }
}