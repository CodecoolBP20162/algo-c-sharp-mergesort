using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MergesortAlgorithm;
using System.Collections.Generic;

namespace MergesortTests
{
    [TestClass]
    public class MergesortTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "The toSort argument can not be null.")]
        public void Sort_SortingNull_ThrowsException()
        {
            Mergesort mergeSort = new Mergesort();
        }

        [TestMethod]
        public void Sort_SortingSimpleItems_SortTheGivenList()
        {
            Mergesort mergeSort = new Mergesort();

            List<int> toSort = new List<int> { 5, 3, 1, 12, 9 };
            mergeSort.Sort(toSort);

            List<int> expected = new List<int> { 1, 3, 5, 9, 12 };
            CollectionAssert.AreEqual(expected, toSort);
        }

        [TestMethod]
        public void Sort_DuplicateItems_SortTheGivenList()
        {
            Mergesort mergeSort = new Mergesort();

            List<int> toSort = new List<int> { 5, 3, 1, 5, 9 };
            mergeSort.Sort(toSort);

            List<int> expected = new List<int> { 1, 3, 5, 5, 9 };
            CollectionAssert.AreEqual(expected, toSort);
        }

        [TestMethod]
        public void Sort_OneItemInTheList_DoesNotModifyTheList()
        {
            Mergesort mergeSort = new Mergesort();

            List<int> toSort = new List<int> { 2 };

            List<int> expected = new List<int> { 2 };
            CollectionAssert.AreEqual(expected, toSort);
        }
    }
}
