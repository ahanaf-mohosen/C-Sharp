using StudentResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResult
{
    public class HeadSir
    {
        public HeadSir()
        {

        }
        public void AllStudent(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.std_name +": "+ student.comments);
                //Console.WriteLine(student.comments);
            }
        }
    }
}
