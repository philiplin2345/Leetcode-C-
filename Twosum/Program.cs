﻿using System;

namespace Twosum
{
    class Program
    {
        static int[] numbers = { 2, 7, 11, 15 };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] theTwoNum = TwoSum(numbers, 9);
            string s = new string(Array.ConvertAll(theTwoNum, x => (char)x));
            Console.WriteLine(s);
        }
        static public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] + nums[i] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }
}
