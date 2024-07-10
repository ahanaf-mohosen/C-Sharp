using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*What is LinkList? 
              We didn’t discuss about it in our sessions.  
              You have to self-learn ( https://dotnetcademy.net/Learn/2047/Pages/25 )
            */

            /*Task:  
              Take user input (12 Month names) and keep in LinkList and print the data using foreach loop. 
              Then remove the last 6 items of the LinkList. 
              Then print again.
            */



            try
            {
                Console.WriteLine("12 Month names:");
                LinkedList<string> Month = new LinkedList<string>();
                for (int i = 1; i <= 12; i++)
                {
                    Console.Write($"month - {i}: ");
                    string month = Console.ReadLine();
                    Month.AddLast(month);
                }
                foreach (var month in Month)
                {
                    Console.WriteLine(month);
                }
                Console.WriteLine();
                for (int i = 1; i <= 6; i++)
                {
                    Month.RemoveLast();
                }
                foreach (var month in Month)
                {
                    Console.WriteLine(month);
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
