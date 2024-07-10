using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Suppose,
              You are a software engineer, you have a task to create a calculator 
              which has the ability to do Sum of multiple numbers, sum of 2 numbers, 
              Multiplication of several numbers, Substraction of 2 numbers, Division of 2 numbers.
              Now create a class for this calculator. 
              You have to push the value for calculation from the main class.
            */

            try
            {
                Console.WriteLine("\n### CALCULATOR ###\n");
                Console.WriteLine("Select your option - ");
                Console.WriteLine("1. Sum of multiple numbers.");
                Console.WriteLine("2. Sum of 2 numbers.");
                Console.WriteLine("3. Multiplication of several numbers.");
                Console.WriteLine("4. Substraction of 2 numbers.");
                Console.WriteLine("5. Division of 2 numbers.");

                Console.Write("Option - ");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Calculate Calculate = new Calculate();
                switch (option)
                {
                    case 1:
                        {
                            Console.Write("Number needs: ");
                            int number = int.Parse(Console.ReadLine());

                            List<double> userInput = new List<double>();
                            for (int i = 0; i < number; i++)
                            {
                                Console.Write("Number - {0}: ", i + 1);
                                double input = double.Parse(Console.ReadLine());
                                userInput.Add(input);
                            }
                            Calculate.Sum(userInput);
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Number - 1: ");
                            double num1 = double.Parse(Console.ReadLine());
                            Console.Write("Number - 2: ");
                            double num2 = double.Parse(Console.ReadLine());
                            Calculate.Add(num1, num2);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Number needs: ");
                            int number = int.Parse(Console.ReadLine());

                            List<double> userInput = new List<double>();
                            for (int i = 0; i < number; i++)
                            {
                                Console.Write("number - {0}: ", i + 1);
                                double input = double.Parse(Console.ReadLine());
                                userInput.Add(input);
                            }
                            Calculate.Multiplication(userInput);
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Number - 1: ");
                            double num1 = double.Parse(Console.ReadLine());
                            Console.Write("Number - 2: ");
                            double num2 = double.Parse(Console.ReadLine());
                            Calculate.Substraction(num1, num2);
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Number - 1: ");
                            double num1 = double.Parse(Console.ReadLine());
                            Console.Write("Number - 2: ");
                            double num2 = double.Parse(Console.ReadLine());
                            Calculate.Division(num1, num2);
                            break;
                        }
                        default:
                        {
                            Console.WriteLine("Enter right option.");
                            break;
                        }
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
