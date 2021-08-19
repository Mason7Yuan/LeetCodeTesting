using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem74
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int[] mergeMatrix = new int[] { };

            for (var i = 0; i < matrix.Length; i++)
            {
                mergeMatrix = mergeMatrix.Concat(matrix[i]).ToArray();
            }

            // Brutal Method
            //int output = Array.IndexOf(mergeMatrix, target);

            //if (output != -1)
            //    return true;
            //else
            //    return false;

            // Binary Search
            int left = 0;
            int right = mergeMatrix.Length - 1;
            int mid;

            if (mergeMatrix[left] > target || mergeMatrix[right] < target)
                return false;

            while (left < right)
            {
                mid = (left + right) / 2;

                if (mergeMatrix[mid] == target)
                {
                    return true;
                }
                else if (mergeMatrix[mid] < target)
                {
                    left = mid + 1;

                    if (mergeMatrix[left] > target)
                        return false;
                }
                else if (mergeMatrix[mid] > target)
                {
                    right = mid - 1;

                    if (mergeMatrix[right] < target)
                        return false;
                }
            }
            // left = right.
            if (mergeMatrix[left] == target)
                return true;
            else
                return false;
        }
    }
}
