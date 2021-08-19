using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem844
    {
        public bool BackspaceCompare(string s, string t)
        {
            #region Build String(Stack)
            Stack<char> sStack = StackToBuildString(s);
            Stack<char> tStack = StackToBuildString(t);

            while (sStack.Count != 0 && tStack.Count != 0)
            {
                if (sStack.Peek() == tStack.Peek())
                {
                    sStack.Pop();
                    tStack.Pop();
                }
                else
                {
                    return false;
                }
            }

            if (sStack.Count == 0 && tStack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            #endregion
        }

        public Stack<char> StackToBuildString(string str)
        {
            Stack<char> output = new Stack<char>();
            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '#')
                {
                    output.Push(str[i]);
                }
                else if (output.Count != 0)
                {
                    output.Pop();
                }
            }

            return output;
        }
    }
}
