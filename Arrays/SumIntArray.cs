using System;

namespace Demo.SumArray
{
    /// <summary>
    /// return the sum of all the elements in array
    /// </summary>
    class Program
    {
        public static int SumArray(int[] array)
        {
            var size = array.Length;
            var total = 0;
            var index = 0;
            for (index = 0; index < size; index++)
            {
                total = total + array[index];
            }
            return total;
        }
        public static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine($"Array sum : {SumArray(array)}");
        }
    }
}
