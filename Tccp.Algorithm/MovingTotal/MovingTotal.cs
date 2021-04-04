using System;
using System.Collections.Generic;
using System.Text;

namespace Tccp.Algorithm
{
    public class MovingTotal
    {
        List<int> items = new List<int>();
        public void Append(int[] list)
        {
            this.items.AddRange(list);
        }

        public bool Contains(int total)
        {
            int[] array = this.items.ToArray();
            var size = array.Length - 1;
            var indexToMove = 0;
            var sum = 0;
            while (sum <= total)
            {
                if (sum == total) return true;

                if (indexToMove > size || indexToMove + 1 > size || indexToMove + 2 > size) return false;

                var number0 = array[indexToMove];
                var number1 = array[indexToMove + 1];
                var number2 = array[indexToMove + 2];
                sum = number0 + number1 + number2;

                if (sum == total) return true;
                indexToMove += 1;
            }
            return false;
        }
    }
}
