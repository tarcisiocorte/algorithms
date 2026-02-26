using System;
using System.Collections.Generic;
using System.Text;

namespace Tccp.Algorithm.Arrays
{
  public  class RotateArray
    {
        public void ReverseArray(int[] array, int start, int end)
        {
            for (int i = start, j=end; i < j; i++, j--)
            {
                var temp = array[i];
                array[i] = array[j];
                array[j] = temp; 
            }
        }
    }
}
