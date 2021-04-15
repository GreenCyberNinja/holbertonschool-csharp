using System;
using System.Collections.Generic;


class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int i = 0;
        foreach (var key in myDict.Keys)
        {
            i++;
        }
        return i;
    }
}