using System;

namespace MaxArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] walls = { 12, 33,26, 23, 1, 23, 55, 77, 88, 33, 66, 33};
            int maxArea = MaxArea(walls);
            Console.WriteLine("Hello World!");
        }
        static int MaxArea(int[] height)
        {
            int maxArea = 0;
            int l = 0;
            int r = height.Length - 1;
            while (r - l >= 1)
            {
                maxArea = Math.Max(maxArea, (r - l) * Math.Min(height[l], height[r]));
                if (height[r] > height[l])
                    l++;
                else
                    r--;
            }
            return maxArea;
        }

    }
}
