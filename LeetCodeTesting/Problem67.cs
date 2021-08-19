using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem67
    {
        public string AddBinary(string a, string b)
        {
            bool ifCarry = false;
            StringBuilder output = new StringBuilder();

            if (a.Length > b.Length)
            {
                AppendOn(a, b, ref ifCarry, ref output);
                RestAppendOn(a, b.Length, ref ifCarry, ref output);
            }
            else if (a.Length < b.Length)
            {
                AppendOn(b, a, ref ifCarry, ref output);
                RestAppendOn(b, a.Length, ref ifCarry, ref output);
            }
            else
                AppendOn(a, b, ref ifCarry, ref output);

            return Reverse(output.ToString());
        }

        // large one set on a.
        public void AppendOn(string a, string b, ref bool beforeCarry, ref StringBuilder output_)
        {
            for (int i = Math.Min(a.Length, b.Length) - 1; i >= 0; i--)
            {
                IfCarry carryInfo = CarryOrNot(a[i + a.Length - b.Length], b[i], beforeCarry);

                output_.Append(carryInfo.num);

                beforeCarry = carryInfo.ifCarry;
            }

            if (a.Length == b.Length && beforeCarry)
                output_.Append('1');
        }

        public void RestAppendOn(string a, int bLength, ref bool beforeCarry, ref StringBuilder output_)
        {
            for (int i = a.Length - bLength - 1; i >= 0; i--)
            {
                IfCarry lastInfo = RestCarryOrNot(a[i], beforeCarry);

                output_.Append(lastInfo.num);

                beforeCarry = lastInfo.ifCarry;
            }
            if (beforeCarry)
                output_.Append('1');
        }

        public IfCarry CarryOrNot(char a, char b, bool beforeCarry)
        {
            if (beforeCarry)
            {
                if (a == '1' && b == '1')
                    return new IfCarry(true, '1');
                else if (a == '1' || b == '1')
                    return new IfCarry(true, '0');
                else
                    return new IfCarry(false, '1');
            }
            else
            {
                if (a == '1' && b == '1')
                    return new IfCarry(true, '0');
                else if (a == '1' || b == '1')
                    return new IfCarry(false, '1');
                else
                    return new IfCarry(false, '0');
            }
        }

        public IfCarry RestCarryOrNot(char a, bool beforeCarry)
        {
            if (beforeCarry)
            {
                if (a == '1')
                    return new IfCarry(true, '0');
                else
                    return new IfCarry(false, '1');
            }
            else
            {
                if (a == '1')
                    return new IfCarry(false, '1');
                else
                    return new IfCarry(false, '0');
            }
        }

        public struct IfCarry
        {
            public bool ifCarry;
            public char num;

            public IfCarry(bool ifCarry_, char num_)
            {
                this.ifCarry = ifCarry_;
                this.num = num_;
            }
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}
