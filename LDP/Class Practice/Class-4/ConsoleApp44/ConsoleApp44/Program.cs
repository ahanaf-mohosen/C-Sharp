using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to find LCM of any two numbers using HCF.
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

            int hcf = findHCF(num1, num2);
            int lcm = (num1 * num2) / hcf;

            Console.WriteLine("The LCM of " + num1 + " and " + num2 + " is : " + lcm);
            Console.ReadLine();


            int findHCF(int n1, int n2)
            {
                int HCF = 1;

                for (int i = 1; i <= n1 && i <= n2; i++)
                {
                    if (n1 % i == 0 && n2 % i == 0)
                    {
                        HCF = i;
                    }
                }
                return HCF;
            }
        }
    }
}
