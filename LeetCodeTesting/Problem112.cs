using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem112
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            bool isExist = false;
            SumOver(root, 0, targetSum, ref isExist);

            return isExist;
        }

        public void SumOver(TreeNode root, int sum, int targetSum, ref bool isExist)
        {
            if (isExist)
                return;

            sum += root.val;

            if (root.left != null)
                SumOver(root.left, sum, targetSum, ref isExist);
            if (root.right != null)
                SumOver(root.right, sum, targetSum, ref isExist);

            if (root.left == null && root.right == null)
                isExist = sum == targetSum ? true : false;
        }
    }
}
