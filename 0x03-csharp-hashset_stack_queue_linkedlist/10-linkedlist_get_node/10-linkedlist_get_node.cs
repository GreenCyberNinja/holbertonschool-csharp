using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int i = 0;
        LinkedListNode<int> nav = myLList.First;
        while (nav != null)
        {
            if (i == n)
                return nav.Value;
            i++;
            nav = nav.Next;
        }
        return 0;
    }
}