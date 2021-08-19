using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem6
    {
        //Remember to change static keyword as the file upload on leetcode web.
        public static string Convert(string s, int numRows)
        {
            if (s.Length <= numRows) { return s; }

            var output = new StringBuilder();
            var k = 0;

            int numPeriod = s.Length / (2 * (numRows - 1));
            int intPosition = s.Length % (2 * (numRows - 1));

            for (var i = 0; i < numRows; i++)
            {
                if (i == 0)
                {
                    while (k <= numPeriod)
                    {
                        if (k != numPeriod)
                        {
                            output.Append(s[i + k * 2 * (numRows - 1)]);
                        }

                        else if (k == numPeriod && intPosition >= 1)
                        {
                            output.Append(s[i + k * 2 * (numRows - 1)]);
                        }
                        k++;
                    }
                    k = 0;
                }
                else if (i == numRows - 1)
                {
                    while (k <= numPeriod)
                    {
                        if (k != numPeriod)
                        {
                            output.Append(s[i + k * 2 * (numRows - 1)]);
                        }

                        else if (k == numPeriod && intPosition >= numRows)
                        {
                            output.Append(s[i + k * 2 * (numRows - 1)]);
                        }
                        k++;
                    }
                }
                else
                {
                    while (k <= numPeriod)
                    {
                        if (k != numPeriod)
                        {
                            output.Append(s[i + k * 2 * (numRows - 1)]);
                            output.Append(s[i + k * 2 * (numRows - 1) + 2 * (numRows - i - 1)]);
                        }

                        else if (k == numPeriod && intPosition >= i + 1)
                        {
                            output.Append(s[i + k * 2 * (numRows - 1)]);

                            if (intPosition >= 2 * numRows - i - 1)
                            {
                                output.Append(s[i + k * 2 * (numRows - 1) + 2 * (numRows - i - 1)]);
                            }
                        }
                        k++;
                    }
                    k = 0;
                }

            }

            return output.ToString();
        }
    }
}
