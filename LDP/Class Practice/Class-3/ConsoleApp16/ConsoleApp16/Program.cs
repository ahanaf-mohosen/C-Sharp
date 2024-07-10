using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to check whether an alphabet is a vowel or consonant. 
              Test Data : k 
              Expected Output : 
              The alphabet is a consonant.
            */

            Console.WriteLine("\n### Check whether an alphabet is a vowel or consonant ###\n");
            Console.Write("Enter an alphabet: ");
            char alphabet = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            char lowerCase = Char.ToLower(alphabet);

            if (lowerCase == 'a' || lowerCase == 'e' || lowerCase == 'i' || lowerCase == 'o' || lowerCase == 'u')
            {
                Console.WriteLine("The alphabet is a vowel");
            }
            else
            {
                Console.WriteLine("The alphabet is a consonant");
            }
            Console.ReadKey();
        }
    }
}
