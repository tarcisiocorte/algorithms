using System;
using System.Collections.Generic;
using System.Text;

namespace Tccp.Algorithm.Arrays
{
    public static class TwoSum
    {
        public static int[] TwoSumWithDictionary(int[] nums, int target)
        {
            int length = nums.Length;
            if (length <= 1)
            {
                return new int[] { };
            }
            Dictionary<int, int> dictionary = new Dictionary<int, int>(length);
            int complementNumber;
            int index;
            int number;
            dictionary.Add(nums[0], 0);
            for (int i = 1; i < length; i++)
            {
                number = nums[i];
                complementNumber = target - number;
                if (dictionary.TryGetValue(complementNumber, out index))
                {
                    return new int[] { index, i };
                }
                if (!dictionary.ContainsKey(number))
                {
                    dictionary.Add(number, i);
                }
            }
            return new int[] { };
        }
    }
}
