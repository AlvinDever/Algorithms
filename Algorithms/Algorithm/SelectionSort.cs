using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithm
{
    public static class SelectionSort
    {
        public static double[] SortAsc(double[] data)
        {
            double min;
            double temp;
            int minIndex = 0;
            bool wrap = false;

            for (int i = 0; i < data.Length; i++)
            {
                min = data[i];
                wrap = false;

                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[j] < min)
                    {
                        min = data[j];
                        minIndex = j;
                        wrap = true;
                    }
                }
                if (wrap)
                {
                    temp = data[minIndex];
                    data[minIndex] = data[i];
                    data[i] = temp;
                }

            }
            return data;
        }
    }
}
