using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int ans;
        
        if (myLList.Any())
        {
            ans = myLList.First.Value;
            myLList.RemoveFirst();
        }
        else
            ans = 0;
        return ans;
    }
}