using System;
using System.Collections.Generic;

namespace Tccp.Algorithm.CodeChallenge
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public static int Execution(string s)
        {
            var pointerA = 0;
            var pointerB = 0;
            var max = 0;

            HashSet<char> hashSet = new HashSet<char>();

            while (pointerB < s.Length)
            {
                if (!hashSet.Contains(s[pointerB]))
                {
                    hashSet.Add(s[pointerB]);
                    pointerB++;
                    max = Math.Max(hashSet.Count, max);
                }
                else
                {
                    hashSet.Remove(s[pointerA]);
                    pointerA++; 
                }
            }
            return max;
        }
    }
}
