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

        public DateTime this[int index]
        {
            get { return date.AddDays(index); }
        }

        public static bool operator !(Date a)
        {
            return DateTime.DaysInMonth(a.Date1.Year, a.Date1.Month) != a.Date1.Day;
        }

        public static bool operator true(Date a)
        {
            return a.date.Day == 1 && a.date.Month == 1;
        }

        public static bool operator false(Date a)
        {
            return a.date.Day != 1 || a.date.Month != 1;
        }

        public static bool operator &(Date a, Date b)
        {
            return a.Date1.Equals(b.Date1);
        }

        public static explicit operator String(Date obj)
        {
            return " Год: " + obj.date.Year + " Месяц: " + obj.date.Month + " Число: " + obj.date.Day;
        }
    }

    class programm
    {
        static void Main(string[] args)
        {

            string st1 = "2009,1,1";
            Date f = new Date(st1);
            Console.Write("Введите i: ");
            string st2 = Console.ReadLine();
            int i = Convert.ToInt16(st2);
            Console.Write("Заданная дата: ");
            Console.WriteLine(f.Date1);
            Console.Write("Прошлый день: ");
            Console.WriteLine(f.PrevDay());
            Console.Write("Следующий день: ");
            Console.WriteLine(f.NextDay());
            Console.Write("Дней до конца месяца: ");
            Console.WriteLine(f.DaysLeft());
            Console.Write("Високосный ли год?: ");
            Console.WriteLine(f.IsLeap);
            Console.WriteLine("Датa i-того по счету дня относительно установленной даты: {0}", f[i]);
            Console.WriteLine("Дата является последним днем месяца?: {0}", !f);
            Console.WriteLine("Преобразования класса DataTime в тип string: {0}", (string)f);
            Console.WriteLine("");
            Console.Write("Введите дату: ");
            string st = Console.ReadLine();
            Date A = new Date(st);
            Console.Write("Определенная дата: ");
            Console.WriteLine(A.Date1);
            Console.Write("Прошлый день: ");
            Console.WriteLine(A.PrevDay());
            Console.Write("Следующий день: ");
            Console.WriteLine(A.NextDay());
            Console.Write("Дней до конца месяца: ");
            Console.WriteLine(A.DaysLeft());
            Console.Write("Високосный ли год?: ");
            Console.WriteLine(A.IsLeap);
            Console.WriteLine("Поля равны?: {0}", f & A);
            Console.ReadKey();
        }
    }
}
}
