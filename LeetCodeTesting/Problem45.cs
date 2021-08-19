using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem45
    {
        public static int Jump(int[] nums)
        {
            if (nums.Length == 1)
                return 0;

            int checkPointEnd = nums[0];
            int checkPointStart = 0;
            int nextIndex = checkPointEnd;
            int output = 0;

            while (checkPointEnd < nums.Length - 1)
            {
                for (var i = checkPointStart; i <= checkPointEnd; i++)
                {
                    if (i + nums[i] > nextIndex + nums[nextIndex])
                    {
                        nextIndex = i;
                    }
                }

                checkPointStart = nextIndex;
                checkPointEnd = nextIndex + nums[nextIndex];
                output++;
            }

            output++;
            return output;
        }
    }
}
