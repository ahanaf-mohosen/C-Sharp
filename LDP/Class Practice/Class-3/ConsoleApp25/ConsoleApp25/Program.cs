using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation.  

              Test Date and Expected Output 
              Enter the first Integer: 10 
              Enter the second Integer: 2 

              Here are the options :
            
              1-Addition. 
              2-Substraction. 
              3-Multiplication.
              4-Division. 
              5-Exit. 

              Input your choice: 3 
              The Multiplication of 10 and 2 is: 20
            */

            Console.WriteLine("\n### Menu-Driven Program to perform a simple calculation ###\n");
            while (true)
            {
                Console.Write("Enter the first integer: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter the second integer: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Here are the options:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                Console.Write("Your Choice: ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, num1 + num2);
                        break;
                    case 2:
                        Console.WriteLine("The difference of {0} and {1} is: {2}", num1, num2, num1 - num2);
                        break;
                    case 3:
                        Console.WriteLine("The multiplication of {0} and {1} is: {2}", num1, num2, num1 * num2);
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: division by zero.");
                        }
                        else
                        {
                            Console.WriteLine("The division of {0} and {1} is: {2:F2}", num1, num2, (double)num1 / num2);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}
