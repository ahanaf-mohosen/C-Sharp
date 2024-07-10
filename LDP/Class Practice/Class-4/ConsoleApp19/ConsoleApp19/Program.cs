using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to display the n terms of harmonic series and their sum.
              1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms 

              Test Data :  
              Input the number of terms : 5  
              Expected Output : 
              1/1 + 1/2 + 1/3 + 1/4 + 1/5 +  
              Sum of Series upto 5 terms : 2.283334  
            */

            Console.Write("Input the term of harmonic series: ");
            int num = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += 1.0 / i;
            }
            Console.WriteLine($"Sum of series uptp {num} terms : {sum:F6}");
            Console.ReadLine();
        }
    }
}
