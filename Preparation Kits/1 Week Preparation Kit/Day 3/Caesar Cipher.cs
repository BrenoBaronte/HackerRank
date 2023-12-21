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
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        const string alphabet = "abcdefghijklmnopqrstuvwxyz";

            if (k >= alphabet.Count())
                k = k % alphabet.Count();

            string alphabetRotated = "";

            if (k == 0)
                alphabetRotated = alphabet;
            else
                alphabetRotated = alphabet.Substring(k) + alphabet.Substring(0, k);

            var result = "";

            for (int index = 0; index < s.Count(); index++)
            {
                var element = s[index];

                if (alphabet.Contains(element, StringComparison.InvariantCultureIgnoreCase))
                {
                    var ciphedElement = alphabetRotated[alphabet.IndexOf(element.ToString().ToLowerInvariant())];

                    if (element.ToString() == element.ToString().ToUpper())
                    {
                        result += ciphedElement.ToString().ToUpper();
                        continue;
                    }

                    result += ciphedElement;
                    continue;
                }

                result += element;                   
            }

            return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
