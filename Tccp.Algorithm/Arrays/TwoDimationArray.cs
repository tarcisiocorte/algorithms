using System;

namespace Demo.TwoDimationArray
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDimensionArrayExample(10,20);
        }

        public static void TwoDimensionArrayExample(int lengthFirstArray, int lengthSecondArray)
        {
            int[,] arr = new int[lengthFirstArray, lengthSecondArray];
            int count = 0;
            for (int i = 0; i < lengthFirstArray; i++)
            {
                for (int j = 0; j < lengthSecondArray; j++)
                {
                    arr[i, j] = count++;
                }
            }
            Write2DArray(arr, lengthFirstArray, lengthSecondArray);
        }

        public static void Write2DArray(int[,] arr, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine(" " + arr[i, j]);
                }
            }
        }
    }
}
