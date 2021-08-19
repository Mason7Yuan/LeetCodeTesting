using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem174
    {
        public static int CalculateMinimumHP(int[][] dungeon)
        {
            int m = dungeon.Length;
            int n = dungeon[0].Length;

            int[] output = Enumerable.Repeat(int.MaxValue, n + 1).ToArray();
            output[n - 1] = 1;

            for (var i = m - 1; i >= 0; i--)
            {
                for (var j = n - 1; j >= 0; j--)
                {
                    output[j] = Math.Max(1, Math.Min(output[j], output[j + 1]) - dungeon[i][j]);
                }
            }

            return output[0];
        }
    }
}
