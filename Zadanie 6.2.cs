using System;
using System.Linq;

namespace Zadanie_6._2
{
    class Program
    {
        
        static int[] Input()
        {
            Console.Write("Введите размер массива: ");
            int razmer = Int32.Parse(Console.ReadLine());
            int[] arr = new int[razmer];
            for (int i = 0; i < razmer; i++)
            {
                Console.Write("a[{0}]= ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            return arr;
        }
        static int Max(int[] arr)
        {
            int max = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                max = arr.Max<int>();
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[] myArray = Input();
            int max = Max(myArray);
            int num = 0;
            for (int i = 0; i < myArray.Length; ++i)
                if (myArray[i] == max)
                    num = i;

            Console.WriteLine("Максимальный элемент: " + max + "\nEго номер: " + num);
            Console.ReadLine();
        }
    }
}
