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

        public static void PrintGenericBase(int number, int baseValue)
        {
            string conversion = "0123456789ABCDEF";
            char digit = (char)(number % baseValue);
            number = number / baseValue;
            if (number != 0)
            {
                PrintGenericBase(number, baseValue);
            }
            Console.Write(" " + conversion[digit]);
        }

    }
}
