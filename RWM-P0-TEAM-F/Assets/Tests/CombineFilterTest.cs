using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CombineFilterTest
    {
        [Test]
        public void combinedFilterSimple()
        {
            int[] input = { 2, 4, 1, -1, 0 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 2, 2, 3, 2, -0 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
