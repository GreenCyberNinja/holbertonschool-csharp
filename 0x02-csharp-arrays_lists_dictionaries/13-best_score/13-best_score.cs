using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int max = 0;
        string maxkey = "";
        foreach(KeyValuePair<string, int>keval in myList)
        {
            if (max < keval.Value)
            {
                max = keval.Value;
                maxkey = keval.Key;
            }
        }
        return maxkey;
    }
}