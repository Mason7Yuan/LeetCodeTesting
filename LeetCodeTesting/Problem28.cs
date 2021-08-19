using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem28
    {
        public static int StrStr(string haystack, string needle)
        {
            int output = 0;
            int iTemp;
            bool isExist = false;

            if (needle.Length == 0)
                return 0;

            if (needle.Length > haystack.Length)
                return -1;
            else if (haystack.Length == 1 && haystack[0] == needle[0])
                isExist = true;
            else if (needle.Length == 1)
            {
                for (int i = 0; i < haystack.Length; i++)
                {
                    if (haystack[i] == needle[0])
                    {
                        output = i;
                        isExist = true;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < haystack.Length; i++)
                {
                    if (haystack[i] == needle[0] && haystack.Length - i >= needle.Length)
                    {
                        output = i;
                        iTemp = i + 1;

                        for (int j = 1; j < needle.Length; j++)
                        {
                            if (haystack[iTemp] == needle[j])
                                iTemp++;
                            else
                                break;

                            if (j == needle.Length - 1)
                                isExist = true;
                        }

                        if (isExist == true)
                            break;
                    }
                }
            }

            if (isExist)
                return output;
            else
                return -1;
        }
    }
}
