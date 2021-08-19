using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem268
    {
        public static int MissingNumber(int[] nums)
        {
            int numSum = nums.Sum();
            int sumTheroretical = (nums.Length * (nums.Length + 1)) / 2;

            return sumTheroretical - numSum;
        }
    }
}
