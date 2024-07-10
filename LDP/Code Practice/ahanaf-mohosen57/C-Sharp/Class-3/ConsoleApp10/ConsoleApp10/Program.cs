using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to find the eligibility of admission for a professional course based on the following criteria:
              Marks in Maths >=65 
              Marks in Phy >=55 
              Marks in Chem>=50 
              Total in all three subject >=180 
              or 
              Total in Math and Subjects >=140
              
              Test Data : 
              Input the marks obtained in Physics :65
              Input the marks obtained in Chemistry :51 
              Input the marks obtained in Mathematics :72 
              Expected Output : The candidate is eligible for admission.
            */

            Console.WriteLine("\n### Eligibility of Admission (Math/Physics/Chemistry) ###\n");
            Console.Write("Input the marks obtained in Mathematics: ");
            double mathMarks = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the marks obtained in Physics: ");
            double phyMarks = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the marks obtained in Chemistry: ");
            double chemMarks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double totalMarks = mathMarks + phyMarks + chemMarks;

            if ((mathMarks >= 65) && (phyMarks >= 55) && (chemMarks >= 50) && ((totalMarks >= 180) || ((mathMarks + phyMarks) >= 140) || (mathMarks + chemMarks) >= 140))
            {
                Console.WriteLine("You are eligible for admission.");
            }
            else
            {
                Console.WriteLine("You are eligible for admission.");
            }
            Console.ReadLine();
        }
    }
}
