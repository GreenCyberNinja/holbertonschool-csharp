using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lst = number % 10;
        Console.Write($"The last digit of {number} is");
        if (lst > 5){
            Console.WriteLine($" {lst} and is greater than 5");
        }
        if (lst < 6 && lst != 0) {
            Console.WriteLine($" {lst} and is less than 6 and not 0");
        }
        if (lst == 0){
            Console.WriteLine($" {lst} and is 0");
        }
    }
}