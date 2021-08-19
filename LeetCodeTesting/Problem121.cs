using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem121
    {
        public int MaxProfit(int[] prices)
        {
            #region Not simplify
            //if (prices.Length < 2)
            //    return 0;

            //int[] priceDiff = new int[prices.Length - 1];
            //int tempGain = 0, totalGain = 0;

            //for (int i = 1; i < prices.Length; i++)
            //{
            //    priceDiff[i - 1] = prices[i] - prices[i - 1];
            //}

            //for (int i  = 0; i < priceDiff.Length; i++)
            //{
            //    tempGain += priceDiff[i];

            //    totalGain = Math.Max(tempGain, totalGain);

            //    if (tempGain < 0)
            //        tempGain = 0;
            //}

            //return totalGain;
            #endregion

            int gain = 0;
            int min = Int32.MaxValue;

            for (int i = 0; i < prices.Length; i++)
            {
                min = Math.Min(min, prices[i]);

                if (prices[i] - min > gain)
                    gain = prices[i] - min;
            }

            return gain;
        }
    }
}
