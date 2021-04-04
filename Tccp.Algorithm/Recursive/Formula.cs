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

        /// <summary>
        /// Euclid’s algorithm - GCD(n, m) == GCD(m, n mod m)
        /// </summary>
        /// <param name="numberA"></param>
        /// <param name="numberB"></param>
        /// <returns></returns>
        public static int GetGreatestCommonDivisor(int numberA, int numberB)
        {
            if (numberA < numberB)
            {
                return GetGreatestCommonDivisor(numberB, numberA);
            }
            if (numberA % numberB == 0)
            {
                return numberB;
            }
            return GetGreatestCommonDivisor(numberB, numberA % numberB);
        }
    }
}
