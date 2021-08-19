using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem134
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int[] totalCost = new int[gas.Length];
            int addTotalCost = 0;

            #region Good
            int labelNum = 0;
            int accmuNum = 0;

            for (int i = 0; i < gas.Length; i++)
            {
                addTotalCost += gas[i] - cost[i];
            }

            if (addTotalCost < 0)
                return -1;

            for (int i = 0; i < gas.Length; i++)
            {
                accmuNum += gas[i] - cost[i];

                if (accmuNum < 0)
                {
                    accmuNum = 0;
                    labelNum = i + 1;
                }
            }

            return labelNum;
            #endregion

            #region Bad
            //for (int i = 0; i < gas.Length; i++)
            //{
            //    totalCost[i] = gas[i] - cost[i];
            //}

            //if (totalCost.Sum() < 0)
            //    return -1;

            //for (int i = 0; i < totalCost.Length; i++)
            //{
            //    int[] testArr = CutAndCopy(totalCost, i);

            //    for (int j = 0; j < testArr.Length; j++)
            //    {
            //        addTotalCost += testArr[j];

            //        if (addTotalCost < 0)
            //            break;

            //        if (j == testArr.Length - 1)
            //        {
            //            return i;
            //        }
            //    }

            //    addTotalCost = 0;
            //}

            //return -1;
            #endregion
        }

        public int[] CutAndCopy(int[] arr, int tarNum)
        {
            List<int> output = new List<int>();

            for (int i = tarNum; i < arr.Length + tarNum; i++)
            {
                if (i < arr.Length)
                    output.Add(arr[i]);
                else
                    output.Add(arr[i - arr.Length]);
            }

            return output.ToArray();
        }
    }
}
