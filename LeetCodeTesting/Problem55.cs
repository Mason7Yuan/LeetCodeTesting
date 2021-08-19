using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem55
    {
        public static bool CanJump(int[] nums)
        {
            int indexCheck = nums.Length - 1;

            for (var i = nums.Length - 2; i >=0; i--)
            {
                if (i + nums[i] >= indexCheck)
                {
                    indexCheck = i;
                }
            }

            if (indexCheck == 0)
                return true;

            return false;
        }
    }
}