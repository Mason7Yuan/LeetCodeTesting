using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem53
    {
        public static int  MaxSubArray(int[] nums)
        {
            int output = nums[0];
            int currentMax = nums[0];

            for(var i = 1; i < nums.Length; i++)
            {
                if(currentMax > 0)
                {
                    currentMax += nums[i];
                }
                else
                {
                    currentMax = nums[i];
                }

                output = Math.Max(output, currentMax);
            }

            return output;
        }
    }
}
