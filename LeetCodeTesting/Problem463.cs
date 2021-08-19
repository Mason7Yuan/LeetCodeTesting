using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem463
    {
        public static int IslandPerimeter(int[][] grid)
        {
            int output = 0;

            for (int i = 0; i < grid.Length; i++) 
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        output += 4;

                        if (i == 0 && j == 0)
                        {
                            continue;
                        }
                        else if (i == 0)
                        {
                            if (grid[i][j - 1] == 1)
                                output -= 2;
                        }
                        else if (j == 0)
                        {
                            if (grid[i - 1][j] == 1)
                                output -= 2;
                        }
                        else
                        {
                            if (grid[i - 1][j] == 1)
                                output -= 2;

                            if (grid[i][j - 1] == 1)
                                output -= 2;
                        }
                    }
                }
            }

            return output;
        }
    }
}
