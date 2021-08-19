using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem167
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (true)
            {
                if (numbers[left] + numbers[right] > target)
                {
                    right--;
                }
                else if (numbers[left] + numbers[right] < target)
                {
                    left++;
                }
                else
                {
                    break;
                }
            }

            return new int[2] { left + 1, right + 1 };
        }
    }
}
