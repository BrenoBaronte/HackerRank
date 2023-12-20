using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long minSum = 0;
        long maxSum = 0;
        
        arr.Sort();
        
        for (int index = 0; index < arr.Count; index++)
        {
            if (index == 0)
                minSum += arr.ElementAt(index);
            else if (index == arr.Count - 1)
                maxSum += arr.ElementAt(index);
            else
            {
                minSum += arr.ElementAt(index);
                maxSum += arr.ElementAt(index);
            }
        }
        
        Console.WriteLine($"{minSum} {maxSum}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
