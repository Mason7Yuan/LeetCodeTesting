using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem3
    {
        public static int LengthOfLongestSubstring(string s)
        {
            //Exceed time limit!
            //if (s.Length == 0)
            //{
            //    return 0;
            //}

            //int head = 0, body;
            //var outputStr = new StringBuilder();
            //var outputStrArr = new string[] { };
            //var outputIntArr = new int[] { };

            //while (head < s.Length)
            //{
            //    body = head + 1;
            //    outputStr.Append(s[head]);

            //    while (body < s.Length && !outputStr.ToString().Contains(s[body]))
            //    {
            //        outputStr.Append(s[body]);
            //        body += 1;
            //    }

            //    if (body <= s.Length - 1)
            //    {
            //        head = outputStr.ToString().IndexOf(s[body], head) + 1;
            //        outputStrArr = outputStrArr.Concat(new string[] { outputStr.ToString() }).ToArray();
            //        outputStr.Clear();
            //    }
            //    else
            //    {
            //        outputStrArr = outputStrArr.Concat(new string[] { outputStr.ToString() }).ToArray();
            //        break;
            //    }
            //}

            //foreach (var str in outputStrArr)
            //{
            //    outputIntArr = outputIntArr.Concat(new int[] { str.Length }).ToArray();
            //}

            //return outputIntArr.Max();

            var body = 0;
            var maxSubStringLength = 0;
            var outputStr = new StringBuilder();

            while(body < s.Length)
            {
                if (!outputStr.ToString().Contains(s[body]))
                {
                    outputStr.Append(s[body]);
                    maxSubStringLength = Math.Max(maxSubStringLength, outputStr.Length);
                    body++;
                }
                else
                {
                    int deleteNum = outputStr.ToString().IndexOf(s[body]) + 1;
                    outputStr.Remove(0, deleteNum);
                }
            }

            return maxSubStringLength;
        }
    }
}
