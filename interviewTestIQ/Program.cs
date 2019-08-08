using System;

namespace interviewTestIQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0,1,1,1,1,1,1,1,1,1,1};
            int size = arr.Length-1;
            Console.WriteLine("Maximum Obtainable Value is " +
                                            cutRod(arr, size));
            Console.WriteLine("Hello World!");
        }
        static int cutRod(int[] price, int n)
        {
            if (n <= 0)
                return 0;
            int max_val = 0;

            for (int i = 1; i < n+1; i++)
                max_val = Math.Max(max_val, price[i] +
                            cutRod(price, n - i ));

            return max_val;
        }

        // Driver Code 
        
    }
}
