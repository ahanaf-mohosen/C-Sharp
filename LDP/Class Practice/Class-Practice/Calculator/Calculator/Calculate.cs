using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculate
    {
        public Calculate()
        {

        }

        public void Sum(List<double> userInput)
        {
            double result = 0;
            foreach (var i in userInput)
            {
                result += i;
            }
            Console.WriteLine("The multiple numbers sum is: " + result);
        }

        public void Add(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine("The two numbers sum is: " + result);
        }

        public void Multiplication(List<double> userInput)
        {
            double total = 1;
            foreach (var i in userInput)
            {
                total *= i;
            }
            Console.WriteLine("The multiple numbers multiplication is: " + total);
        }

        public void Substraction(double num1, double num2)
        {
            double total = num1 - num2;
            Console.WriteLine("The two numbers substraction is: " + total);
        }

        public void Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Can not divide by zero.");
            }
            double total = num1/num2;
            Console.WriteLine("The two numbers division is: " + total);
        }
    }
}
