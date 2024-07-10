using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to display the multiplication table of a given integer. 
              Test Data : 
              Input the number (Table to be calculated) : 15  
              Expected Output :  
              15 X 1 = 15  
              ... 
              ...  
              15 X 10 = 150 
            */

            Console.Write("Input the number (Table to be calculated): ");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num*i}");
            }
            Console.ReadLine();
        }
    }
}
