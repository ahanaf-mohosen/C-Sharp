using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to find out the sum of in A.P. series. 
              Test Data :  
              Input the starting number of the A.P. series: 1  
              Input the number of items for the A.P. series: 10  
              Input the common difference of A.P. series: 4  
              Expected Output : 
              The Sum of the A.P. series are :  
              1 + 5 + 9 + 13 + 17 + 21 + 25 + 29 + 33 + 37 = 190  
            */



            Console.WriteLine("\n### Find out the sum of in A.P. series ###\n");

            Console.Write("Input the starting number of the A.P. series: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Input the number of items for the A.P. series: ");
            int item = int.Parse(Console.ReadLine());
            Console.Write("Input the common difference of A.P. series: ");
            int difference = int.Parse(Console.ReadLine());

            int sum = 0;
            int term = item;
            Console.WriteLine("The Sum of the A.P. series are: ");
            for (int i = 1; i <= item; i++)
            {
                Console.Write(term + " + ");
                sum += term;
                term += difference;
            }
            Console.Write("\b\b = " + sum);
            Console.ReadLine();
        }
    }
}
