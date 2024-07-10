using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentResult
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


            Console.WriteLine("1. Student Details:");
            Student student1 = new Student();
            Console.Write("Name: ");
            student1.std_name = Console.ReadLine();
            Console.Write("SE-111 Number: ");
            student1.sub1_num = int.Parse(Console.ReadLine());
            Console.Write("SE-221 Number: ");
            student1.sub2_num = int.Parse(Console.ReadLine());
            Console.Write("SE-323 Number: ");
            student1.sub3_num = int.Parse(Console.ReadLine());
            Console.Write("Comments: ");
            student1.comments = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("2. Student Details:");
            Student student2 = new Student();
            Console.Write("Name: ");
            student2.std_name = Console.ReadLine();
            Console.Write("SE-111 Number: ");
            student2.sub1_num = int.Parse(Console.ReadLine());
            Console.Write("SE-221 Number: ");
            student2.sub2_num = int.Parse(Console.ReadLine());
            Console.Write("SE-323 Number: ");
            student2.sub3_num = int.Parse(Console.ReadLine());
            Console.Write("Comments: ");
            student2.comments = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("3. Student Details:");
            Student student3 = new Student();
            Console.Write("Name: ");
            student3.std_name = Console.ReadLine();
            Console.Write("SE-111 Number: ");
            student3.sub1_num = int.Parse(Console.ReadLine());
            Console.Write("SE-221 Number: ");
            student3.sub2_num = int.Parse(Console.ReadLine());
            Console.Write("SE-323 Number: ");
            student3.sub3_num = int.Parse(Console.ReadLine());
            Console.Write("Comments: ");
            student3.comments = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("4. Student Details:");
            Student student4 = new Student();
            Console.Write("Name: ");
            student4.std_name = Console.ReadLine();
            Console.Write("SE-111 Number: ");
            student4.sub1_num = int.Parse(Console.ReadLine());
            Console.Write("SE-221 Number: ");
            student4.sub2_num = int.Parse(Console.ReadLine());
            Console.Write("SE-323 Number: ");
            student4.sub3_num = int.Parse(Console.ReadLine());
            Console.Write("Comments: ");
            student4.comments = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("5. Student Details:");
            Student student5 = new Student();
            Console.Write("Name: ");
            student5.std_name = Console.ReadLine();
            Console.Write("SE-111 Number: ");
            student5.sub1_num = int.Parse(Console.ReadLine());
            Console.Write("SE-221 Number: ");
            student5.sub2_num = int.Parse(Console.ReadLine());
            Console.Write("SE-323 Number: ");
            student5.sub3_num = int.Parse(Console.ReadLine());
            Console.Write("Comments: ");
            student5.comments = Console.ReadLine();
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
