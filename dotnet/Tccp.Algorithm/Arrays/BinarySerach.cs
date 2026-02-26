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

        public static int BinarySearchRecursive(int[] array, int low, int high, int value)
        {
            if (low > high)
                return -1;
            int mid = low + (high - low) / 2;
            if (array[mid] == value)
                return mid;
            else if (array[mid] < value)
                return BinarySearchRecursive(array, mid + 1, high, value);
            else
                return BinarySearchRecursive(array, low, mid - 1, value);
        }
    }
}
