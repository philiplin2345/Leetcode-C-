using System;
using System.Collections.Generic;
using System.Linq;

namespace Subsets2
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] nums = { 1, 2, 2 };

			

			Program abc = new Program();
			List<List<int>> result = abc.SubsetsWithDup(nums);
			List<List<int>> resultbm = abc.SubsetsWithDupeBitMask(nums);
			List<List<int>> resultrecursive = abc.SubsetsWithDupRecursive(nums);
			Console.WriteLine("subset2!");
		}

		public List<List<int>> SubsetsWithDup(int[] nums)
		{
			List<List<int>> result = new List<List<int>>();
			result.Add(new List<int>());

			Array.Sort(nums);
			int previousListSize = 0;

			for (int i = 0; i < nums.Length; i++)
			{
				int count = result.Count;
				// duplicate - skip already processed elements
				int startIndex = (i > 0 && nums[i] == nums[i - 1]) ? previousListSize : 0;
				previousListSize = count;

				for (int j = startIndex; j < count; j++)
				{
					List<int> subset = result[j].ToList();
					subset.Add(nums[i]);
					result.Add(subset);
				}
			}

			return result;
		}


		public List<List<int>> SubsetsWithDupeBitMask(int[] nums)
		{
			List<List<int>> result = new List<List<int>>();
			int size = (int)Math.Pow(2, nums.Length);

			Array.Sort(nums);
			for (int i = 0; i < size; i++)
			{
				List<int> subset = new List<int>();
				bool hasDuplicate = false;

				for (int j = 0; j < nums.Length; j++)
				{
					if ((i & (1 << j)) != 0)
					{
						// duplicate and previous num is not part of current subset
						if (j != 0 && nums[j] == nums[j - 1] && (i & (1 << (j - 1))) == 0)
						{
							hasDuplicate = true;
							break;
						}

						subset.Add(nums[j]);
					}
				}

				if (!hasDuplicate)
				{
					result.Add(subset);
				}
			}

			return result;
		}

		public List<List<int>> SubsetsWithDupRecursive(int[] nums)
		{
			Array.Sort(nums);
			List<List<int>> result = new List<List<int>>();
			List<int> currentList = new List<int>();
			helper(nums, result, currentList, 0);
			return result;
		}

		private void helper(int[] nums, List<List<int>> result, List<int> currentList, int start)
		{
			result.Add(currentList.ToList());
			for (int i = start; i < nums.Length; i++)
			{
				if (i == start || nums[i] != nums[i - 1])
				{
					currentList.Add(nums[i]);
					helper(nums, result, currentList, i + 1);
					currentList.RemoveAt(currentList.Count - 1);
				}
			}
		}

	}
}
