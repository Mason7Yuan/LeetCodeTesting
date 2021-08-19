using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem2_improve
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            List<int> temp1 = new List<int>();
            List<int> temp2 = new List<int>();
    
            double temp1Num = 0, temp2Num = 0;
            int tempCount = 0;

            ListNode outputHead = new ListNode(0);
            ListNode outputTail = outputHead;

            while (l1 != null)
            {
                temp1.Add(l1.val);
                l1 = l1.next;
            }
            while(l2 != null)
            {
                temp2.Add(l2.val);
                l2 = l2.next;
            }

            for (int i = temp1.Count - 1; i >= 0; i--)
            {
                temp1Num = temp1Num + temp1[tempCount] * Math.Pow(10, i);
                tempCount++;
            }
            tempCount = 0;
            for (int i = temp2.Count - 1; i >= 0; i--)
            {
                temp2Num = temp2Num + temp2[tempCount] * Math.Pow(10, i);
                tempCount++;
            }

            int tempNum1 = Convert.ToInt32(temp1Num + temp2Num);

            do
            {
                outputTail.next = new ListNode(tempNum1 % 10);
                outputTail = outputTail.next;

                tempNum1 /= 10;
            }
            while (tempNum1 != 0);

            return outputHead.next;
        }
    }
}
