using System;
using System.Collections.Generic;
class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        SortedList<string, string> ans = new SortedList<string, string>();
        foreach (KeyValuePair<string, string>keval in myDict)
        {
            ans[keval.Key] = keval.Value;
        }
        foreach (var item in ans)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}