using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> ans = new LinkedList<int>();
        for (int ind = 0; ind < size; ind++)
        {
            Console.WriteLine($"{ind}");
            ans.AddFirst(ind);
        }
        return ans;
    }
}