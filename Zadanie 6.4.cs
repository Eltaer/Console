using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[,] array = new int[n, m];
            Console.WriteLine("Исходная матрица: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = r.Next(-100, 100);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] array2 = new int[2, m];
            for (int i = 0; i < array.GetLength(1); i++)
            {
                int s = default, count = default;
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    if (array[j, i] < 0) { s += array[j, i]; count++; }
                }
                array2[0, i] = s;
                array2[1, i] = count;
            }
            Console.WriteLine("Вывод отрицательных: ");
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write(array2[i, j] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
