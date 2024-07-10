using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Name
    {
        string firstName;
        string lastName;
        string middleName;

        public Name() : this("No firstName provide", "No lastName provide")
        {

        }
         
        public Name(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void fullName()
        {
            Console.WriteLine("Full name: {0}", this.firstName + " " + this.lastName);
        }
        ~Name()
        {
            //clean up code
        }
    }
}
