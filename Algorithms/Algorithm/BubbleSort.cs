using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithm
{
    public static class BubbleSort
    {
        public static double[] SortDesc(double[] data)
        {
            double temp;
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = data.Length - 1; j > i; j--)
                {
                    if (data[j] > data[j - 1])
                    {
                        temp = data[j - 1];
                        data[j - 1] = data[j];
                        data[j] = temp;
                        //data[j] = data[j] + data[j - 1];
                        //data[j - 1] = data[j] - data[j - 1];
                        //data[j] = data[j] - data[j - 1];
                    }
                }
            }

            return data;
        }

        public static double[] SortAsc(double[] data)
        {
            double temp;
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = 0; j < data.Length - 1 - i; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        temp = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = temp;
                        //data[j] = data[j] + data[j - 1];
                        //data[j - 1] = data[j] - data[j - 1];
                        //data[j] = data[j] - data[j - 1];
                    }
                }
            }

            return data;
        }
    }
}
