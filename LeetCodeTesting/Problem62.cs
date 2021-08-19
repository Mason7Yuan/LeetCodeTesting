using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem62
    {
        public static int UniquePaths(int m, int n)
        {
            int[,] output = new int[m, n];

            for (var i = 0; i < output.GetLength(0); i++)        // output.GetLength(0) = m
            {
                for (var j = 0; j < output.GetLength(1); j++)
                {
                    if(i == 0 && j == 0)
                    {
                        output[i, j] = 1;
                    }
                    else if (i == 0)
                    {
                        output[i, j] = 1;
                    }
                    else if (j == 0)
                    {
                        output[i, j] = 1;
                    }
                    else 
                    {
                        output[i, j] = output[i - 1, j] + output[i, j - 1];
                    }
                }
            }

            return output[m - 1, n - 1];
        }

    }
}
