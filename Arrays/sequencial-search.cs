using Internal;
using System;

namespace Demo.SequencialSearch
{
    class Program
    {        
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6 };
            var value = 4;
            Console.WriteLine(Search(array, value));
        }

        public static void Search(int[] array, int searchValue)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if(searchValue == array[i])
                {
                    return i;
                }                
            }
            return -1
        }
    }
}
