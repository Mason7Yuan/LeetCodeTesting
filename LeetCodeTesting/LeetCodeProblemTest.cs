using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class LeetCodeProblemTest
    {
        static void Main(string[] args)
        {
            //Adding new element into an array.
            //var intArray = new int[] { };
            //intArray = intArray.Concat(new int[] { 2 }).ToArray();

            //One clear method used to reverse a string.
            //string s = "abcde";
            //var charArray = s.ToCharArray();
            //Array.Reverse(charArray);
            //string newStr = new string (charArray);
            //Console.WriteLine(newStr);

            //Test Contains method(return bool value).
            //string msg = "abc";
            //var jdg = msg.Contains("d");
            //Console.WriteLine(jdg);

            //Testing array.Max() method
            //var intArray = new int[] { 1, 2, 3 };
            //Console.WriteLine(intArray.Max().ToString());

            //Remove all elements out of your array.
            //var a = new int[] { 1, 2, 3, 4 };
            //Array.Resize(ref a, 0);
            //foreach(var i in a)
            //{
            //    Console.WriteLine(i);
            //}

            //Give the maximum value of an array and its index.
            //int[] a = new int[] { 1, 2, 7, 4, 5, 6, 7 };
            //int max = a.Max();
            //int maxIndex = a.ToList().IndexOf(max);

            // two-dimension array, for higher .. int[,,]--three-dimension
            //int[,] dp = new int[3,3];
            //foreach(var i in dp)
            //{
            //    Console.WriteLine(i);
            //}

            // jagged array check.
            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[2] { 1,2 };
            //jaggedArray[1] = new int[5] { 0, 1, 2, 3, 4 };
            //Console.WriteLine(jaggedArray.Length);          // ans:3
            //Console.WriteLine(jaggedArray[0].Length);       // ans:2
            //Console.WriteLine(jaggedArray[1].Length);       // ans:5

            //var a = new int[5][];
            //a[0] = new int[4] { 0, 0, 0, 0 };
            //a[1] = new int[4] { 0, 0, 0, 1 };
            //a[2] = new int[4] { 0, 1, 0, 0 };
            //a[3] = new int[4] { 0, 0, 0, 0 };
            //a[4] = new int[4] { 0, 0, 0, 0 };

            //var myList = new List<KeyValuePair<string, int>>();
            //// adding elements
            //myList.Add(new KeyValuePair<string, int>("Laptop", 20));
            //myList.Add(new KeyValuePair<string, int>("Desktop", 40));
            //myList.Add(new KeyValuePair<string, int>("Tablet", 60));

            //myList[0].

            // Create a defualt "Whatever" value 1-D array.
            //var output = Enumerable.Repeat(1, 3).ToArray();
            //output.ToList().ForEach(a => Console.WriteLine(a));

            //var a = new List<int>();
            //for (var i = 1; i < 5; i++)
            //{
            //    a.Add(i);
            //}
            //a.ForEach(x => Console.WriteLine(x));

            // LINQ practiced
            //int[] a = new int[] { 1, 1, 1, 1, 1, 2 };

            //var b = from x in a
            //        where x < 2
            //        select x;

            //foreach(var i in b)
            //{
            //    Console.WriteLine(i);
            //}

            //ListNode l1 = new ListNode(1);
            //l1.next = new ListNode(8);
            ////l1.next.next = new ListNode(9);

            //ListNode l2 = new ListNode(0);
            //l2.next = new ListNode(9);
            //l2.next.next = new ListNode(9);
            //l2.next.next.next = new ListNode(9);
            //l2.next.next.next.next = new ListNode(9);

            //ListNode ans = Problem2.AddTwoNumbers(l1, l2);

            //while (ans != null)
            //{
            //    Console.WriteLine(ans.val);
            //    ans = ans.next;
            //}

            //List<StringBuilder> a = new List<StringBuilder>(new StringBuilder[2]);

            //StringBuilder b =  new StringBuilder("");
            //string c = "ghi";

            //a[0].Append('d');
            //foreach (var i in a)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(a[0].ToString()[1]);

            //for (int i = 0; i < b.Length; i++)
            //{
            //    for (int j = 0; j < c.Length; j++)
            //    {
            //        a
            //    }
            //}
            //a[2] = b;
            //a[0].Append(c);

            //TreeNode tr = new TreeNode(1);
            //tr.left = new TreeNode(2);
            //tr.right = new TreeNode(3);
            //tr.left.left = new TreeNode(4);
            //tr.left.right = new TreeNode(5);
            //tr.right.left = new TreeNode(6);
            //tr.right.right = new TreeNode(7);

            //Problem938 p938 = new Problem938();

            //int a = p938.RangeSumBST(tr, 9, 15);

            //TreeNode tr2 = new TreeNode(Int32.MinValue);
            //tr2.right = new TreeNode(Int32.MaxValue);

            //Problem98 ans = new Problem98();

            //bool ansBool = ans.IsValidBST(tr2);
            //Console.WriteLine(long.MaxValue > Int32.MaxValue);

            //SortedDictionary<char, char> a = new SortedDictionary<char, char>();

            //a.Add('a', 'Y');
            //a.Add('b', 'Y');

            //foreach (KeyValuePair<char, char> test in a)
            //{
            //    Console.WriteLine($"key: {test.Key} and value: {test.Value}");
            //}

            //string str = "abc";
            //byte[] asciiStr = Encoding.ASCII.GetBytes(str);

            //List<char> ch = new List<char>();
            //ch.Add('a');
            //ch.Add('b');
            //ch.Add('c');

            //Console.WriteLine(string.Join("", ch));

            //ch.Remove('a');

            //Console.WriteLine(string.Join("", ch));

            //int code = (int)'a';

            //Console.WriteLine(code);

            // print out intergers
            //foreach (byte b in asciiStr)
            //{
            //    Console.WriteLine(b);
            //}

            //char[] charArr = s.ToCharArray();
            //Array.Reverse(charArr);
            //s = string.Join("", charArr);

            //int convertedNum = int.Parse("a1");

            //StringBuilder sb = new StringBuilder();

            //sb.Append("a"+"a");
            //Console.WriteLine(convertedNum);

            Problem_July5 pj5 = new Problem_July5();
            int[][] b = new int[3][];
            b[0] = new int[2] { 1, 2 };
            b[1] = new int[2] { 3, 4 };
            b[2] = new int[2] { 5, 6 };

            int[][] a = pj5.MatrixReshape(b, 2, 3);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(a[0][i]);
            }

            Console.ReadLine();
        }

        //static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
