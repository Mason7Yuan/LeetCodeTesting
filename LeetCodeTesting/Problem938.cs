using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem938
    {
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            #region basket
            //List<int> output = new List<int>();

            //FindVaildValue(root, low, high, output);

            //return output.Sum();
            #endregion

            #region Stack
            int ans = 0;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                if (node != null)
                {
                    if (low <= node.val && node.val <= high)
                        ans += node.val;
                    if (low < node.val)
                        stack.Push(node.left);
                    if (node.val < high)
                        stack.Push(node.right);
                }
            }
            return ans;
            #endregion
        }

        void FindVaildValue(TreeNode root, int low, int high, List<int> collector)
        {
            if (root == null)
                return;
            else if (root.val >= low && root.val <= high)
                collector.Add(root.val);
            else if (root.val < low && root.right == null)
                return;
            else if (root.val > high && root.left == null)
                return;

            FindVaildValue(root.left, low, high, collector);
            FindVaildValue(root.right, low, high, collector);
        }
    }
}
