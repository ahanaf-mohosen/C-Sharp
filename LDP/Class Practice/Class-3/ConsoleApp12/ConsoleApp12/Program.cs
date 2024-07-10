using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to read roll no, name and marks of three subjects and  calculate the total, percentage and division. 
              Test Data : 
              Input the Roll Number of the student :784 
              Input the Name of the Student :James 
              Input the marks of Physics, Chemistry and Computer Application : 70 80 90 
              
              Expected Output : 
              Roll No : 784 
              Name of Student : James 
              Marks in Physics : 70 
              Marks in Chemistry : 80 
              Marks in Computer Application : 90 
              Total Marks = 240 
              Percentage = 80.00 
              Division = First 
            */

            Console.WriteLine("\n### Mark sheet ###\n");
            Console.Write("Roll No: ");
            int roll = Convert.ToInt16(Console.ReadLine());
            Console.Write("Name of Student: ");
            string name = Console.ReadLine();
            Console.Write("Marks in Physics: ");
            int physicsMarks = Convert.ToInt16(Console.ReadLine());
            Console.Write("Marks in Chemistry: ");
            int chemistryMarks = Convert.ToInt16(Console.ReadLine());
            Console.Write("Marks in Computer Application: ");
            int computerAppMarks = Convert.ToInt16(Console.ReadLine());

            int totalMarks = physicsMarks + chemistryMarks + computerAppMarks;
            double percentage = ((double)totalMarks / 3);
            string division = "";

            if (percentage >= 60)
            {
                division = "First";
            }
            else if (percentage >= 48)
            {
                division = "Second";
            }
            else if (percentage >= 36)
            {
                division = "Third";
            }
            else
            {
                division = "Fail";
            }
            Console.WriteLine($"\nRoll No: {roll}");
            Console.WriteLine($"Name of Student: {name}");
            Console.WriteLine($"Marks in Physics: {physicsMarks}");
            Console.WriteLine($"Marks in Chemistry: {chemistryMarks}");
            Console.WriteLine($"Marks in Computer Application: {computerAppMarks}");
            Console.WriteLine($"Total Marks = {totalMarks}");
            Console.WriteLine($"Percentage = {percentage}");
            Console.WriteLine($"Division = {division}");
            Console.ReadLine();
        }
    }
}



