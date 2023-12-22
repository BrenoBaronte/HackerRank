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
     * Complete the 'superDigit' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING n
     *  2. INTEGER k
     */

    public static int superDigit(string n, int k)
        {
            if (ulong.MaxValue.ToString().Length <= n.Length)
            {
                return superDigit(
                    (superDigit(n.Substring(0, n.Length / 2), 1) 
                        + superDigit(n.Substring(n.Length / 2), 1)
                    ).ToString(), 
                    1);
            }

            ulong number = Convert.ToUInt64(n);
        
            if (number < 10 && k == 1)
                return (int)number;
         
            number = sum(n) * (ulong)k;
        
            if (number > 9)
                number = (ulong)superDigit(number.ToString(), 1);
            
            return (int)number;
        }
    
        private static ulong sum(string n)
        {
            ulong sum = 0;

            foreach (char item in n)
                sum += Convert.ToUInt64(item.ToString());

            return sum;
        }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        string n = firstMultipleInput[0];

        int k = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.superDigit(n, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
