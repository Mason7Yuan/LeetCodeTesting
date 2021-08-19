using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem316
    {
        public static string RemoveDuplicateLetters(string s)
        {
            #region Ordered output
            //SortedDictionary<char, char> dictList = new SortedDictionary<char, char>();
            //dictList.Add('a', 'N');
            //dictList.Add('b', 'N');
            //dictList.Add('c', 'N');
            //dictList.Add('d', 'N');
            //dictList.Add('e', 'N');
            //dictList.Add('f', 'N');
            //dictList.Add('g', 'N');
            //dictList.Add('h', 'N');
            //dictList.Add('i', 'N');
            //dictList.Add('j', 'N');
            //dictList.Add('k', 'N');
            //dictList.Add('l', 'N');
            //dictList.Add('m', 'N');
            //dictList.Add('n', 'N');
            //dictList.Add('o', 'N');
            //dictList.Add('p', 'N');
            //dictList.Add('q', 'N');
            //dictList.Add('r', 'N');
            //dictList.Add('s', 'N');
            //dictList.Add('t', 'N');
            //dictList.Add('u', 'N');
            //dictList.Add('v', 'N');
            //dictList.Add('w', 'N');
            //dictList.Add('x', 'N');
            //dictList.Add('y', 'N');
            //dictList.Add('z', 'N');

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (dictList.ContainsKey(s[i]) && dictList[s[i]] == 'N')
            //        dictList[s[i]] = 'Y';
            //}

            //List<char> output = new List<char>();

            //foreach (KeyValuePair<char,char> temp in dictList)
            //{
            //    if (temp.Value == 'Y')
            //        output.Add(temp.Key);
            //}

            //return String.Join("", output);
            #endregion

            int[] freq = new int[26];
            char[] ch = s.ToCharArray();
            bool[] check = new bool[26];
            Stack<char> chStack = new Stack<char>();
            int index;

            for (int i = 0; i < ch.Length; i++)
            {
                freq[ch[i] - 'a']++;
            }

            for (int i = 0; i < ch.Length; i++)
            {
                index = ch[i] - 'a';
                freq[index]--;

                if (check[index])
                    continue;

                while (chStack.Count != 0 && chStack.Peek() > ch[i] && freq[chStack.Peek() - 'a'] != 0)
                    check[chStack.Pop() - 'a'] = false;

                chStack.Push(ch[i]);
                check[index] = true;
            }

            char[] output = new char[chStack.Count];
            int j = chStack.Count - 1;

            while (chStack.Count != 0)
            {
                output[j] = chStack.Pop();
                j--;
            }

            return string.Join("", output);
        }
    }
}
