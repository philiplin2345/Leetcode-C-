using System;
using System.Numerics;

namespace medianofTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 3, 5 };
            int[] B = { 3, 6, 8 };
            int[] C = FindMedianSortedArrays(A, B);
            int totalLength = A.Length + B.Length;
            double median = 0.0;
            if (C.Length%2 == 0)
            {
                median = (C[totalLength / 2-1] + C[totalLength/ 2 ]) / 2;
            }
            else
            {
                median = C[totalLength / 2];
            }
            Console.WriteLine("Hello World!");
            Console.WriteLine(median);

            int[] X = { 3, 23, 4, 34, 555, 234, 33, 44, 21, 7, 5, 345, 23 };
            int[] Y = X;
            MergeSort(Y, 0, (X.Length-1));
            Y[2] = 23;
            Console.WriteLine("hi");
        }
        static int[] FindMedianSortedArrays(int[] A, int[] B)
        {
            
            int m = 0;
            int n = 0;
            int o = 0;
            int[] C = new int[10000];
           while((m<=A.Length-1)&&(n<=B.Length))
            {
                if(A[m]<=B[n])
                {
                    C[o] = A[m];
                    m += 1;
                    o += 1;
                }
                else
                {
                    C[o] = B[n];
                    n += 1;
                    o += 1;

                }
                    
            }
           while(m<= A.Length -1)
            {
                C[o] = A[m];
                m += 1;
                o += 1;
            }
           while(n<=(B.Length-1))
            {
                C[o] = B[n];
                n += 1;
                o += 1;
            }
            return C;
        }

        static void MergeSort(int[] c, int first, int end)
        {
            if (first < end)
            {
                int middle = (first + end) / 2;
                /*printf(" middle:%d\n",middle);
                printf(" first:%d\n",first);	
                printf(" end:%d\n\n",end);*/
                MergeSort(c, first, middle);
                MergeSort(c, (middle + 1), end);
                MergeLR(c, first, middle, end);

            }
        }

        static void MergeLR(int[] c, int first, int middle, int end)
        {

            int L_length = middle - first + 1;
            int R_length = end - middle;
            int[] L = new int[L_length];
            int[] R = new int[R_length];

            int i, j;
            for (i = 0; i < L_length; i++)
            {
                L[i] = c[first + i];
            }
            for (j = 0; j < R_length; j++)
            {
                R[j] = c[middle + 1 + j];
            }
            int m = 0, n = 0, o = first;
            while ((m < L_length) && (n < R_length))
            {
                if (L[m] <= R[n])
                {
                    c[o] = L[m];
                    m += 1;
                }
                else
                {
                    c[o] = R[n];
                    n += 1;
                }
                o += 1;
            }
            while (m < L_length)
            {
                c[o] = L[m];
                m += 1;
                o += 1;
            }
            while (n < R_length)
            {
                c[o] = R[n];
                n += 1;
                o += 1;
            }
        }

    }
}
