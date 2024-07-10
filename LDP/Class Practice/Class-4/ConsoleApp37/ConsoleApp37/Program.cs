using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to display the number in reverse order.
              Test Data :  
              Input a number: 12345  
              Expected Output : 
              The number in reverse order is : 54321 
            */


            Console.WriteLine("\n### Display the number in reverse order ###\n");
            Console.Write("Input a number: ");
            int num = int.Parse(Console.ReadLine());

            int rev = 0;
            Console.Write("The number in reverse order is: ");
            while (num > 0)
            {
                int digit = num % 10;
                rev = (rev * 10) + digit;
                num /= 10;
            }
            Console.WriteLine(rev);
            Console.ReadLine();
        }
    }
}
