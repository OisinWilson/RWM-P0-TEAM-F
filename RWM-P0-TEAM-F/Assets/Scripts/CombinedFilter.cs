using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class CombinedFilter
{
    public static int[] combinedFilter(int[] xs)
    {
        return FizzBuzzFilter.multiFizzBuzz(DecrementIfLessThanFirstFilter.DecrementIfLess(DiffFilter.Diff(xs.ToList<int>()).ToArray()));
    }
}
