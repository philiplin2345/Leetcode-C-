using System;

namespace LPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "asddsaiejf vlwjehrpwjerpms;emcirrmw;emr;4aaaaaaaaaain vmspfeweriwqjerlmrk432lrnmwenlqe;coisaneorwpmkamfldsafs";
            string y = " ";
            y = LongestPalindrome(s);
            Console.WriteLine(y);
            Console.WriteLine("Hello World!");
        }

        static string LongestPalindrome(String s)
        {
            if (s == null || s.Length< 1) return "";
            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandAroundCenter(s, i, i);
                int len2 = ExpandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }
            return s.Substring(start, end-start + 1);
        }

        static int ExpandAroundCenter(String s, int left, int right)
        {
            int L = left, R = right;
            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }
            return R - L - 1;
        }
    }
}
