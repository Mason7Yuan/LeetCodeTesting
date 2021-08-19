using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem75
    {
        public void SortColors(int[] nums)
        {
            #region Not keyword void: 
            //Dictionary<int, int> colorSorting = new Dictionary<int, int>();
            //int[] output = new int[nums.Length];

            //colorSorting.Add(0, 0);
            //colorSorting.Add(1, 0);
            //colorSorting.Add(2, 0);

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    colorSorting[nums[i]] += 1;
            //}

            //for (int i = 0; i < colorSorting[0]; i++)
            //    output[i] = 0;
            //for (int i = colorSorting[0]; i < colorSorting[0] + colorSorting[1]; i++)
            //    output[i] = 1;
            //for (int i = colorSorting[0] + colorSorting[1]; i <  nums.Length; i++)
            //    output[i] = 2;

            //return output;
            #endregion

            #region Keyword void:
            int goal = nums.Length - 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] == 2)
                {
                    if (i != goal)
                    {
                        SwitchArrayPos(nums, i, goal);
                        goal--;
                    }
                    else
                        goal--;
                }
            }

            goal = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    if (i != goal)
                    {
                        SwitchArrayPos(nums, i, goal);
                        goal++;
                    }
                    else
                        goal++;
                }
            }
            #endregion

            #region simplify

            #endregion
        }

        void SwitchArrayPos(int[] arrNum, int index1, int index2)
        {
            int target = arrNum[index1], goal = arrNum[index2];

            arrNum[index1] = goal;
            arrNum[index2] = target;
        }
    }
}
