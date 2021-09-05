using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tst!");
            int[] num1 = new int[6] { 1,2,3,0,0,0};
            int[] num2 = new int[3] { 2, 5, 6 };
            int m = 3;
            int n = 3;
            Merge(num1,m,num2,n);
            Console.WriteLine($"{string.Join(",",num1)}");
            Console.WriteLine(num2);
        }




        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int lastIndex = --m + --n + 1;
            // while both the arrays still have elements to compare
            while (m >= 0 && n >= 0)
                nums1[lastIndex--] = nums2[n] > nums1[m] ? nums2[n--] : nums1[m--];
            // if second array still has elements to move
            while (n >= 0) nums1[lastIndex--] = nums2[n--];
        }

    }
}
