using System;

namespace _3._1
{
    class Program
    {
        static double f(double x)
        {
            x = 101;
            return x % 10;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите x= ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b= ");
            double b = double.Parse(Console.ReadLine());
            double z = f(a) + f(b);
            Console.WriteLine("z= " + z);
            Console.ReadKey();
        }
    }
}
