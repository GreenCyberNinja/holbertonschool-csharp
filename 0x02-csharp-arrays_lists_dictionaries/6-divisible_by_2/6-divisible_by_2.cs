using System;
using System.Collections.Generic;
class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        var ans = new List<bool>();
        foreach (int num in myList)
        {
            if (num % 2 != 0)
                ans.Add(false);
            else
                ans.Add(true);
        }
        return ans;
    }
}
