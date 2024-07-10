using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Palindrome_Number
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            int temp = x;
            int reverse = 0;
            while (temp > 0) 
            {
                int digit = temp % 10;
                reverse = reverse * 10 + digit;
                temp = temp / 10;
            }
            if(reverse == x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
