using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> ans = new List<int>();
        foreach (int i in list1)
        {
            if (list2.Contains(i))
            {
                ans.Add(i);
            }
        }
        ans.Sort();
        return ans;
    }
}