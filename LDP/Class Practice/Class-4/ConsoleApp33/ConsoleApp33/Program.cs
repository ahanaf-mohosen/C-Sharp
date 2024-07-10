using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to display by Pascal's triangle. 
              Test Data :  
              Input number of rows: 5  
              Expected Output : 
              1 1 1 1 2 1 1 3 3 1 1 4 6 4 1 
            */


            Console.WriteLine("\n### Pascal's triangle ###\n");
            Console.Write("Input number of rows: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num - i; j++)
                {
                    Console.Write("");
                }
                int value = 1;
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(value);
                    value = value * (i - k) / k;
                }
            }
            Console.ReadLine();
        }
    }
}
