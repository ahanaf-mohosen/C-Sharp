using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] arr1 = nums;
            int[] arr2 = nums;
            for (int i = 0, j = nums.Length - 1; i < arr1.Length / 2; i++, j--)
            {
                if (arr1[i] + arr2[j] == target)
                {
                    return new int[] { i, j };
                }
            }
            return null;
        }
    }

}
