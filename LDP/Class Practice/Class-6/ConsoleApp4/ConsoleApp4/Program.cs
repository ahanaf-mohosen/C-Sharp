using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*What is Dictionary?*/

            /*Take user input (10 Fruits names) and keep in Dictionary and print the data using foreach loop. 
              Then remove the last 3 items of the Dictionary. Then print again.
            */



            try
            {
                Console.WriteLine("10 Fruits names: ");
                Dictionary<int, string> Fruit = new Dictionary<int, string>();
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("fruit - {0}: ", i);
                    string fruits = Console.ReadLine();
                    Fruit.Add(i, fruits);
                }
                Console.WriteLine("\nFruit List:");
                foreach (KeyValuePair<int, string> fruit in Fruit)
                {
                    Console.WriteLine(fruit.Key + ".\t" + fruit.Value);
                }
                
                Fruit.Remove(8);
                Fruit.Remove(9);
                Fruit.Remove(10);
                Console.WriteLine("\nFruit List After Removing Last 3 Items:");
                foreach (KeyValuePair<int, string> fruit in Fruit)
                {
                    Console.WriteLine(fruit.Key + ".\t" + fruit.Value);
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
