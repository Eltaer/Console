using System;

namespace Zadanie_1._2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Двузначное число: ");
            int num = int.Parse(Console.ReadLine());
            int sum = num % 10 + (num / 10) % 10;
            Console.WriteLine((sum % 3) == 0 ? "Кратно" : "Не кратно");
            Console.ReadKey(true);
        }
    }
}
