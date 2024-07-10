using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace StudentResult1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Suppose you are a class teacher of section B. 5 students are there in section B. 
              5 students have taken 3 subjects such as SE111, SE221, SE323.

              Now, 
              Create a class with the name of Student and fields will be std_name, subject1 number, 
              subject2 number, subject3 number, comments. Provide the number of 3 subjects for each student. 
              And write a comment for each student about their result.

              Now create another class with the name of HeadSir. 
              HeadSir wants to see all student information List in his Class.
              Now print all the students names and comments.
            */

            Student student1 = new Student();
            student1.std_name = "Mugdho";
            student1.sub1_num = 78;
            student1.sub2_num = 83;
            student1.sub3_num = 79;
            student1.comments = "Good";
            Console.WriteLine();

            Student student2 = new Student();
            student2.std_name = "Ahanaf";
            student2.sub1_num = 92;
            student2.sub2_num = 83;
            student2.sub3_num = 81;
            student2.comments = "Nice";
            Console.WriteLine();

            Student student3 = new Student();
            student3.std_name = "Rima";
            student3.sub1_num = 83;
            student3.sub2_num = 89;
            student3.sub3_num = 87;
            student3.comments = "Good";
            Console.WriteLine();

            Student student4 = new Student();
            student4.std_name = "Samima";
            student4.sub1_num = 83;
            student4.sub2_num = 71;
            student4.sub3_num = 77;
            student4.comments = "Average";
            Console.WriteLine();

            Student student5 = new Student();
            student5.std_name = "Shibly";
            student5.sub1_num = 85;
            student5.sub2_num = 80;
            student5.sub3_num = 89;
            student5.comments = "Good";
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------");

            List<Student> studentInfo = new List<Student>();
            studentInfo.Add(student1);
            studentInfo.Add(student2);
            studentInfo.Add(student3);
            studentInfo.Add(student4);
            studentInfo.Add(student5);

            HeadSir headSir = new HeadSir();
            headSir.AllStudent(studentInfo);

            Console.ReadLine();
        }
    }
}
