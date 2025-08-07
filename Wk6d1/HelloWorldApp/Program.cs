using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName = "Jack";

        Console.WriteLine($"ToUpper(): {firstName.ToUpper()}\n");

        Console.WriteLine($"ToLower(): {firstName.ToLower()}\n");

        Console.WriteLine($"Length: {firstName.Length}");

        Console.WriteLine($"Replace('a', 'd'): {firstName.Replace('a','d')}\n");

        Console.WriteLine($"Split('a'):\n---------------\nLeft Split: {firstName.Split('a')[0]}\nRight Split: {firstName.Split('a')[1]}\n");

        Console.WriteLine($"Contains('a'): {firstName.Contains('a')}\n");
    }
}