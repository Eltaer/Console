using System;

namespace Zadanie_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                    Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
