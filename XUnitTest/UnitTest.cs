using System;
using Xunit;
using Algorithms.Algorithm;

namespace XUnitTestProject1
{
    public class UnitTest
    {
        double[] inputData = new double[] { 7, 3, 8, 1, 4, 2, 11, 16, 12 };
        double[] outputData = new double[] { 1, 2, 3, 4, 7, 8, 11, 12, 16 };
        
        [Fact]
        public void TestBubbleDefault()
        {
            Assert.Equal<double[]>(outputData, BubbleSort.SortDefault(inputData));
        }

        [Fact]
        public void TestBubbleSort()
        {
            Assert.Equal<double[]>(outputData, BubbleSort.SortAsc(inputData));
        }

        [Fact]
        public void TestInsertionSort()
        {
            Assert.Equal<double[]>(outputData, InsertionSort.SortAcs(inputData));
        }

        [Fact]
        public void TestSelectionSort()
        {
            Assert.Equal<double[]>(outputData, SelectionSort.SortAsc(inputData));
        }
    }
}
