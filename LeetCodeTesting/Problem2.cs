using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem2
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode tail = head;

            while (l1 != null && l2 != null)
            {
                if (tail.next != null)
                {
                    tail.next.val += (l1.val + l2.val);  
                }
                else
                {
                    tail.next = new ListNode(l1.val + l2.val);
                }

                tail = tail.next;
                l1 = l1.next;
                l2 = l2.next;

                if (tail.val / 10 != 0)
                {
                    tail.val %= 10;
                    tail.next = new ListNode(1);
                }
            }

            while (l1 != null)
            {
                if (tail.next != null)
                {
                    tail.next.val += l1.val;

                    tail = tail.next;
                    l1 = l1.next;

                    if (tail.val / 10 != 0)
                    {
                        tail.val = 0;
                        tail.next = new ListNode(1);
                    }
                }
                else
                {
                    tail.next = l1;
                    break;
                }
            }
            while (l2 != null)
            {
                if (tail.next != null)
                {
                    tail.next.val +=  l2.val;

                    tail = tail.next;
                    l2 = l2.next;

                    if (tail.val / 10 != 0)
                    {
                        tail.val = 0;
                        tail.next = new ListNode(1);
                    }
                }
                else
                {
                    tail.next = l2;
                    break;
                }
            }

            return head.next;
        }
    }
}
