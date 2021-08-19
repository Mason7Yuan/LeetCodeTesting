using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem104
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            return FindDepth(root, 1);
        }

        int FindDepth(TreeNode root, int nowDepth)
        {
            if (root.left == null && root.right == null)
                return nowDepth;
            else if (root.left != null && root.right == null)
                return FindDepth(root.left, nowDepth + 1);
            else if (root.left == null && root.right != null)
                return FindDepth(root.right, nowDepth + 1);
            else
                return Math.Max(FindDepth(root.left, nowDepth + 1), FindDepth(root.right, nowDepth + 1));
        }


    }
}
