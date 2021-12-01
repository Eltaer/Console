using System;

namespace Zadanie_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("Введите x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Введите y: ");
            y = double.Parse(Console.ReadLine());
            if ((x*x + y*y < 144) && y-Math.Abs(x) > 0)
            {
                Console.WriteLine("Точка попала в заштрихованную область");
            }
            else if ((x * x + y * y == 144) && y - Math.Abs(x) == 0)

            {
                Console.WriteLine("Точка на границе заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не попала в заштрихованную область");
            }
            Console.ReadLine();

        }
    }
}
