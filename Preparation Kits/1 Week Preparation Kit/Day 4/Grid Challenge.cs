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
     * Complete the 'gridChallenge' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static string gridChallenge(List<string> grid)
    {
        var sortedGrid = new List<string>();

        foreach (var item in grid)
        {
            var aux = item.ToCharArray();

            Array.Sort(aux);

            sortedGrid.Add(new string(aux));
        }

        if (sortedGrid.Count == 1)
            return "YES";

        for (int index = 0; index < sortedGrid[0].Count(); index++)
        {
            var currentElements = sortedGrid.Select(x => x.Substring(index, 1)).ToList();

            for (int j = 1; j < currentElements.Count; j++)
            {
                var currentChar = currentElements[j];
                var previousChar = currentElements[j - 1];

                if (previousChar[0] > currentChar[0])
                    return "NO";
            }
        }

        return "YES";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> grid = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            string result = Result.gridChallenge(grid);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
