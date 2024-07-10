using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*What is Queue?*/

            /*Take user input (10 Vegetable names) and keep in Queue and print the data using foreach loop. 
              Then remove the last 6 items of the Stack. Then print again.
            */


            try
            {
                Console.WriteLine("10 Vegetable names:");
                Queue<string> Vegetable = new Queue<string>();
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"vegetable - {i}: ");
                    string vegetable = Console.ReadLine();
                    Vegetable.Enqueue(vegetable);
                }
                foreach (var queue in Vegetable)
                {
                    Console.WriteLine(queue);
                }
                Console.WriteLine();
                for (int i = 1; i <= 6; i++)
                {
                    Vegetable.Dequeue();
                }
                foreach (var queue in Vegetable)
                {
                    Console.WriteLine(queue);
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
