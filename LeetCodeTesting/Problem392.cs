using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem392
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length > t.Length)
                return false;

            #region long version (Clear)
            //int nowNum = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    for (int j = nowNum; j < t.Length; j++)
            //    {
            //        if (s[i] == t[j])
            //        {
            //            nowNum = j + 1;
            //            break;
            //        }

            //        if (j == t.Length - 1 && s[i] != t[j])
            //        {
            //            return false;
            //        }
            //    }

            //    if (nowNum == t.Length)
            //        return false;
            //}

            //return true;
            #endregion

            #region short version
            int j = 0;
            for (int i = 0; i < t.Length && j < s.Length; i++)
            {
                if (t[i] == s[j])
                {
                    j++;
                }
            }

            return j == s.Length;
            #endregion
        }
    }
}
