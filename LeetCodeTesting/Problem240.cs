using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem240
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            // Tine limit exceeded.
            //int[] mergeMatrix = new int[] { };

            //for (var i = 0; i < matrix.Length; i++)
            //{
            //    mergeMatrix = mergeMatrix.Concat(matrix[i]).ToArray();
            //}
            //Array.Sort(mergeMatrix);

            //int left = 0;
            //int right = mergeMatrix.Length - 1;
            //int mid = (left + right) / 2;

            //if (mergeMatrix[left] > target || mergeMatrix[right] < target)
            //    return false;

            //while (left < right)
            //{
            //    mid = (left + right) / 2;

            //    if (mergeMatrix[mid] == target)
            //    {
            //        return true;
            //    }
            //    else if (mergeMatrix[mid] < target)
            //    {
            //        left = mid + 1;

            //        if (mergeMatrix[left] > target)
            //            return false;
            //    }
            //    else if (mergeMatrix[mid] > target)
            //    {
            //        right = mid - 1;

            //        if (mergeMatrix[right] < target)
            //            return false;
            //    }
            //}
            //// left = right.
            //if (mergeMatrix[left] == target)
            //    return true;
            //else
            //    return false;

            // Divide by conquer.
            int m = matrix.Length, n = matrix[0].Length;
            int posRow = 0, posCol = n - 1;

            while (posRow < m && posCol >= 0)
            {
                if (matrix[posRow][posCol] == target)
                    return true;
                else if (matrix[posRow][posCol] > target)
                    posCol--;
                else
                    posRow++;
            }

            return false;
        }
    }
}
