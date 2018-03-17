using System;
using Algorithms.Algorithm;

namespace Algorithms
{
    partial class Program
    {
        static double[] inputData = new double[] { 7, 3, 8, 1, 4, 2, 11, 16, 12 };

        static void Main(string[] args)
        {
            Console.WriteLine("Array before sort: ");
            foreach (double db in inputData)
            {
                Console.Write(db + ",");
            }
            Console.WriteLine();
            Console.WriteLine();
            PrintData(BubbleSort.SortDesc(inputData), "Bubble Desc");
            Console.WriteLine();
            PrintData(BubbleSort.SortAsc(inputData), "Insert Asc");
            Console.WriteLine();
        }

        public static void PrintData(double[] data, string sortMethod)
        {
            Console.WriteLine("Array after "+ sortMethod+ " sort: ");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i].ToString() + ",");
            }
        }
    }
}
