using System;
using System.Collections.Generic;
using System.Linq;

namespace HalveArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			Program pg = new Program();
			int ans = 0;
			int[] inputArr = { 3, 3, 3, 3, 5, 5, 5, 2, 2, 7 };
			ans = pg.MinSetSize(inputArr);
			Console.WriteLine(ans);
		}


		public int MinSetSize(int[] arr)
		{
			List<(int a, int b)> freqs = new List<(int a, int b)>();


				freqs = arr
				.GroupBy(number => number)
				.Select(numbergroup => (Number: numbergroup.Key, Count: numbergroup.Count()))
				.OrderByDescending(numberfreq => numberfreq.Count)
				.ToList();
			var freqs1 = arr
				.GroupBy(number => number)
				.Select(numbergroup => (Number: numbergroup.Key, Count: numbergroup.Count()))
				.OrderByDescending(numberfreq => numberfreq.Count)
				.ToList();
			int i = 0;
			int count = 0;
			double half = arr.Length / 2;
			while (half > 0)
			{
				half -= freqs[i++].b;
				count++;
			}

			return count;
		}
	}
}
