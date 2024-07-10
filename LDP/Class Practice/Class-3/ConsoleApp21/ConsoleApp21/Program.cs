using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to read any digit, display in the word. 
              Test Data : 4 
              Expected Output: Four 
            */

            Console.WriteLine("\n### Read any digit, display in the word ###\n");
            Console.Write("Input a digit: ");
            int digit = int.Parse(Console.ReadLine());
            Console.WriteLine();
            string word;

            switch (digit)
            {
                case 0:
                    word = "Zero";
                    break;
                case 1:
                    word = "One";
                    break;
                case 2:
                    word = "Two";
                    break;
                case 3:
                    word = "Three";
                    break;
                case 4:
                    word = "Four";
                    break;
                case 5:
                    word = "Five";
                    break;
                case 6:
                    word = "Six";
                    break;
                case 7:
                    word = "Seven";
                    break;
                case 8:
                    word = "Eight";
                    break;
                case 9:
                    word = "Nine";
                    break;
                default:
                    word = "Invalid digit";
                    break;
            }
            Console.WriteLine(word);
            Console.ReadLine();

        }
    }
}
