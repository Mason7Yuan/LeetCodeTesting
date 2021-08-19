using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem70
    {
        public int ClimbStairs(int n)
        {
            int firstStep = 1;
            int secondStep = 2;
            int output = 2;

            if (n == 1)
            {
                return 1;
            }
            else
            {
                for (int i = 3; i <= n; i++)
                {
                    output = firstStep + secondStep;
                    firstStep = secondStep;
                    secondStep = output;
                }
            }

            return output;
        }
    }
}
