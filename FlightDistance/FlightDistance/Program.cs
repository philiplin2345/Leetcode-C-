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
            int max = 0;
            for (int i = 0; i < forwardRouteList.Count; i++)
            {
                for (int j = 0; j < returnRouteList.Count; j++)
                {
                    if (max < forwardRouteList[i][1] + returnRouteList[j][1] && forwardRouteList[i][1] + returnRouteList[j][1] <= maxTravelDist)
                    {
                        max = forwardRouteList[i][1] + returnRouteList[j][1];
                    }
                }
            }
            List<List<int>> ans = new List<List<int>>();

            for (int i = 0; i < forwardRouteList.Count; i++)
            {
                for (int j = 0; j < returnRouteList.Count; j++)
                {
                    if (max == forwardRouteList[i][1] + returnRouteList[j][1])
                    {
                        ans.Add(new List<int> { i + 1, j + 1 });
                        //Console.WriteLine((i+1)+" "+(j+1));
                    }
                }
            }
            //Console.WriteLine(max);



            return ans;
        }
    }
}
