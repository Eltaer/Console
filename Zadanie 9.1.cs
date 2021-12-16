using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileWork
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] n = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                string FileName = @"C:\Users\stu-pkspk219\Desktop\file.txt";
                using (StreamWriter sw = new StreamWriter(FileName))
                {
                    foreach (int i in n)
                    {
                        if (i % 2 == 0)
                        {
                            sw.WriteLine(i);
                        }
                    }
                }
                using (StreamReader sr = new StreamReader(FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
