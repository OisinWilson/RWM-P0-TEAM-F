using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzzFilter : MonoBehaviour
{
   public static int fizzBuzz(int t_int)
    {
        int result = t_int;
        if (t_int % 3 == 0)
        {
            result = 3;
        }
        if (t_int % 5 == 0)
        {
            result = 5;
        }
        if (t_int % 5 == 0 && t_int % 3 == 0)
        {
            result = 0;
        }

        return result;
    }

    public static int[] multiFizzBuzz(int[] t_nums)
    {
        int[] results = new int[t_nums.Length];

        for(int i = 0;i < t_nums.Length; i++)
        {
            results[i] = fizzBuzz(t_nums[i]);   
        }

        return results;
    }
}
