using System;
using System.Collections.Generic;
using System.Text;

namespace Tccp.Algorithm.Arrays
{
    //Binary search in a sorted array.
    public static class BinarySerach
    {
       public static int BinarySearch(int[] array, int value)
        {
            var size = array.Length;
            int middle;
            int lower = 0;
            int higher = size - 1;
            while (lower <= higher)
            {
                middle = lower + (higher - lower) / 2;
                if(array[middle] == value)
                {
                    return middle;
                }
                else if(array[middle] < value)
                {
                    lower = middle + 1;
                }
                else
                {
                    higher = middle - 1;
                }
            }
            return -1;
        }
    }
}
