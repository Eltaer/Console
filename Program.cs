using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;
using System.Globalization;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время в формате чч:мм");
            string result = null;
            string stringWithTime = Console.ReadLine();
            try
            {
                Console.Write("Введите удаляемые часы: ");
                double n = double.Parse(Console.ReadLine());
                result = Regex.Match(stringWithTime, "[0-2][0-9]:[0-5][0-9]", RegexOptions.IgnoreCase).Value;
                DateTime dt = DateTime.Parse(result);
                Console.WriteLine("Время из строки минус {1} часов: {0:t}", dt.AddHours(n - (n + n)), n);
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            Console.Read();
        }
    }
}
