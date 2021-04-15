using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        Dictionary<string, string> NewD = myDict;
        if (NewD.ContainsKey(key))
        {
            NewD[key] = value;
        }
        else
        {
            NewD.Add(key, value);
        }
        return NewD;
    }
}