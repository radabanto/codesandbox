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
namespace hackerrank{
    public class ArithmeticUtils
    {
        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();
            Console.WriteLine("");
            var minSum = (long)arr[0] + (long)arr[1] + (long)arr[2] + (long)arr[3];
            var maxSum = (long)arr[1] + (long)arr[2] + (long)arr[3] + (long)arr[4];
            Console.Write($"{minSum} {maxSum}");
        }

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
}