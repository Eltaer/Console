using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите шаг h: ");
            double h = double.Parse(Console.ReadLine());
            f(a, b, h);
            for (double x = 0; x <= 30; x += 1)
            {
                f(x, out double y);
                Console.WriteLine($"f({x,5:F})={y,10:F2}");
            }
            Console.Read();
        }
        static void f(double a, double b, double h)
        {
            double f = 0;
            for (double x = a; x <= b; x += h)
            {
                if (Math.Abs(x) < a)
                    f = 0;
                else if (Math.Abs(x) > a)
                    f = (x - a) / (x + a);
                else if (Math.Abs(x) == a)
                    f = 1;
                Console.WriteLine("f({0,5:F})={1,10:F2}", x, f);
            }
        }
        static void f(double x, out double y)
        {
            double a = 10;
            y = x < a
            ? 0
            : x > a
            ? (x - a) / (x + a)
            : 1;
        }
    }
}