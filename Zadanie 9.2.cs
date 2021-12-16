using System;
using System.IO;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\stu-pkspk219\Desktop\file2.txt";
            string longestString = GetLongestString(fileName);
            Console.WriteLine(longestString);
            Console.WriteLine("Длина строки: " + longestString.Length);
            Console.ReadKey();
        }

        public static string GetLongestString(string fileName)
        {
            string currentString, longestString = "";
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    currentString = reader.ReadLine();
                    if (currentString.Length > longestString.Length)
                        longestString = currentString;
                }
                return longestString;
            }
        }
    }
}
