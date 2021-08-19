using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem63
    {
        public static int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;
            int[,] output = new int[m,n];

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        output[i, j] = 1;

                        if (obstacleGrid[i][j] == 1)
                        {
                            return 0;
                        }
                    }
                    else if (i == 0)
                    {
                        output[i, j] = output[i, j - 1];
                        
                        if (obstacleGrid[i][j] == 1)
                        {
                            output[i, j] = 0;
                        }
                    }
                    else if (j == 0)
                    {
                        output[i, j] = output[i - 1, j];

                        if (obstacleGrid[i][j] == 1)
                        {
                            output[i, j] = 0;
                        }
                    }
                    else 
                    {
                        output[i, j] = output[i - 1, j] + output[i, j - 1];

                        if (obstacleGrid[i][j] == 1)
                        {
                            output[i, j] = 0;
                        }
                    }
                }
            }

            return output[m - 1, n - 1];
        }
    }
}
