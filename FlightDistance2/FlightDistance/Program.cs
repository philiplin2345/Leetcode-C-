using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> forwardRouteList = new List<List<int>> {
            new List<int> { 1, 3000 },
            new List<int> { 2, 5000 },
            new List<int> { 3, 7000 },
            new List<int> { 4, 10000 }};

            List<List<int>> returnRouteList = new List<List<int>> {
                new List<int> { 1, 2000 },
            new List<int> { 2, 3000 },
            new List<int> { 3, 4000 },
            new List<int> { 4, 5000 }};

            List<List<int>> optimalroutes = new List<List<int>>();

            optimalroutes = optimalUtilization(10000, forwardRouteList, returnRouteList);

            //forwardRouteList = { { 1, 3000},{ 2, 5000},{ 3, 7000},{ 4, 10000} };
            Console.ReadKey();
        }
        static List<List<int>> optimalUtilization(int maxTravelDist, List<List<int>> forwardRouteList, List<List<int>> returnRouteList)
        {
            

            
            List<List<int>> ans = new List<List<int>>();

            for (int i = 0; i < forwardRouteList.Count; i++)
            {
                for (int j = 0; j < returnRouteList.Count; j++)
                {
                    
                        ans.Add(new List<int> { i + 1, j + 1, forwardRouteList[i][1] + returnRouteList[j][1] });//題目不是從0開始而是從1 所以+1
                        //Console.WriteLine((i+1)+" "+(j+1));
                    
                }
            }
            //Console.WriteLine(max);
            int max = 0;
            
            for (int i = 0; i < ans.Count; i++)
            {
                if(max < ans[i][2] && ans[i][2]<=maxTravelDist)
                {
                    max = ans[i][2];
                }
            }
            List<List<int>> ansFinal = new List<List<int>>();

            for (int i = 0; i < ans.Count; i++)
            {
                if (max == ans[i][2])
                {
                    ansFinal.Add(new List<int> { ans[i][0], ans[i][1] });
                }
            }


            return ansFinal;
        }
    }
}
