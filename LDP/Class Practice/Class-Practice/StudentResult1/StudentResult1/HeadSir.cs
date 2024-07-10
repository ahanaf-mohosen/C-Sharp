using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResult1
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
                Console.Write(student.std_name + ": ");
                Console.WriteLine(student.comments);
                Console.WriteLine();
            }
        }
    }
}
