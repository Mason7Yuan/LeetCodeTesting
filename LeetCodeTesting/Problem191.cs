using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem191
    {
        public static int HammingWeight(uint n)
        {
            string binaryN = Convert.ToString(n, 2);
            int output = 0;

            for (int i = 0; i < binaryN.Length; i++)
            {
                if (binaryN[i] == '1')
                {
                    output += 1;
                }
            }

            return output;
        }
    }
}
