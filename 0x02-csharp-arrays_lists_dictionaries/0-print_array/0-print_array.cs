using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] ans = new int [size];
        int i;
        for (i = 0; i < size; i++)
        {
            ans[i] = i;
            Console.Write($"{ans[i]} ");
        }
        Console.WriteLine("");
        return ans;
    }
}