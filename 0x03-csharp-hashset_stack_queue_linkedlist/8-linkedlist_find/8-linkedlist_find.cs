using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int ans = 0;
        foreach ( var item in myLList)
        {
            ans++;
            if (item == value)
                return ans - 1;
        }
        ans = -1;
        return ans;
    }
}