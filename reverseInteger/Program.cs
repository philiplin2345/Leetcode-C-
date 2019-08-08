using System;

namespace reverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = -4823921;
            int numberRev = reverse(number);
            Console.WriteLine("Hello World!");
            Console.WriteLine("The reverse of {0} is {1}", number, numberRev);
        }
        static int reverse(int x)
        {
            int rev = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                if (rev > Int32.MaxValue / 10 || (rev == Int32.MaxValue / 10 && pop > 7)) return 0;
                if (rev < Int32.MinValue / 10 || (rev == Int32.MinValue / 10 && pop < -8)) return 0;
                rev = rev * 10 + pop;
            }
            return rev;
        }
    }
    
}
