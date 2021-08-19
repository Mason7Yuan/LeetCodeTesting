using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem1668
    {
        public static int MaxRepeating(string sequence, string word)
        {
            #region Brutal force
            //int output1 = 0, output2 = 0;
            //int nowCount = 0;

            //for (int i = 0; i < sequence.Length; i++)
            //{
            //    if (sequence[i] == word[nowCount])
            //    {
            //        nowCount++;

            //        for (int j = i + 1; j < sequence.Length; j++)
            //        {
            //            if (sequence[j] == word[nowCount])
            //            {
            //                nowCount++;
            //            }

            //            if (nowCount == word.Length)
            //            {
            //                output1++;
            //                nowCount = 0;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        output1 = 0;
            //        nowCount = 0;
            //        continue;
            //    }

            //    output2 = Math.Max(output1, output2);
            //}

            //return output2;
            #endregion

            #region Simplifty
            int output = 0, i = 0;
            string comparedWord = "";

            while (comparedWord.Length <= sequence.Length)
            {
                comparedWord += word;
                i++;

                if (sequence.Contains(comparedWord))
                {
                    output = i;
                }
            }

            return output;
            #endregion

            #region Better one
            //string comparedWord = word;
            //int output = 0;

            //while (sequence.Contains(comparedWord))
            //{
            //    comparedWord += word;
            //    output++;
            //}

            //return output;
            #endregion
        }
    }
}
