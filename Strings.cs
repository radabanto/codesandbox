using System.Collections.Generic;

namespace hackerrank
{
    public class strings
    {
        public static bool stringMatchDeterminer(string reference, string forMatch)
        {
            return reference == forMatch;
        }

        /*
        * Complete the 'matchingStrings' function below.
        *
        * The function is expected to return an INTEGER_ARRAY.
        * The function accepts following parameters:
        *  1. STRING_ARRAY strings
        *  2. STRING_ARRAY queries
        */

        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> retList = new List<int>();
            foreach(var query in queries)
            {
                var counter = 0;
                foreach(var strng in strings)
                {
                    if (stringMatchDeterminer(strng, query))
                    {
                        counter++;
                    }
                }
                retList.Add(counter);
            }

            return retList;
        }
    }
}