using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem101
    {
        public bool IsSymmetric(TreeNode root)
        {
            #region Depth-first (Recursive)
            List<int> leftListValue = new List<int>();
            List<int> rightListValue = new List<int>();
            LeftTreePart(root.left, leftListValue);
            RightTreePart(root.right, rightListValue);

            if (leftListValue.Count != rightListValue.Count)
                return false;

            for (int i = 0; i <leftListValue.Count; i++)
            {
                if (leftListValue[i] != rightListValue[i])
                    return false;
            }

            return true;

            //return IsMirror(root, root);
            #endregion

            #region Breath-first

            #endregion
        }

        //public bool IsMirror(TreeNode root1, TreeNode root2)
        //{
        //    if (root1 == null && root2 == null)
        //        return true;
        //    if (root1 == null || root2 == null)
        //        return false;

        //    return root1.val == root2.val && IsMirror(root1.left, root2.right) && IsMirror(root1.right, root2.left);
        //}

        public void LeftTreePart(TreeNode root, List<int> listValue)
        {
            if (root == null)
            {
                listValue.Add(-1);
                return;
            }

            listValue.Add(root.val);
            LeftTreePart(root.left, listValue);
            LeftTreePart(root.right, listValue);
        }
        public void RightTreePart(TreeNode root, List<int> listValue)
        {
            if (root == null)
            {
                listValue.Add(-1);
                return;
            }

            listValue.Add(root.val);
            RightTreePart(root.right, listValue);
            RightTreePart(root.left, listValue);
        }
    }
}
