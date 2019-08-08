using System;

namespace Atoi
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "123jfwk2312";
            int a = MyAtoi(phrase);
            Console.WriteLine("Hello World!{0}",a);
        }
        static int MyAtoi(string str)
        {

            // Initialize result 
            int res = 0;
            // Initialize sign as positive 
            int sign = 1;
            // Initialize index of first digit 
            int i = 0;
            // If number is negative, then 
            // update sign 
            if (str[0] == '-')
            {
                sign = -1;
                // Also update index of first 
                // digit 
                i++;
            }

            // Iterate through all digits 
            // and update the result 
            for (; i < str.Length; ++i)
                if (str[i] - '0' >= 0 && str[i] - '0' <= 9)
                    res = res * 10 + str[i] - '0';
                else
                    return sign * res;

            
            // Return result with sign 
            return sign * res;
        }
    }
}
