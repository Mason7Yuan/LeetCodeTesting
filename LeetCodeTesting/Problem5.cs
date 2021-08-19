using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem5
    {
        //Dynamic programming, using array to remember the element. And in the process,
        //if u need to use them, just take it and use it. No need to do the calculation again and again.
        public static string LongestPalindrome(string s)
        {
            //Poor method, runtime too long
            //if(s.Length == 1)
            //{
            //    return s;
            //}

            //var numStrArr = new int[] { };
            //var positions = new int[] { };
            //int maxLengthOfPalindromic = 0;

            //var output = new StringBuilder();

            //for (var i = 0; i < s.Length; i++)
            //{
            //    if (!numStrArr.Contains(i))
            //    {
            //        //var elePositions = new Problem5();
            //        positions = Problem5.StrElementPosition(s, s[i]);
            //        numStrArr = numStrArr.Concat(positions).ToArray();
            //    }
            //    else { continue; }

            //    if(positions.Length == 1)
            //    {
            //        Array.Resize(ref positions, 0);
            //        continue;
            //    }

            //    //Left part
            //    for (var j = 0; j < positions.Length - 1; j++)
            //    {
            //        //Right part
            //        for(var k = j+1; k < positions.Length; k++)
            //        {
            //            var a = positions[j];
            //            var b = positions[k];

            //            if(b == a + 1)
            //            {
            //                if(maxLengthOfPalindromic < 2)
            //                {
            //                    output.Clear();

            //                    while (a <= b)
            //                    {
            //                        output.Append(s[a]);
            //                        a++;
            //                    }

            //                    maxLengthOfPalindromic = 2;
            //                }
            //            }
            //            else
            //            {
            //                var z = 1;

            //                while(a + z <= b - z)
            //                {
            //                    if(s[a + z] == s[b - z]) { z++; }
            //                    else { break; }
            //                }

            //                if (a + z >= b - z && maxLengthOfPalindromic < b - a + 1)
            //                {
            //                    output.Clear();

            //                    while (a <= b)
            //                    {
            //                        output.Append(s[a]);
            //                        a++;
            //                    }

            //                    maxLengthOfPalindromic = b - positions[j] + 1;
            //                }
            //                else {  }

            //            }

            //        }
            //    }
            //}
            //if (maxLengthOfPalindromic < 2)
            //{
            //    return s[0].ToString();
            //}

            //return output.ToString();

            int start = 0, end = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int len1 = expandAroundCenter(s, i, i);
                int len2 = expandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start + 1)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }

            return s.Substring(start, end - start + 1);
        }

        private static int expandAroundCenter(String s, int left, int right)
        {
            int L = left, R = right;
            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }
            return R - L - 1;
        }

        //public static int[] StrElementPosition(string s, char ele)
        //{
        //    var position = new int[] { };
        //    var startFindPosition = 0;

        //    while (startFindPosition < s.Length)
        //    {
        //        startFindPosition = s.IndexOf(ele, startFindPosition);

        //        if(startFindPosition != -1)
        //        {
        //            position = position.Concat(new int[] { s.IndexOf(ele, startFindPosition) }).ToArray();
        //            startFindPosition += 1;
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }

        //    return position;
        //}
    }
}
