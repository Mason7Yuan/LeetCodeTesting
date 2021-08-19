using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem122
    {
        public int MaxProfit(int[] prices)
        {
            #region Not simplify
            //int[] priceDiff = new int[prices.Length - 1];
            //int totalGain = 0;

            //for (int i = 1; i < prices.Length; i++)
            //{
            //    priceDiff[i - 1] = prices[i] - prices[i - 1];
            //}

            //for (int i = 0; i < priceDiff.Length; i++)
            //{
            //    if (priceDiff[i] > 0)
            //        totalGain += priceDiff[i];
            //}

            //return totalGain;
            #endregion

            int totalGain = 0;
            int tempGain = 0;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                tempGain = prices[i + 1] - prices[i];

                if (tempGain > 0)
                    totalGain += tempGain;
            }

            return totalGain;
        }
    }
}
