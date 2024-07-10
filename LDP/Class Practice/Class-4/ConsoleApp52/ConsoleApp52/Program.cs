using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to find the Sum of GP series. 
              Test Data :  
              Input the first number of the G.P. series: 1  
              Input the number or terms in the G.P. series: 5  
              Input the common ratio of G.P. series: 2 
              Expected Output : 
              The numbers for the G.P. series:  
              1 2 4 8 16 32  
              The 5 terms of G.P. : 16.000000  
              The Sum of the G.P. series : 63.000000  
            */


            Console.WriteLine("\n### Find the Sum of GP series ###\n");

            Console.Write("Input the first number of the G.P. series: ");
            double fstNum = int.Parse(Console.ReadLine());
            Console.Write("Input the number or terms in the G.P. series: ");
            int termNum = int.Parse(Console.ReadLine());
            Console.Write("Input the common ratio of G.P. series: ");
            int ratio = int.Parse(Console.ReadLine());

            double sum = 0;
            Console.WriteLine("The numbers for the G.P. series: ");
            for (int i = 0; i <= termNum; i++)
            {
                double term = fstNum * (double)Math.Pow(ratio, i);
                Console.Write(term + " ");
                sum += term;
            }
            Console.WriteLine();
            Console.WriteLine("The {0} terms of G.P. : {1:F6}", termNum, fstNum * (double)Math.Pow(ratio, termNum - 1));
            Console.WriteLine("The Sum of the G.P. series : {0:F6}", sum);
            Console.ReadLine();
        }
    }
}
