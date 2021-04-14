using System;


    class Program
    {
        static void Main(string[] args)
        {
            for (char ans = 'a'; ans <= 'z'; ans++){
                if (ans != 'q' && ans != 'e'){
                    Console.Write($"{ans}");
                }
                
            }
            
        }
    }