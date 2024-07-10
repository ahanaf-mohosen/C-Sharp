using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gender gender = (Gender)Day.Saterday;
            Console.WriteLine(gender);
            Console.ReadLine();
        }

        #region enums
        public enum Gender 
        {
            Unknown,
            Male,
            Female
        }

        public enum Day
        {
            Saterday,
            sunday,
            Monday
        }
        #endregion
    }
}
