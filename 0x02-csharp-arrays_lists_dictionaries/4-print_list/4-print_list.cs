using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        var ans = new List<int>();
        int i;
        for (i = 0; i < size; i++)
        {
            ans.Add(i);
            Console.Write($"{ans[i]} ");
        }
        Console.WriteLine("");
        return ans;
    }
}