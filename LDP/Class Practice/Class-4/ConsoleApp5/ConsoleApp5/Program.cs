using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to display the cube of the number up to given an integer. 
              Test Data : 
              Input number of terms : 5  
              Expected Output :  
              Number is : 1 and cube of the 1 is :1  
              Number is : 2 and cube of the 2 is :8  
              Number is : 3 and cube of the 3 is :27  
              Number is : 4 and cube of the 4 is :64  
              Number is : 5 and cube of the 5 is :125 
            */

            Console.Write("Input numbers of terms: ");
            int term = int.Parse(Console.ReadLine());
            for(int i = 1; i <= term; i++)
            {
                Console.WriteLine($"Number is: {i} and cube of the {i} is: {Math.Pow(i,3)}");
            }
            Console.ReadLine();
        }
    }
}
