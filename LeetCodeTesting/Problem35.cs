using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem35
    {
        public static int SearchInsert(int[] nums, int target)
        {
            // RunTime: 7.64% Memory: 52.08% (Brutal Method)
            //int output = nums.ToList().FindIndex(x => x == target); // or use IndexOf

            //if (output != -1)
            //{
            //    return output;
            //}
            //else
            //{

            //    nums = nums.Concat(new int[] { target }).ToArray();
            //    Array.Sort(nums);

            //    output = nums.ToList().FindIndex(x => x == target);

            //    return output;
            //}

            // Binary Search, Time Complexity: O(log(nmus.Length));
            int left = 0;
            int right = nums.Length - 1;
            int mid = (left + right) / 2;

            if (nums[left] > target)
            {
                return 0;
            }
            else if (nums[right] < target)
            {
                return nums.Length;
            }

            while (left < right)
            {
                mid = (left + right) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;

                    if (nums[left] > target)
                    {
                        return mid + 1;
                    }
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;

                    if (nums[right] < target)
                    {
                        return mid;
                    }
                }
            }
            // left = right.
            if (nums[left] > target)
            {
                return left;
            }
            else if (nums[left] < target)
            {
                return left + 1;
            }

            return left;
        }
    }
}
