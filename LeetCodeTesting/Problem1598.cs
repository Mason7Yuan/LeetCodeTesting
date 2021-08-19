using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem1598
    {
        public static int MinOperations(string[] logs)
        {
            Stack<string> result = new Stack<string>();

            for (int i = 0; i < logs.Length; i++)
            {
                if (logs[i] == "./") { }
                else if (logs[i] == "../" && result.Count != 0)
                {
                    result.Pop();
                }
                else if (logs[i] == "../" && result.Count == 0) { }
                else
                    result.Push(logs[i]);
            }

            return result.Count;
        }
    }
}
