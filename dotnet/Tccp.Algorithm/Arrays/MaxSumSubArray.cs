using System;
using System.Collections.Generic;
using System.Text;

namespace Tccp.Algorithm.Arrays
{
    public static class MaxSumSubArray
    {
        /// <summary>
        /// Find the largest sum contiguous subarray.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int MaxSubArraySum(int[] array)
        {
            var size = array.Length;
            int maxSoFar = 0, maxEndingHere = 0;
            for (var i = 0; i < size; i++)
            {
                maxEndingHere = maxEndingHere + array[i];
                if (maxEndingHere < 0)
                {
                    maxEndingHere = 0;
                }
                if (maxSoFar < maxEndingHere)
                {
                    maxSoFar = maxEndingHere;
                }
            }
            return maxSoFar;
        }
    }
}
