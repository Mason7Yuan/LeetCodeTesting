using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class GetAllCharPosition
    {
        public static void GetAllPosition(string msg)
        {
            var numArray = new int[] { };
            var totalArr = new int[] { };
            var numPosition = 0;
            var start = true;

            for (var i = 0; i < msg.Length; i++)
            {
                if (!totalArr.Contains(i))
                {
                    while (numPosition < msg.Length)
                    {
                        if (start)
                        {
                            numPosition = msg.IndexOf(msg[i], i);
                            start = false;
                        }
                        else
                        {
                            numPosition = msg.IndexOf(msg[i], numPosition);
                        }

                        if (numPosition == -1)
                        {
                            break;
                        }
                        else
                        {
                            numArray = numArray.Concat(new int[] { numPosition }).ToArray();
                            totalArr = totalArr.Concat(new int[] { numPosition }).ToArray();
                            numPosition += 1;
                        }
                    }

                    Console.WriteLine($"{msg[i]}--------\n");

                    foreach (int num in numArray)
                    {
                        Console.WriteLine($"\t{num}");
                    }
                }

                start = true;
                numPosition = 0;
                numArray = new int[] { };

                Console.WriteLine("---------\n");
            }
        }
    }
}
