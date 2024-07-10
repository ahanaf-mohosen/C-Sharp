using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to read any day number in integer and display day  name in the word. 
              Test Data : 4 
              Expected Output : Thursday 
            */

            Console.WriteLine("\n### Read any day number in integer and display day name in the word ###\n");
            Console.Write("Input a day number: ");
            int dayNumber = Convert.ToInt16(Console.ReadLine());
            string dayName;

            switch (dayNumber)
            {
                case 1:
                    dayName = "Sunday";
                    break;
                case 2:
                    dayName = "Monday";
                    break;
                case 3:
                    dayName = "Tuesday";
                    break;
                case 4:
                    dayName = "Wednesday";
                    break;
                case 5:
                    dayName = "Thursday";
                    break;
                case 6:
                    dayName = "Friday";
                    break;
                case 7:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }
            Console.WriteLine(dayName);
            Console.ReadLine();
        }
    }
}
