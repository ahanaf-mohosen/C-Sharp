using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to display the first 10 natural numbers. 
              Expected Output : 
              1 2 3 4 5 6 7 8 9 10 
            */

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
