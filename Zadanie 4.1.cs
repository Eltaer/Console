using System;

namespace Zadanie_4._1
{
    class Program
    {
        static double cont_recurse(int cur, double n)
        {
            if (cur >= n)
                return n;
            return cur + 1.0 / cont_recurse(cur + 1, n);
        }

        static double continued(double n)
        {
            return 1.0 / cont_recurse(1, n);
        }

        static void Main(string[] args)
        {
            double n;
            Console.Write("Введите n: ");
            n = double.Parse(Console.ReadLine());
            Console.Write("Ответ: " + continued(n));
            return;
        }
        
    }
}
