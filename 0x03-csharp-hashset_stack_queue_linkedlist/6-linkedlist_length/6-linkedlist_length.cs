using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int ans = 0;
        foreach ( var item in myLList)
        {
            ans++;
        }
        return ans;
    }
}