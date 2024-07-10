using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace customException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadeyLoggedInException("User is logged in - no deuplicate session allowed");
            }
            catch(UserAlreadeyLoggedInException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }

    [Serializable]
    public class UserAlreadeyLoggedInException : Exception
    {
        public UserAlreadeyLoggedInException() : base()
        {

        }
        public UserAlreadeyLoggedInException(string message) : base(message)
        {

        }
        public UserAlreadeyLoggedInException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public UserAlreadeyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
