using System;

namespace CommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keywords = { "" };
            string common = LongestCommonPrefix(keywords);
            Console.WriteLine("Hello World!");
        }
        static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0 || strs == null) return "";
            int i = 0;
            bool same = true;
            for (i = 0; i < strs[0].Length; i++)
            {
                if (same == true)
                {
                    string x = strs[0].Substring(i, 1);
                    for (int j = 1; j < strs.Length; j++)
                    {
                        if (x == strs[j].Substring(i, 1))
                        {

                        }
                        else
                        {
                            same = false;
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }

            }
            if (i > 0)
                return strs[0].Substring(0, i - 1);
            else
                return "";
        }
    }
}
