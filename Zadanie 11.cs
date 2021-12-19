using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Date
    {
        DateTime date;

        public Date(DateTime date)
        {
            this.date = date;
        }

        public Date(string dateString)
        {
            date = DateTime.Parse(dateString);
        }

        public DateTime PrevDay()
        {
            return date.Subtract(TimeSpan.FromDays(1));
        }

        public DateTime NextDay()
        {
            return date.Add(TimeSpan.FromDays(1));
        }

        public int DaysLeft()
        {
            return DateTime.DaysInMonth(date.Year, date.Month) - date.Day;
        }

        public DateTime Date1
        {
            get { return date; }
            set { date = value; }
        }

        public bool IsLeap
        {
            get { return DateTime.IsLeapYear(date.Year); }
        }

    }

    class programm
    {
        static void Main(string[] args)
        {

            string st1 = "2009,1,1";
            Date f = new Date(st1);
            Console.Write("Определенная дата: ");
            Console.WriteLine(f.Date1);
            Console.Write("Прошлый день: ");
            Console.WriteLine(f.PrevDay());
            Console.Write("Следующий день: ");
            Console.WriteLine(f.NextDay());
            Console.Write("Дней до конца месяца: ");
            Console.WriteLine(f.DaysLeft());
            Console.Write("Високосный ли год?: ");
            Console.WriteLine(f.IsLeap);
            Console.WriteLine("");

            Console.Write("Введите дату: ");
            string st = Console.ReadLine();
            Date A = new Date(st);
            Console.Write("Заданная дата: ");
            Console.WriteLine(A.Date1);
            Console.Write("Прошлый день: ");
            Console.WriteLine(A.PrevDay());
            Console.Write("Следующий день: ");
            Console.WriteLine(A.NextDay());
            Console.Write("Дней до конца месяца: ");
            Console.WriteLine(A.DaysLeft());
            Console.Write("Високосный ли год?: ");
            Console.WriteLine(A.IsLeap);
            Console.ReadKey();
        }
    }
}
