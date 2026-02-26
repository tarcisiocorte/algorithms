using System;

namespace Demo.Array
{
    class Program
    {
        //subscript operator [].
        //Lowest subscript is 0 and highest subscript is (size of array – 1).
        static void Main(string[] args)
        {
            Console.WriteLine("Values stored in array are: ");
            var array = new int[] { 1, 2, 3, 4, 5, 6 };
            PrintArrayData(array);
        }

        public static void PrintArrayData(int[] array)
        {
            if (array == null || array.Length == 0) return;
            var count = array.Length;
            for (int i = 0; i < count; i++)
                Console.WriteLine($" " + array[i]);
        }
    }
}
