using System;

namespace ConsoleApplication
{
    class Class
    {
        static int[,] Input(Random rnd, int n, int m)
        {
            int[,] arr = new int[n, m];
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = rnd.Next(1, 10);
            return arr;
        }
        static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write("{0,3}", arr[i, j]);
        }
        static void Exercise(int[,] arr, int m)
        {
            if (m % 2 == 0)
            {
                int k = (m / 2) - 1;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    arr[i, k] ^= arr[i, k + 1];
                    arr[i, k + 1] ^= arr[i, k];
                    arr[i, k] ^= arr[i, k + 1];
                }
            }
            else
            {
                int s = m / 2;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    arr[i, 0] ^= arr[i, s];
                    arr[i, s] ^= arr[i, 0];
                    arr[i, 0] ^= arr[i, s];
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размерность матрицы:\nn= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m= ");
            int m = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[,] arr = Input(rnd, n, m);
            Console.WriteLine("\nИсходный массив:");
            Print(arr);
            Exercise(arr, m);
            Console.WriteLine("\nИзмененный массив:");
            Print(arr);
            Console.ReadKey();
        }
    }
}
