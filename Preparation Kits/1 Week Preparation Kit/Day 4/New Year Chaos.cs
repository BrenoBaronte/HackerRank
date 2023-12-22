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
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */
     
     // 1 2 3 4 5
     
     // 3 4 5 2 1

    public static void minimumBribes(List<int> q)
    {
        var bribes = 0;

            for (int index = q.Count - 1; index >= 0; index--)
            {
                if (q[index] != index + 1)
                {
                    if (q[index - 1] == index + 1)
                    {
                        bribes++;
                        var aux = q[index];
                        q[index] = q[index - 1];
                        q[index - 1] = aux;
                    }
                    else
                    {
                        if (q[index - 2] == index + 1)
                        {
                            bribes += 2;

                            var aux = q[index - 2];
                            q[index - 2] = q[index - 1];
                            q[index - 1] = aux;

                            aux = q[index - 1];
                            q[index - 1] = q[index];
                            q[index] = aux;
                        }
                        else
                        {
                            Console.WriteLine("Too chaotic");
                            return;
                        }
                    }
                }

            }

            Console.WriteLine(bribes);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

            Result.minimumBribes(q);
        }
    }
}
