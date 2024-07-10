using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Palindrome_Number
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = -121;

            Solution solution = new Solution();
            bool checkPalindrome = solution.IsPalindrome(num);
            Console.WriteLine(checkPalindrome);
            Console.ReadLine();
        }
    }
}
