using System;
using System.Collections.Generic;
using System.Text;

namespace Tccp.Algorithm.DynamicProgramming
{
    public static class DynamicArrays
    {
        public static List<int> DynamicArray(int n, List<List<int>> queries)
        {
            List<List<int>> list = new List<List<int>>();
            List<int> resultArray = new List<int>();
            int lastAnswer = 0;

            for (int i = 0; i < n; i++)
                list.Add(new List<int>());

            for (int i = 0; i < queries.Count; i++)
            {
                int x = queries[i][1];
                int y = queries[i].Count > 2 ? queries[i][2] : 0;
                int index = (x ^ lastAnswer) % n;

                if (queries[i][0] == 1)
                    list[index].Add(y);

                if (queries[i][0] == 2)
                {
                    var indexArrayTwo = 0;
                    var newVal = 0;

                    if (list[index].Count > 0)
                        indexArrayTwo = y % list[index].Count;

                    if (list[index].Count > 0)
                        newVal = list[index][indexArrayTwo];

                    lastAnswer = newVal;
                    resultArray.Add(lastAnswer);
                }
            }
            return resultArray;
        }
    }
}
