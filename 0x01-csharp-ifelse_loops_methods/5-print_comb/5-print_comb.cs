using System;


    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0 ; i < 99 ; i++)
                Console.Write("{0:D2}, ", i);
            Console.WriteLine("{0:D2}", i);
        }
    }