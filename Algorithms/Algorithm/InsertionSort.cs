using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithm
{
    public static class InsertionSort
    {
        public static double[] SortAcs(double[] data)
        {
            double newValue;

            for(int i=1; i<data.Length;i++)
            {
                newValue = data[i];

                int j = i;

                // This loop will check the value of j to ensure we have not reached the end of the iteration (j = 0)
                // but also checks to see if the value preceding the current value is larger.
                // If it is, we "swap" the value before this one, decrement j, and then test against the next value
                // This continues until we run out of numbers in the array (j = 0) or there are no more values larger than
                // the current number (newValue) to it's left (preceding it).
                while (j> 0 && data[j-1]>newValue)
                {
                    data[j] = data[j - 1];
                    j--;
                }

                data[j] = newValue;
            }

            return data;
        }
    }
}
