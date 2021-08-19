using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem394
    {
        public string DecodeString(string s)
        {
            while (s.IndexOf('[') != -1)
                s = StringWalkThrough(s);

            return s;
        }

        public string StringWalkThrough(string s)
        {
            StringBuilder output = new StringBuilder();
            Stack<char> pos = new Stack<char>();
            int head = 0, tail = 0;
            int num = 0;
            char end = ' ';

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '[')
                {
                    if (pos.Count == 0)
                    {
                        head = i - 1;
                        num = 1;
                        output.Remove(output.Length - 1, 1);

                        if (i - 2 >= 0)
                        {
                            if (char.IsDigit(s[i - 2]))
                            {
                                output.Remove(output.Length - 1, 1);
                                head--;
                                num++;
                            }
                        }
                        if (i - 3 >= 0)
                        {
                            if (char.IsDigit(s[i - 3]))
                            {
                                output.Remove(output.Length - 1, 1);
                                head--;
                                num++;
                            }
                        }
                    }

                    pos.Push('[');
                }
                else if (s[i] == ']')
                {
                    end = pos.Pop();

                    if (pos.Count == 0)
                        tail = i;
                }
                else if (pos.Count == 0)
                {
                    output.Append(s[i]);
                }

                if (end == '[' && pos.Count == 0)
                {
                    output.Append(DecodeStr(s, head, tail, num));
                    end = ' ';
                }
            }
            
            return output.ToString();
        }

        public StringBuilder DecodeStr(string s, int head, int tail, int num)
        {
            string numStr = s.Substring(head, num);
            string subStr = s.Substring(head + 1 + num, tail - head - num - 1);
            StringBuilder result = new StringBuilder();
            
            for (int i = 0; i < int.Parse(numStr); i++)
            {
                for (int j = 0; j < subStr.Length; j++)
                {
                    result.Append(subStr[j]);
                }
            }
            
            return result;
        }
    }
}
