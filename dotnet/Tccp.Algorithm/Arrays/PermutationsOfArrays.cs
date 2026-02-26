using System;
using System.Collections.Generic;
using System.Text;

namespace Tccp.Algorithm.Arrays
{
   public static class PermutationsOfArrays
    {
        private static void PrintArray(int[] array, int count)
        {
            Console.Write("\n Values stored in array are : ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(" " + array[i]);
            }
        }
        private static void Swap(int[] array, int x, int y)
        {
            int temp = array[x];
            array[x] = array[y];
            array[y] = temp;
            return;
        }
        public static void Permutation(int[] array, int init, int length)
        {
            if (length == init)
            {
                PrintArray(array, length);
                return;
            }
            int j = init;
            for (j = init; j < length; j++)
            {
                Swap(array, init, j);
                Permutation(array, init + 1, length);
                Swap(array, init, j);
            }
            return;
        }
    }
}
