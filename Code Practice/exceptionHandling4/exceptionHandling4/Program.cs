using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    int num1 = 5;
                    int num2 = 0;
                    int sum = num1 / num2;
                    Console.WriteLine(sum);
                }
                catch (Exception ex)
                {
                    throw new DivideByZeroException("First catch block", ex);
                    //Console.WriteLine("First catch block");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Second catch block" + e);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
