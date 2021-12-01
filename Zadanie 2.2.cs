using System;

namespace Zadanie_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество пройденных месяцев: ");
            int m = Int32.Parse(Console.ReadLine());
            string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            Console.WriteLine(months[DateTime.Now.AddMonths(-m).Month - 1]);
        }
    }
}
