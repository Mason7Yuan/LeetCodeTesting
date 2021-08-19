using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem1528
    {
        public static string RestoreString(string s, int[] indices)
        {
            #region brutal force
            //char[] output = new char[s.Length];

            //for (int i = 0; i < s.Length; i++)
            //{
            //    output[indices[i]] = s[i];
            //}

            //return string.Join("", output);
            #endregion

            #region Hash map
            SortedDictionary<int, char> tempOutput = new SortedDictionary<int, char>();
            string output = "";

            for (int i = 0; i < s.Length; i++)
            {
                tempOutput.Add(indices[i], s[i]);
            }

            foreach (char str in tempOutput.Values)
            {
                output += str;
            }

            return output;
            #endregion
        }
    }
}
