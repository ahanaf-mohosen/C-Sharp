using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to accept a grade and declare the equivalent description :  
              
              Grade 	Description
              E 	    Excellent
              V 	    Very Good
              G 	    Good
              A 	    Average
              F 	    Fail


              Test Data : 
              Input the grade :a 
              Expected Output : 
              You have chosen : Average 
            */

            Console.WriteLine("\n### Accept a grade and declare the equivalent description ###\n");
            Console.Write("Input the grade: ");
            char gradeInput = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            char grade = char.ToLower(gradeInput);
            string description = "";

            if (grade == 'e')
            {
                description = "Excellent";
            }
            else if (grade == 'v')
            {
                description = "Very Good";
            }
            else if (grade == 'g')
            {
                description = "Good";
            }
            else if (grade == 'a')
            {
                description = "Average";
            }
            else if (grade == 'f')
            {
                description = "Fail";
            }
            else
            {
                description = "Invalid grade";
            }
            Console.WriteLine($"You have chosen: {description}");
            Console.ReadLine();
        }
    }
}
