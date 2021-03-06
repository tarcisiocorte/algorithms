﻿using System;
using Tccp.Algorithm.Arrays;
using Tccp.Algorithm.DynamicProgramming;
using Tccp.Algorithm.Recursive;

namespace Tccp.Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteAllPermutationOfArray();
        }

        #region Samples code to execute in the Main program

        private static void ExecuteAllPermutationOfArray()
        {
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                array[i] = i;
            }
            PermutationsOfArrays.Permutation(array, 0, 5);
        }

        public static void ExecutePrintGenericBase()
        {
            Formula.PrintGenericBase(100, 10);
        }

        public static void ExecuteUnglyNumber()
        {
            int number = UglyNumber.GetNthUglyNumber(84);
            Console.WriteLine($" Number is {number}");
        }

        public static void ExecuteMaxSubArraySum()
        {
            int[] array = new int[] { -1, -2, 3, 4, -4, 6, -14, 8, 2 };
            MaxSumSubArray.MaxSubArraySum(array);
        }

        public static void RotateArray()
        {
            RotateArray rotate = new RotateArray();
            rotate.ReverseArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 1, 3);
        }


        public void ExecuteBinarySearch()
        {
            BinarySerach.BinarySearch(new int[] { 10, 12, 20, 28, 29, 45, 48, 50 }, 19);
        }

        public static void ExecuteMovingTotal()
        {
            MovingTotal movingTotal = new MovingTotal();

            movingTotal.Append(new int[] { 1, 2, 3, 4 });

            Console.WriteLine(movingTotal.Contains(6));
            Console.WriteLine(movingTotal.Contains(9));
            Console.WriteLine(movingTotal.Contains(12));
            Console.WriteLine(movingTotal.Contains(7));

            movingTotal.Append(new int[] { 5 });

            Console.WriteLine(movingTotal.Contains(6));
            Console.WriteLine(movingTotal.Contains(9));
            Console.WriteLine(movingTotal.Contains(12));
            Console.WriteLine(movingTotal.Contains(7));
        }
        #endregion
    }
}
