using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to read temperature in centigrade and display a suitable message according to temperature state below : 
              Temp < 0 then Freezing weather 
              Temp 0-10 then Very Cold weather 
              Temp 10-20 then Cold weather 
              Temp 20-30 then Normal in Temp 
              Temp 30-40 then Its Hot 
              Temp >=40 then Its Very Hot 
              Test Data : 42 
              Expected Output : Its very hot. 
            */

            Console.WriteLine("\n### suitable message according to temperature ###\n");
            Console.Write("Input the wather temperature (Centigrade): ");
            int temperature = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            if (temperature < 0)
            {
                Console.WriteLine("Freezing weather.");
            }
            else if (temperature >= 0 && temperature <= 10)
            {
                Console.WriteLine("Very Cold weather.");
            }
            else if (temperature > 10 && temperature <= 20)
            {
                Console.WriteLine("Cold weather.");
            }
            else if (temperature > 20 && temperature <= 30)
            {
                Console.WriteLine("Normal in Temp.");
            }
            else if (temperature > 30 && temperature <= 40)
            {
                Console.WriteLine("Its Hot.");
            }
            else if (temperature > 40)
            {
                Console.WriteLine("Its Very Hot.");
            }
            Console.ReadKey();
        }
    }
}
