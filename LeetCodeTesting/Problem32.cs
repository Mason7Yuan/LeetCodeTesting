using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem32
    {
        // Dont really know how to construct a well-formed parenthness.

        //public static int LongestValidParentheses(string s)
        //{
        //    int output = 0;
        //    int outputCompare = 0;
        //    int expandStart = 0;
        //    int expandEnd = 1;
        //    int lastEnd = 0;
        //    int i = 0;
        //    bool haveExpand;
        //    bool keep;

        //    while(i < s.Length - 1)
        //    {
        //        haveExpand = false;
        //        keep = true;

        //        if (s[i] == '(' && s[i + 1] == ')')
        //        {
        //            expandStart = i;
        //            expandEnd = i + 1;
        //            outputCompare += 2;

        //            // ()()...
        //            while (expandEnd + 2 < s.Length && keep)
        //            {
        //                keep = false;

        //                if (s[expandEnd + 1] == '(' && s[expandEnd + 2] == ')')
        //                {
        //                    outputCompare += 2;
        //                    expandEnd += 2;
        //                    keep = true;
        //                    haveExpand = true;
        //                }
        //            }

        //            keep = true;

        //            while (expandEnd + 1 < s.Length && expandStart - 1 >= 0 && keep)
        //            {
        //                 keep = false;

        //                if (s[expandStart - 1] == '(' && s[expandEnd + 1] == ')')
        //                {
        //                    outputCompare += 2;
        //                    expandStart -= 1;
        //                    expandEnd += 1;
        //                    keep = true;
        //                    haveExpand = true;
        //                }
        //            }
        //        }

        //        if (lastEnd == expandStart - 1)
        //            output += outputCompare; 
        //        else
        //            output = Math.Max(output, outputCompare);

        //        lastEnd = expandEnd;
        //        outputCompare = 0;

        //        if (haveExpand)
        //            i = expandEnd + 1;
        //        else
        //            i++;
        //    }

        //    return output;
        //}
    }
}
