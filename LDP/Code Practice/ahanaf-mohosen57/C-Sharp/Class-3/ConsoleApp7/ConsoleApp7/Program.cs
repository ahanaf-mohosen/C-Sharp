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
            /*Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height. 
              Test Data : 135 
              Expected Output : The person is Dwarf.
            */

            Console.WriteLine("\n### Check Your Height Categorize ###\n");
            Console.Write("Enter your height (cm): ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if(height > 182)
            {
                Console.WriteLine("Your height is very tall.");
            }
            else if(height >= 174 && height <= 182)
            {
                Console.WriteLine("Your height is tall.");
            }
            else if (height >= 167 && height <= 173)
            {
                Console.WriteLine("Your height is rather tall.");
            }
            else if (height >= 160 && height <= 166)
            {
                Console.WriteLine("Your height is medium.");
            }
            else if( height >= 155 && height <= 159)
            {
                Console.WriteLine("Your height is rather short.");
            }
            else if(height >= 145 && height <= 154)
            {
                Console.WriteLine("Your height is short.");
            }
            else if(height < 145 )
            {
                Console.WriteLine("Your height is very short.");
            }
            Console.ReadLine();
        }
    }
}
