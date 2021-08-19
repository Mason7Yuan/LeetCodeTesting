using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem20
    {
        public static bool IsValid(string s)
        {
            #region Only Stack
            //Stack<char> temp = new Stack<char>();
            //int sLength = s.Length;

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            //    {
            //        temp.Push(s[i]);
            //        sLength--;
            //        continue;
            //    }

            //    if (s[i] == ')' && temp.Count != 0)
            //    {
            //        if (temp.Peek() == '(')
            //        {
            //            temp.Pop();
            //            sLength--;
            //        }
            //    }
            //    else if (s[i] == ']' && temp.Count != 0)
            //    {
            //        if (temp.Peek() == '[')
            //        {
            //            temp.Pop();
            //            sLength--;
            //        }
            //    }
            //    else if (s[i] == '}' && temp.Count != 0)
            //    {
            //        if (temp.Peek() == '{')
            //        {
            //            temp.Pop();
            //            sLength--;
            //        }
            //    }
            //}

            //return (temp.Count == 0 && sLength == 0);
            #endregion

            #region Stack + Hash
            Stack<char> st = new Stack<char>();
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add(')', '(');
            dict.Add('}', '{');
            dict.Add(']', '[');

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (!dict.ContainsKey(c))
                    st.Push(c);
                else
                {
                    if (st.Count == 0)
                        return false;

                    if (!dict[c].Equals(st.Pop()))
                        return false;
                }
            }

            if (st.Count > 0)
                return false;

            return true;
            #endregion
        }
    }
}
