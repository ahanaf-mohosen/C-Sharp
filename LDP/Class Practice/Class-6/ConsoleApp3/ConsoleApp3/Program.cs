using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*What is List?  
             
             *Take user input 15-25 and keep in List and print the data using foreach loop. 
              Then remove the last 2 items of the list.
             */



            /*a List is a data structure that stores an ordered collection of elements. 
              It allows you to add, remove, and access elements based on their index.*/


            try
            {
                List<int> userInput = new List<int>();
                Console.Write("Enter a range of numbers (e.g. 15-25): ");
                int n = int.Parse(Console.ReadLine());
                //Console.Write("Enter start range of number: ");
                int start = 15; // int.Parse(Console.ReadLine());
                //Console.Write("Enter end range of number: ");
                int end = 25; // int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.Write("Input Number - {0}: ", i);
                    int input = int.Parse(Console.ReadLine());
                    if (input < start && input > end)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        userInput.Add(input);
                    }
                }
                Console.WriteLine();
                Console.Write("Your input number is: ");
                foreach (int user in userInput)
                {
                    Console.Write(user + "\t");
                }
                int count = userInput.Count;
                userInput.RemoveRange(count - 2, 2);
                Console.WriteLine();
                Console.Write("Your output number is: ");
                foreach (int user in userInput)
                {
                    Console.Write(user + "\t");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
