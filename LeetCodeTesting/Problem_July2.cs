using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem_July2
    {
        public static IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            int[] minusResults = new int[arr.Length];
            List<int> output = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                minusResults[i] = Math.Abs(arr[i] - x);
            }

            for (int i = 0, head = 0; i < arr.Length; i++)
            {
                output.Add(arr[i]);

                if (output.Count > k)
                {
                    if (minusResults[i] < minusResults[head])
                    {
                        head++;
                        output.RemoveAt(0);
                    }
                    else
                        output.RemoveAt(k);
                }
            }

            return output;
        }
    }
}
