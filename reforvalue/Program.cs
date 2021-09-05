using System;

namespace reforvalue
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "aaa";
            string[] b = new string[] { "a","3"};
            string[] c = { "a", "3" };
            changestring(a);
            changeStringArray(b);
            changeStringArray(c);
            Console.WriteLine(a);
            Console.WriteLine(b.ToString());
        }

        static void changestring(string abc)
        {
            abc = "string changed";
        }
        static void changeStringArray(string[] abc)
        {
            abc[0] = "asdf";
        }
    }
}
