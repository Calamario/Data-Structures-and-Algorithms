using InsertionSort;
using System;
using Xunit;

namespace InserionSortTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortArray1()
        {
            int[] arr = new int[] { 3, 5, 1, 8, 7 };
            int[] newArr = new int[] { 1, 3, 5, 7, 8 };
            Assert.Equal(newArr, Program.InsertionSorter(arr));
        }

        [Fact]
        public void CanSortArray2()
        {
            int[] arr = new int[] { 7, 15, 23, 7, 5 };
            int[] newArr = new int[] { 5, 7, 7, 15, 23 };
            Assert.Equal(newArr, Program.InsertionSorter(arr));
        }

        [Fact]
        public void CanSortArray3()
        {
            int[] arr = new int[] { 155, 0, -345, 23, 42 };
            int[] newArr = new int[] { -345, 0, 23, 42, 155 };
            Assert.Equal(newArr, Program.InsertionSorter(arr));
        }
    }
}
