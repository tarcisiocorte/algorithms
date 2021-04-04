using System;
using System.Collections.Generic;
using System.Text;

namespace Tccp.Algorithm.Recursive
{
    public static class TowerOfHanoi
    {
        public static void ExecuteRecursiveTowerOfHanoi(int number, char source, char distance, char temp)
        {
            if (number < 1)
            {
                return;
            }
            ExecuteRecursiveTowerOfHanoi(number - 1, source, temp, distance);
            Console.WriteLine("Move " + number + " disk from peg " + source + " to peg " + distance);
            ExecuteRecursiveTowerOfHanoi(number - 1, temp, distance, source);
        }
    }
}
