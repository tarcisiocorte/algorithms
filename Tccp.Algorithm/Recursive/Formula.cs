using System;
using System.Collections.Generic;
using System.Text;

namespace Tccp.Algorithm.Recursive
{
    public static class Formula
    {
        public static int Factorial(int number)
        {
            if (number <= 1) // Termination Condition
            {
                return 1;
            }
            return number * Factorial(number - 1); // Body, Recursive Expansion
        }
    }
}
