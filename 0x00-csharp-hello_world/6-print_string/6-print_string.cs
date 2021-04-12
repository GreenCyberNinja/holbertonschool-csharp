using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
        string ans = str.Substring(0, 9);
		Console.WriteLine($"{str}{str}{str}");
        Console.WriteLine($"{ans}");
        }
}