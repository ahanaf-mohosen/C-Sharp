using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to display the n terms of even natural number and their sum.
              Test Data : 
              Input number of terms : 5  
              Expected Output :  
              The even numbers are :2 4 6 8 10  
              The Sum of even Natural Number upto 5 terms : 30 
            */


            Console.WriteLine("\n### Display the n terms of even natural number and their sum ###\n");
            Console.Write("Input number of terms: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            Console.Write("The even numbers are: ");
            for (int i = 1; i <= num * 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                    sum += i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"The Sum of even Natural Number upto {num} terms: {sum}");
            Console.ReadLine();
        }
    }
}
