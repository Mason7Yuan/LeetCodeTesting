using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem17
    {
        // keyword static cant use other methods.
        public IList<string> LetterCombinations(string digits)
        { 
            List<string> listOfDigits = ListOfDigits(digits);
            int step = 0;

            int numOfAllPossibleDigits = NumOfAllPossibleDigits(listOfDigits);
            int[] book1 = new int[4] { 0, 0, 0, 0 };
            int[] book2 = new int[4] { 0, 0, 0, 0 };
            StringBuilder builtString = new StringBuilder("");
            List<string> output = new List<string>();
            
            output = GetAllProbableStrings(listOfDigits, book1, book2, step, builtString, output);

            return output;
        }

        List<string> GetAllProbableStrings(List<string> listOfDigits, int[] book1, int[] book2, int step, StringBuilder tempString, List<string> temp)
        {
            if (step == listOfDigits.Count)
            {
                temp.Add(tempString.ToString());
                tempString = new StringBuilder("");
            }

            for (int i = 0; i < listOfDigits.Count; i++)
            {
                if (book1[i] == 0)
                {
                    book1[i] = 1;

                    for (int j = 0; j < listOfDigits[i].Length; j++)
                    {
                        if (book1[i] == 0 && book2[j] == 0)
                        {
                            book2[j] = 1;

                            tempString.Append(listOfDigits[i][j].ToString());
                            temp = GetAllProbableStrings(listOfDigits, book1, book2, step + 1, tempString, temp);

                            book2[j] = 0;
                        }
                    }

                    book1[i] = 0;
                }
            }

            return temp;
        }

        int NumOfAllPossibleDigits(List<string> listOfDigits)
        {
            int output = 1;

            for (int i = 0; i < listOfDigits.Count; i++)
            {
                output *= listOfDigits[i].Length;
            }

            return output;
        }

        List<string> ListOfDigits(string digits)
        {
            List<string> output = new List<string>();

            for (int i = 0; i < digits.Length; i++)
            {
                output.Add(PhoneNumberToString(digits[i]));
            }

            return output;
        }

        string PhoneNumberToString(char num)
        {
            switch (num)
            {
                case '2':
                    return "abc";
                case '3':
                    return "def";
                case '4':
                    return "ghi";
                case '5':
                    return "jkl";
                case '6':
                    return "mno";
                case '7':
                    return "pqrs";
                case '8':
                    return "tuv";
                default:
                    return "wxyz";
            }
        }
    }
}
