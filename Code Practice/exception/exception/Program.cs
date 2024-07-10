using System;
using System.IO;

namespace exception
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StreamReader strmreadr = new StreamReader(@"F:\C# Programing\Code Practice\ExceptionHandling\demo.txt");
            Console.WriteLine(strmreadr.ReadToEnd());
            strmreadr.Close();
            Console.ReadLine();
        }
    }
}