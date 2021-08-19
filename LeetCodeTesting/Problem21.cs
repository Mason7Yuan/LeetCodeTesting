using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem21
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            #region Method of Visit all node.
            //ListNode head = new ListNode(0);
            //ListNode tail = head;

            //while (l1 != null && l2 != null)
            //{
            //    if (l1.val <= l2.val)
            //    {
            //        tail.next = l1;
            //        l1 = l1.next;
            //    }
            //    else
            //    {
            //        tail.next = l2;
            //        l2 = l2.next;
            //    }

            //    tail = tail.next;
            //}

            //tail.next = l1 == null ? l2 : l1;

            //return head.next;
            #endregion

            #region Method of recursion.
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;

            if (l1.val <= l2.val)
            {
                ListNode output = l1;
                output.next = MergeTwoLists(l1.next, l2);
                
                return output;
            }
            else
            {
                ListNode output = l2;
                output.next = MergeTwoLists(l1, l2.next);

                return output;
            }
            #endregion
        }
    }

    
}
