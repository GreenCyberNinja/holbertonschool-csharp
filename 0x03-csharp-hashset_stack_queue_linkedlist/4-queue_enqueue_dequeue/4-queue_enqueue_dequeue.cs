using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        bool con = aQueue.Contains(search);
        string[] ans = aQueue.ToArray();
        Console.WriteLine($"Number of items: {aQueue.Count}");
        Console.WriteLine($"Top item: {aQueue.Peek()}");
        Console.WriteLine($"Stack contains {search}: {con}");
        if (con)
        {
            foreach (string i in ans)
            {
                aQueue.Dequeue();
                if (i == search)
                    break;
            }
            aQueue.Enqueue(newItem);
        }
        return aQueue;

    }
}