using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to print a string in reverse order. 
              Test Data :  
              Input a string to reverse : Welcome  
              Expected Output : 
              Reversed string is: emocleW
            */


            Console.WriteLine("\n### Print a string in reverse order ###\n");

            while (true)
            {
                Console.Write("Input a string to reverse: ");
                string str = Console.ReadLine();
                int length = str.Length;
                Console.Write("Reversed string is: ");
                for (int i = length - 1; i >= 0; i--)
                {
                    Console.Write(str[i]);
                }
                Console.WriteLine("\n");    
            }
            Console.ReadLine();
        }
    }
}
