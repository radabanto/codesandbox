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

namespace hackerrank
{
    public class CamelCaseProblem
    {
        static void TitleCaseMyCamelStrings(List<string> inputList, int startingIndex)
        {
            TextInfo textInfo = new CultureInfo("en-US",false).TextInfo;
            for(int i = startingIndex; i < inputList.Count; i++)
            {
                inputList[i] = textInfo.ToTitleCase(inputList[i]);
            }
        }

    static List<string> SplitMyCamelCase(string input, string splitType)
    {
        Regex re = new Regex("([A-Z][a-z]*)");
        var output = re.Split(input);
        List<string> finalList = output.Where(x => !string.IsNullOrEmpty(x)).ToList().ConvertAll(d => d.ToLower());

        if (splitType == "M")
        {
            finalList.RemoveAt(finalList.IndexOf("()"));
        }

        return finalList;
    }

    static string JoinMyStrings(List<string> stringList, string joinType)
    {
        switch(joinType)
        {
            case "M":
                stringList.Add("()");
                TitleCaseMyCamelStrings(stringList, 1);
                break;
            case "C":
                TitleCaseMyCamelStrings(stringList, 0);
                break;
            case "V":
                TitleCaseMyCamelStrings(stringList, 1);
                break;
            default:
                // Can be used to log unexpected join types
                break;
        }
        
        var retString = String.Join("", stringList.ToArray());
        return retString;
    }

    static string[] ParseInput(string input)
    {
        return input.Split(';');
    }

    static string CamelCaseProcessor(List<string> userInput)
    {
        var retSplits = new List<string>();
        var retString = string.Empty;
        if(userInput.ElementAt(0) == "C")
        {
            retString = JoinMyStrings(userInput.ElementAt(2).Split(' ').ToList(), userInput.ElementAt(1));
        }
        else if(userInput.ElementAt(0) == "S")
        {
            string input = userInput.ElementAt(2);
            retSplits = SplitMyCamelCase(input, userInput.ElementAt(1));
            retString = String.Join(" ", retSplits.ToArray());
        }

        return retString;
    }
    }
}