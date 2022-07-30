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
     * Complete the 'divisibleSumPairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY ar
     */

     // Sample change branch

    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        var retCount = 0;
        var skipIndex = 1;
        foreach(var number in ar)
        {
            foreach(var partner in ar.Skip(skipIndex))
            {
                var eval = number + partner;
                Console.WriteLine($"Sum = {eval}");
                if (eval%k == 0)
                {
                    retCount++;
                }
            }
            skipIndex++;
        }

        return retCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.divisibleSumPairs(n, k, ar);

        Console.WriteLine(result);

        // textWriter.Flush();
        // textWriter.Close();
    }
}
