using System;
using System.Collections.Generic;
using System.Text;

namespace Tccp.Algorithm
{
    public class HourGlass
    {

        /**
        An hourglass in  is a subset of values with indices falling in this pattern in 's graphical representation:
            a b c
              d
            e f g        
        **/
        static int hourglassSum(int[][] arr)
        {
            if (arr.Length < 6) return 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length < 6) return 0;
            }
            int toReturn = int.MinValue;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr[i].Length - 2; j++)
                {
                    int maxHourGlassSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if (toReturn < maxHourGlassSum)
                    {
                        toReturn = maxHourGlassSum;
                    }
                }
            }
            return toReturn;
        }
    }
}
