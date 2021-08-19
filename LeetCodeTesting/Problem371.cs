using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem371
    {
        public int GetSum(int a, int b)
        {
            string aStr = Convert.ToString(a, 2);
            string bStr = Convert.ToString(b, 2);

            Problem67 p67 = new Problem67();

            string output = p67.AddBinary(aStr, bStr);

            Console.WriteLine(output);

            return 0;
        }
    }
}
