using System;


    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 0 ; i < 8 ; i++)
                for (j = i + 1; j <= 9; j++)
                    Console.Write($"{i}{j}, ");
            Console.WriteLine($"89");
        }
    }