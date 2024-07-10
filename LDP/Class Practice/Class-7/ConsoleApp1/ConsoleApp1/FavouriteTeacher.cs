using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FavouriteTeacher
    {
        /*Create a class with the name of “FavouriteTeacher” 
              Where you have to keep few fields such as 
              1. TeacherName (String) 
              2. TeacherID (integer) 
              3. TeacherHeight (float) 
              4. TeacherFavouriteColor (string) 
              5. IsTeacherAnnoyed (boolean) 
              
              Keep few methods 
              1. PrintTeacherName() 
              2. PrintTeacherID() 
              3. PrintTeacherHeight() 
              4. Print TeacherFavouriteColor() 
              5. PrintIsTeacherAnnoyed() 
              Now initialize the “FavouriteTeacher” class from Main function and populate data.  
              Then call the functions to print data.
            */

        public string TeacherName { get; set; }
        public int TeacherID { get; set; }
        public float TeacherHeight { get; set; }
        public string TeacherFavouriteColor { get; set; }
        public bool IsTeacherAnnoyed { get; set; }

        public FavouriteTeacher() 
        { 

        }
    }
}
