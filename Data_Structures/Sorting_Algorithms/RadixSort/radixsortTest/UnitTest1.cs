using RadixSort;
using System;
using Xunit;

namespace radixsortTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortArray1()
        {
            int[] arr = new int[] { 3, 5, 1, 8, 7 };
            Program.Radixsort(arr);
            int[] newArr = new int[] { 1, 3, 5, 7, 8 };
            Assert.Equal(newArr, arr);
        }

        [Fact]
        public void CanSortArray2()
        {
            int[] arr = new int[] { 783, 115, 236, 729, 965 };
            Program.Radixsort(arr);
            int[] newArr = new int[] { 115, 236, 729, 783, 965 };
            Assert.Equal(newArr, arr);
        }

        [Fact]
        public void CanSortArray3()
        {
            int[] arr = new int[] { 155, 0, 345, 23, 42 };
            Program.Radixsort(arr);
            int[] newArr = new int[] { 0, 23, 42, 155, 345 };
            Assert.Equal(newArr, arr);
        }
    }
}
