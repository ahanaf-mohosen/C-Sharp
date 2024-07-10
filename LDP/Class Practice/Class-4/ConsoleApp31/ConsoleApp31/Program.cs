using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to display the pattern like a diamond. 
             
                         *  
                        ***  
                       ***** 
                      ******* 
                     ********* 
                      ******* 
                       ***** 
                        *** 
                         * 
                        
           */


            Console.Write("Input the number of row: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = num - 1; i >= 1; i--)
            {
                for (int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
