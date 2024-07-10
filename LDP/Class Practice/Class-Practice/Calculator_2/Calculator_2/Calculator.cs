using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
{
    public class Calculator
    {
        public Calculator()
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


        public void Multiplication(List<double> userInput)
        {
            double total = 1;
            foreach (var i in userInput)
            {
                total *= i;
            }
            Console.WriteLine("The multiple numbers multiplication is: " + total);
        }

        public void Substraction(List<double> userInput)
        {

            double total = userInput[0];
            for (int i = 1; i < userInput.Count; i++)
            {
                total -= userInput[i];
            }
            Console.WriteLine("The two numbers substraction is: " + total);
        }

        public void Division(List<double> userInput)
        {
            double total = userInput[0];
            for (int i = 1; i < userInput.Count; i++)
            {
                if (userInput[i] == 0)
            {
                throw new DivideByZeroException("Can not divide by zero.");
            }
            
                total /= userInput[i];
            }
            Console.WriteLine("The two numbers division is: " + total);
        }
    }
}
