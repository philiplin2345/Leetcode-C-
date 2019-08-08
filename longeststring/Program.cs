using System;
using System.Collections.Generic;

namespace longeststring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s = "heuwoqrlaslkslklllsdfjdskcmmdmmmdssdfff";
            stringData sd = LengthOfLongestSubstring(s);
            Console.WriteLine(sd.stringLength);
            Console.WriteLine("The longest string is {0}, with a length of {1} characters",s.Substring(sd.start,sd.end), sd.stringLength);
        }
        static stringData LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            int ans = 0;
            int start = 0;
            int end = 0;
            stringData sd = new stringData();
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j <= n; j++)
                    if (allUnique(s, i, j))
                    {
                        if ((j - i) > ans)
                        {
                            start = i;
                            end = j;
                            ans = Math.Max(ans, j - i);
                        }
                    }
            sd.start = start;
            sd.end = end;
            sd.stringLength = ans;
            return sd;
        }

        struct stringData
        {
            public int start;
            public int end;
            public int stringLength;
        }
        static bool allUnique(String s, int start, int end)
        {
            HashSet<char> set = new HashSet<char>();
            for (int i = start; i < end; i++)
            {
                char ch = s[i];
                if (set.Contains(ch)) return false;
                set.Add(ch);
            }
            return true;
        }
    }
}
