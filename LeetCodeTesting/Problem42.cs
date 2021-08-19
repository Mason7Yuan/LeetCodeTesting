using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem42
    {
        public static int Trap(int[] height)
        {
            if(height.Length < 3)
            {
                return 0;
            }

            return 1;
            //Dynamic programming method (DP method)
            //int volume = 0;
            //int[] left = new int[height.Length];
            //int[] right = new int[height.Length];

            //left[0] = height[0];
            //right[height.Length - 1] = height[height.Length - 1];

            //for(var i = 1; i < height.Length; i++)
            //{
            //    left[i] = Math.Max(left[i - 1], height[i]);
            //}

            //for(var j = height.Length -  2; j >= 0; j--)
            //{
            //    right[j] = Math.Max(right[j + 1], height[j]);
            //}

            //for (var k = 0; k < height.Length; k++)
            //{
            //    volume += Math.Min(left[k], right[k]) - height[k];
            //} 

            //return volume;

            //Two points method (TP method)

        }
    }
}
