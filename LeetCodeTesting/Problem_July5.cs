using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem_July5
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int MAX_LENGTH = r * c;
            int origRowLength = mat.Length, origColnLength = mat[0].Length;

            if (mat.Length * mat[0].Length != MAX_LENGTH)
                return mat;

            int[][] output = new int[r][];
            for (int i = 0; i < r; i++)
                output[i] = new int[c];

            int[] temp = new int[MAX_LENGTH];

            // All elements transport to 1-d matrix and then transport 1-d matrix's elements to new 2-d matrix.
            for (int i = 0; i < MAX_LENGTH; i++)
            {
                temp[i] = mat[i / origColnLength][i % origColnLength];
                output[i / c][i % c] = temp[i];
            }

            return output;
        }
    }
}
