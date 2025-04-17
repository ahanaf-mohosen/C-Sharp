using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //int[] index = new int[2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        //index[0] = i;
                        //index[1] = j;
                        //return index;
                        return new int[] { i, j };
                    }
                }
            }
            //return null;
            //return new int[0]; 
            return new int[] { };
        }
    }
}
