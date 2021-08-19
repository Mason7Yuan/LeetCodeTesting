using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem1221
    {
        public int BalancedStringSplit(string s)
        {
            #region Roughly version
            //int LNum = 0, RNum = 0;
            //int output = 0;
            //int count = 0;

            //while (count < s.Length)
            //{
            //    if (s[count] == 'L')
            //    {
            //        LNum++;
            //    }
            //    else
            //    {
            //        RNum++;
            //    }

            //    if (LNum == RNum && LNum != 0 && RNum != 0)
            //    {
            //        output++;
            //    }

            //    count++;
            //}
            #endregion

            #region Better version
            int output = 0, rs = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'L')
                    rs++;
                else
                    rs--;

                if (rs == 0)
                    output++;
            }

            return output;
            #endregion
        }
    }
}
