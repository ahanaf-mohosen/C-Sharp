using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalCoffeeCost = 0;
            Start:
            Console.WriteLine("Please select your coffee:\n 1 - Small\n 2 - Medium\n 3 - Large");
            int userChoice = int.Parse(Console.ReadLine());


            switch (userChoice)
            {
                case 1:
                    {
                        totalCoffeeCost += 1;
                        break;
                    }
                case 2:
                    {
                        totalCoffeeCost += 2;
                        break;
                    }
                case 3:
                    {
                        totalCoffeeCost += 3;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Your choice {0} is invalid", userChoice);
                        goto Start;
                    }
            }
            Decide:
            Console.WriteLine("Do you want to buy another coffee - Yes or No?");
            string userDecision = Console.ReadLine();

            switch(userDecision.ToLower())
            {
                case "yes":
                    {
                        goto Start;
                    }
                    case "no": 
                    {
                        break;
                    }
                    default :
                    {
                        Console.WriteLine("Your choice is invalid. Please try again...");
                        goto Decide;
                    }
            }

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill Amount = {0}", totalCoffeeCost);
            Console.ReadLine();
        }
    }
}
