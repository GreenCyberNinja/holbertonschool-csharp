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
            Console.Write($"{ans[i]}");
            if (i != size - 1)
                Console.WriteLine(" ");
            else
                Console.Write("\n");
        }
        if (size == 0)
            Console.Write("\n");
        return ans;
    }
}