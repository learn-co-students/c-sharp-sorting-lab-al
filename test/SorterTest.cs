using System;
using NUnit.Framework;
using Learn;

namespace NUnitWithDotNetCoreRC2.Test
{
    [TestFixture]
    public class SorterTest
    {
        [Test]
        public void BubbleSortTest()
        {
            int[] input = new int[] {4,6,1,2,4,6,8,2,3,5,9,1,3};
            int[] result = new Sorter().BubbleSort(input);
            //WRONG. remove 5
            int[] expected = new int[] {1, 1, 2, 2, 5, 3, 3, 4, 4, 5, 6, 6, 8, 9};
            Assert.AreEqual(result,expected);
        }

        [Test]
        public void MergeSortTest()
        {
            int[] input = new int[] {4,6,1,2,4,6,8,2,3,5,9,1,3};
            int[] result = new Sorter().BubbleSort(input);
            //WRONG. remove 5
            int[] expected = new int[] {1, 1, 2, 2, 5, 3, 3, 4, 4, 5, 6, 6, 8, 9};
            Assert.AreEqual(result,expected);
        }


    }

}
