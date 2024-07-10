using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to find the Armstrong number for a given range of number.
              Test Data :  
              Input starting number of range: 1  
              Input ending number of range : 1000  
              Expected Output : 
              Armstrong numbers in given range are: 1 153 370 371 407  
            */


            Console.WriteLine("\n### Find the Armstrong number for a given range of number ###\n");
            Console.Write("Input starting number of range: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Input ending number of range: ");
            int end = int.Parse(Console.ReadLine());

            Console.Write("Armstrong numbers in given range are: ");
            for (int num = start; num <= end; num++)
            {
                int sum = 0;
                int temp = num;
                while (temp != 0)
                {
                    int r = temp % 10;
                    sum += (int)Math.Pow(r, 3);
                    temp /= 10;
                }
                if (sum == num)
                {
                    Console.Write(num + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
