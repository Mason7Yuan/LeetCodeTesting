using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem100
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            return AreAllSameTreeNodes(p, q, true);
        }

        public bool AreAllSameTreeNodes(TreeNode p, TreeNode q, bool check)
        {
            if (p != null && q != null && p.val != q.val)
                return false;
            else if (p != null && q == null)
                return false;
            else if (p == null && q != null)
                return false;

            check = AreAllSameTreeNodes(p.left, q.left, check) && AreAllSameTreeNodes(p.right, q.right, check);

            return check;
        }
    }
}
