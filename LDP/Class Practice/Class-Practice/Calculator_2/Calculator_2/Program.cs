using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\n### CALCULATOR ###\n");
                Console.WriteLine("Select your option - ");
                Console.WriteLine("1. Sum of multiple numbers.");
                Console.WriteLine("2. Multiplication of several numbers.");
                Console.WriteLine("3. Substraction of Multiple numbers.");
                Console.WriteLine("4. Division of Multiple numbers.");

                Console.Write("Option - ");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Calculator calculate = new Calculator();

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
                            calculate.Sum(userInput);
                            break;
                        }
                    case 2:
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
                            calculate.Multiplication(userInput);
                            break;
                        }
                    case 3:
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
                            calculate.Substraction(userInput);
                            break;
                        }
                    case 4:
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
                            calculate.Division(userInput);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter right option.");
                            break;
                        }
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            Console.ReadLine();
        }
    }
}
