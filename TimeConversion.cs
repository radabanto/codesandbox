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
    public class TimeUtil
    {
        public static string timeConversion(string s)
        {
            DateTime d = DateTime.Parse(s);
            return d.ToString("HH:mm:ss");
        }
    }
}