using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to find LCM of any two numbers. 
              Test Data :  
              Input 1st number for LCM: 15  
              Input 2nd number for LCM: 20 
              Expected Output : 
              The LCM of 15 and 20 is : 60  
            */


            Console.WriteLine("\n### Find LCM of any two numbers ###\n");

            Console.Write("Input 1st number for LCM: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input 2nd number for LCM: ");
            int num2 = int.Parse(Console.ReadLine());

            int maxVal = (num1 > num2) ? num1 : num2;

            int lcm = 0;
            for (int i = maxVal; ; i += maxVal)
            {
                if (i % num1 == 0 && i % num2 == 0)
                {
                    lcm = i;
                    break;
                }
            }

            Console.WriteLine("The LCM of " + num1 + " and " + num2 + " is: " + lcm);
            Console.ReadLine();
        }
    }
}
