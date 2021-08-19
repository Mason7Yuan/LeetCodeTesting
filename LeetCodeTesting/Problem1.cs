using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem1
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> twoSum = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                try
                {
                    twoSum.Add(nums[i], i);
                }
                catch
                {
                    return new int[] { twoSum[nums[i]], i };
                }

            }

            for (var j = 0; j < nums.Length; j++)
            {
                int anotherValue = target - nums[j];

                if (twoSum.ContainsKey(anotherValue) && twoSum[anotherValue] != j)
                {
                    return new int[] { j, twoSum[anotherValue] };
                }
            }

            return new int[] { };
        }
    }
}
