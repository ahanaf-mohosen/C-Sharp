using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResult1
{
    public class Student
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

        public string std_name { get; set; }
        public int sub1_num { get; set; }
        public int sub2_num { get; set; }
        public int sub3_num { get; set; }
        public string comments { get; set; }

        public Student()
        {

        }
    }
}
