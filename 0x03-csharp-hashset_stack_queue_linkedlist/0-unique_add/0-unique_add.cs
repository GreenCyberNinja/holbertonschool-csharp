using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int ans = 0;
        List<int> check = new List<int>();
    
        foreach (int i in myList)
        {
            if (!check.Contains(i))
            {
                ans += i;
                check.Add(i);
            };
        }
        return ans;
    }
}