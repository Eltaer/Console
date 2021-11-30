using System;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double s, r;
            Console.Write("Введите площадь поверхности: ");
            s = double.Parse(Console.ReadLine());
            r = Math.Sqrt(s / 6);
            Console.Write("Ребро куба = ");
            Console.Write(r);
            Console.ReadLine();
        }
    }
}
