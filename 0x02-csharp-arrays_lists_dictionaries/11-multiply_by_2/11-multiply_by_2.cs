using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> ans = new Dictionary<string, int>();

        foreach (KeyValuePair<string, int>keval in myDict)
        {
            ans[keval.Key] = keval.Value * 2; 
        }
        return ans;
    }
}