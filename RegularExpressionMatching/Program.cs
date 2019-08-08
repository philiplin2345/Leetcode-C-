using System;

namespace RegularExpressionMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "aa";
            string pattern = "a*";
            bool matched = false;
            matched = IsMatch(text, pattern);
            Console.WriteLine("Hello World!");
        }

        static bool IsMatch(String text, String pattern)
        {
            if (pattern.Length == 0 ) return false;
            bool first_match = ((text.Length != 0) &&
                                   (pattern[0]== text[0] || pattern[0] == '.'));

            if (pattern.Length >= 2 && pattern[1] == '*')
            {
                return (IsMatch(text, pattern.Substring(2)) ||
                        (first_match && IsMatch(text.Substring(1), pattern)));
            }
            else
            {
                return first_match && IsMatch(text.Substring(1), pattern.Substring(1));
            }
        }
    }
}
