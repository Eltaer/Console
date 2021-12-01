using System;

namespace Zadanie_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Цикл For: ");

            for (int i = B; i >= A; i--) 
            { 
                Console.WriteLine(i * i * i + " "); 
            }

            Console.WriteLine("Цикл While: ");

            int c = B;
            while (c >= A)
            {
                Console.WriteLine( c * c * c + " ");
                c--;
            }

            Console.WriteLine("Цикл Do While: ");

            int x = B;
            do
            {
                Console.WriteLine(x * x * x + " ");
                x--;
            }
            while (x >= A);

            Console.ReadKey();
        }
    }
}
