using System;

namespace ConsoleApplication1
{

    class Program
    {
        public static string[] s = new string[] { "лунатиков жили на луне", "лунатиков ворочались во сне" };

        static void Main()
        {
            Func(10);
        }

        static void Func(int num)
        {

            foreach (var line in s)
            {
                Console.WriteLine(num + " " + line);
            }
            if (num > 1)
            {
                Console.WriteLine("Один из лунатиков упал с луны во сне");
            }
            else
            {
                Console.WriteLine("И больше лунатиков не стало на луне");
            }
            if (num == 1) return;
            Func(num - 1);
        }
    }
}