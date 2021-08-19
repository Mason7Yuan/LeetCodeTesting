using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem1688
    {
        public static int NumberOfMatches(int n)
        {
            //int totalMatch = 0;

            //while (n != 1)
            //{
            //    if (n % 2 == 1)
            //    {
            //        totalMatch += (n - 1) / 2;
            //        n = (n - 1) / 2 + 1;
            //    }
            //    else
            //    {
            //        totalMatch += n / 2;
            //        n = n / 2;
            //    }
            //}

            //return totalMatch;

            return n - 1;
        }
    }
}
