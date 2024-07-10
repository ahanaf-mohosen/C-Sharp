using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int product = 1;
            int num1 = 5;
            int num2 = 10;
            Program.calculate(num1, num2, out sum, out product);
            Console.WriteLine($"sum = {sum} && product = {product}");
            Console.ReadLine();
        }

        public static void calculate(int FN, int SN, out int sum, out int product)
        {
            sum = FN + SN;
            product = FN * SN;
        }
    }
}
