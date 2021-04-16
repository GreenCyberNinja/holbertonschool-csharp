using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        bool con = aStack.Contains(search);
        string[] ans = aStack.ToArray();
        Console.WriteLine($"Number of items: {aStack.Count}");
        Console.WriteLine($"Top item: {aStack.Peek()}");
        Console.WriteLine($"Stack contains {search}: {con}");
        if (con)
        {
            foreach (string i in ans)
            {
                aStack.Pop();
                if (i == search)
                    break;
            }
            aStack.Push(newItem);
        }
        return aStack;

    }
}