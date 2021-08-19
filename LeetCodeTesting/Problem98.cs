using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem98
    {
        public bool IsValidBST(TreeNode root)
        {
            //return IsValidNodes(root, Int32.MaxValue, Int32.MinValue, false, false);

            if (root == null)
                return true;
            return IsBST(root, long.MinValue, long.MaxValue);
        }

        // Easy one
        public bool IsBST(TreeNode root, long min, long max)
        {
            if (root == null)
                return true;

            if (root.val <= min || root.val >= max)
                return false;

            return IsBST(root.left, min, root.val)
                  && IsBST(root.right, root.val, max);
        }

        public bool IsValidNodes(TreeNode root, int upperBound, int lowerBound, bool insideMax, bool insideMin)
        {
            if (root.val == Int32.MaxValue)
                insideMax = true;
            else if (root.val == Int32.MinValue)
                insideMin = true;

            if (root.left != null && root.right != null)
            {
                if ((root.val > root.left.val && root.left.val > lowerBound) && (root.val < root.right.val && root.right.val < upperBound))
                {
                    return IsValidNodes(root.left, root.val, lowerBound, insideMax, insideMin) && IsValidNodes(root.right, upperBound, root.val, insideMax, insideMin);
                }
                else if ((root.val > root.left.val && root.left.val > lowerBound) && (root.val < root.right.val && root.right.val == Int32.MaxValue))
                {
                    if (root.right.right != null)
                        return false;

                    return IsValidNodes(root.left, root.val, lowerBound, insideMax, insideMin) && IsValidNodes(root.right, upperBound, root.val, insideMax, insideMin);
                }
                else if ((root.val > root.left.val && root.left.val == Int32.MinValue) && (root.val < root.right.val && root.right.val < upperBound))
                {
                    if (root.left.left != null)
                        return false;

                    return IsValidNodes(root.left, root.val, lowerBound, insideMax, insideMin) && IsValidNodes(root.right, upperBound, root.val, insideMax, insideMin);
                }
                else if ((root.val > root.left.val && root.left.val == Int32.MinValue) && (root.val < root.right.val && root.right.val == Int32.MaxValue))
                {
                    if (root.left.left != null && root.right.right != null)
                        return false;

                    return IsValidNodes(root.left, root.val, lowerBound, insideMax, insideMin) && IsValidNodes(root.right, upperBound, root.val, insideMax, insideMin);
                }
            }
            else if (root.left != null && root.right == null)
            {
                if (root.val > root.left.val && root.left.val > lowerBound)
                {
                    return IsValidNodes(root.left, root.val, lowerBound, insideMax, insideMin);
                }
                else if (root.val > root.left.val && root.left.val == Int32.MinValue && !insideMin)
                {
                    if (root.left.left != null)
                        return false;

                    return IsValidNodes(root.left, root.val, lowerBound, insideMax, insideMin);
                }
            }
            else if (root.left == null && root.right != null)
            {
                if (root.val < root.right.val && root.right.val < upperBound)
                {
                    return IsValidNodes(root.right, upperBound, root.val, insideMax, insideMin);
                }
                else if (root.val < root.right.val && root.right.val == Int32.MaxValue && !insideMax)
                {
                    if (root.right.right != null)
                        return false;

                    return IsValidNodes(root.right, upperBound, root.val, insideMax, insideMin);
                }
            }
            else
            {
                if (root.val < upperBound && root.val > lowerBound)
                    return true;
                else if (upperBound == Int32.MaxValue && root.val == Int32.MaxValue)
                    return true;
                else if (lowerBound == Int32.MinValue && root.val == Int32.MinValue)
                    return true;
            }

            return false;
        }
    }
}
