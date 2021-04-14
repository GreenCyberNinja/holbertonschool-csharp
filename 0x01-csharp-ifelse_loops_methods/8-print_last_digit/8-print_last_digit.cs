using System;


    class Number
    {
        public static int PrintLastDigit(int number)
        {
            int ans = number % 10;
            if (ans < 0)
                ans *= -1;
            Console.Write($"{ans}");
            return ans;
        }
    }

