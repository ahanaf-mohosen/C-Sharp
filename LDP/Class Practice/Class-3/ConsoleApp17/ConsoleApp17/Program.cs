using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to calculate profit and loss on a transaction. 
              Test Data: 
              500 700 
              Expected Output : 
              You can book your profit amount : 200 
            */

            Console.WriteLine("\n### Calculate profit and loss on a transaction ###\n");
            Console.Write("Enter the cost price: ");
            int costPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the selling price: ");
            int sellingPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int profit = sellingPrice - costPrice;

            if (profit > 0)
            {
                Console.WriteLine($"You can book your profit amount: {profit}");
            }
            else
            {
                Console.WriteLine($"You are incurring a loss of: {-profit}");
            }
            Console.ReadLine();
        }
    }
}
