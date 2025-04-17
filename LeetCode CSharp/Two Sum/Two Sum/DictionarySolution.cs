using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    public class DictionarySolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int value = target - nums[i];
                if (result.ContainsKey(value))
                {
                    return new int[] { result[value], i };
                }
                result[nums[i]] = i;
            }
            return new int[0];
        }
    }
}
