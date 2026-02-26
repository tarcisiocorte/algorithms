using System;
using System.Collections.Generic;
using System.Text;

namespace Tccp.Algorithm.DynamicProgramming
{
    public static class UglyNumber
    {
        /// <summary>
        /// Use dynamic programming to solve the ugly number, it means without recursive function
        /// O(n) algorithm
        /// Every number can be divided by 2, 3, 5 only
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int GetNthUglyNumber(int number)
        {

            // To store ugly numbers
            int[] uglyArray = new int[number];
            int index2 = 0, index3 = 0, index5 = 0;
            int nextMultipleOf2 = 2;
            int nextMultipleOf3 = 3;
            int nextMultipleOf5 = 5;
            int nextUglyNumber = 1;

            uglyArray[0] = 1;

            for (int i = 1; i < number; i++)
            {
                nextUglyNumber = Math.Min(nextMultipleOf2, Math.Min(nextMultipleOf3, nextMultipleOf5));

                uglyArray[i] = nextUglyNumber;

                if (nextUglyNumber == nextMultipleOf2)
                {
                    index2 = index2 + 1;
                    nextMultipleOf2 = uglyArray[index2] * 2;
                }

                if (nextUglyNumber == nextMultipleOf3)
                {
                    index3 = index3 + 1;
                    nextMultipleOf3 = uglyArray[index3] * 3;
                }
                if (nextUglyNumber == nextMultipleOf5)
                {
                    index5 = index5 + 1;
                    nextMultipleOf5 = uglyArray[index5] * 5;
                }
            }
            return nextUglyNumber;
        }


        private static int MaxDivide(int aNumber, int bNumber)
        {
            while (aNumber % bNumber == 0)
                aNumber = aNumber / bNumber;
            return aNumber;
        }

        private static int IsUglyNumber(int number)
        {
            number = MaxDivide(number, 2);
            number = MaxDivide(number, 3);
            number = MaxDivide(number, 5);
            return (number == 1) ? 1 : 0;
        }

        /// <summary>
        /// Use recursive function to find ugly number
        /// it is bot an efficient algorithm
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int GetNthUglyNumberByRecursive(int n)
        {
            int i = 1;
            int count = 1;
            while (n > count)
            {
                i++;
                if (IsUglyNumber(i) == 1)
                {
                    count++;
                }
            }
            return i;
        }
    }
}
