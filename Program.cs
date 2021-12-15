using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
            {
                Console.Write("Введите строку: ");
                string s = Console.ReadLine();
                Console.WriteLine(IsThere(s));
                Console.ReadKey();
            }

        static bool IsThere(string s)
            {
            for (int i = 0; i < s.Length - 1; i++)
                if (s[i] == s[i + 1])
                    return true;
            return false;
            } 
    }
}
