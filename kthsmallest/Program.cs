using System;
using System.Collections.Generic;
using System.Linq;

namespace kthsmallest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] numMatrix = new int [3,3];
            numMatrix[0,0] = 1;
            numMatrix[0,1] = 5;
            numMatrix[0,2] = 9;
            numMatrix[1,0] = 10;
            numMatrix[1,1] = 11;
            numMatrix[1,2] = 13;
            numMatrix[2,0] = 12;
            numMatrix[2,1] = 13;
            numMatrix[2,2] = 15;
            int k = 8;
            Program pg = new Program();
            int i = pg.KthSmallest(numMatrix, k);
            Console.WriteLine(i);
        }

        public int KthSmallest(int[,] matrix, int k)
        {
            int r = 0;
            SortedList<int, Tuple<int, int>> s = new SortedList<int, Tuple<int, int>>(new DuplicateKeyComparer<int>());
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                s.Add(matrix[i, 0], new Tuple<int, int>(i, 0));
            }
            //We are findin the nth smallest so we replace the smallest number with the second to smallest at the time. Rinse and repeat
            while (k-- > 0)
            {
                r = s.First().Key;
                int x = s.First().Value.Item1, y = s.First().Value.Item2;
                s.RemoveAt(0);
                if (y < matrix.GetLength(0) - 1)
                {
                    s.Add(matrix[x, y + 1], new Tuple<int, int>(x, y + 1));
                }
            }
            return r;
        }

    }
    public class DuplicateKeyComparer<TKey> : IComparer<TKey> where TKey : IComparable
    {
        public int Compare(TKey x, TKey y)
        {
            int result = x.CompareTo(y);
            return result == 0 ? 1 : result;
        }
    }
}
