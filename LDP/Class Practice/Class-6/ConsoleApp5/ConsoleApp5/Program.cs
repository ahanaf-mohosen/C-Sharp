using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*What is Stack?*/

            /*Take user input (10 Animal names) and keep in Stack and print the data using foreach loop. 
              Then remove the last 3 items of the Stack. Then print again.
            */



            try
            {
                Console.WriteLine("10 Animal names:");
                Stack<string> Animal = new Stack<string>();
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"animal - {i}: ");
                    string animal = Console.ReadLine();
                    Animal.Push(animal);
                }
                foreach (var stack in Animal)
                {
                    Console.WriteLine(stack.ToString());
                }
                Console.WriteLine();
                for (int i = 1; i <= 3; i++)
                {
                    Animal.Pop();
                }
                foreach (var stack in Animal)
                {
                    Console.WriteLine(stack.ToString());
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
