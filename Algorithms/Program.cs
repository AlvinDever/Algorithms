using System;
using Algorithms.Algorithm;

namespace Algorithms
{
    partial class Program
    {
        static void Main(string[] args)
        {
            double[] dd = new double[] { 7, 3, 8, 1, 4, 2, 11, 16, 12 };

            PrintData(BubbleSort.SortDesc(dd));
            Console.WriteLine();
            PrintData(BubbleSort.SortAsc(dd));
            Console.WriteLine();
        }

        public static void PrintData(double[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i].ToString());
                Console.Write(",");
            }
        }
    }
}
