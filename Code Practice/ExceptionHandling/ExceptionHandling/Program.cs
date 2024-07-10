using System;
using System.IO;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader strmreadr = new StreamReader(@"F:\C# Programing\Code Practice\ExceptionHandling\demo1.txt");
            Console.WriteLine(strmreadr.ReadToEnd());
            strmreadr.Close();
            Console.ReadLine();
        }
    }
}
