using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array != null || array.Length != 0)
        {
            int i;
            int size = array.Length;
            for (i = size - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }
        }
        Console.WriteLine("");
    }
}