using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem113
    {
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            List<IList<int>> output = new List<IList<int>>();
            IList<int> temp = new List<int>();

            if (root == null)
                return output;

            PathSumList(root, 0, targetSum, ref output, temp);
            return output;
        }

        //Travel all the nodes to leaf.
        public void PathSumList(TreeNode root, int sum, int targetSum, ref List<IList<int>> output, IList<int> tempOutput)
        {
            sum += root.val;
            tempOutput.Add(root.val);

            if (root.left != null)
                PathSumList(root.left, sum, targetSum, ref output, tempOutput);
            if (root.right != null)
                PathSumList(root.right, sum, targetSum, ref output, tempOutput);
            if (sum == targetSum)
                output.Add(tempOutput);
        }
    }
}
