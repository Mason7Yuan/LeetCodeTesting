using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem16
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            int defualtOutput = nums[0] + nums[1] + nums[2];
            int ans, ans1, output = 0;

            if (nums.Length == 3 || defualtOutput == target) 
            {
                return defualtOutput;
            }

            bool start = false;
            int outputDis1 = Math.Abs(defualtOutput - target);


            for (var i = 0; i < nums.Length - 2; i++)
            {
                for(var j = i + 1; j < nums.Length - 1; j++)
                {
                    for (var k = j + 1; k < nums.Length; k++)
                    {
                        ans = nums[i] + nums[j] + nums[k] - target;

                        if (ans < 0)
                        {
                            ans1 = -ans;
                        }
                        else if (ans == 0)
                        {
                            return target;
                        }
                        else
                        {
                            ans1 = ans;
                        }

                        if (ans1 - outputDis1 < 0)
                        {
                            outputDis1 = ans1;
                            output = ans + target;
                            start = true;
                        }
                    }
                }
            }

            if (start)
            {
                return output;
            }
            else
            {
                return defualtOutput;
            }
        }
    }
}
