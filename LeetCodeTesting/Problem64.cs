using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem64
    {
        public static int MinPathSum(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int[,] output = new int[m, n];

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        output[i, j] = grid[i][j];
                    }
                    else if (i == 0)
                    {
                        output[i, j] = output[i, j - 1] + grid[i][j];
                    }
                    else if (j == 0)
                    {
                        output[i, j] = output[i - 1, j] + grid[i][j];
                    }
                    else
                    {
                        output[i, j] = Math.Min(output[i - 1, j], output[i, j - 1]) + grid[i][j];
                    }
                }
            }

            return output[m - 1, n - 1];
        }
    }
}
