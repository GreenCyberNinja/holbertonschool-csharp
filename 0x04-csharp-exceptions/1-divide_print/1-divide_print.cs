using System;

class Int
{
    public static void divide(int a, int b)
    {
        int ans = 0;
        try
        {
            ans = a / b;
        }
        catch
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {ans}");
        }
    }
}