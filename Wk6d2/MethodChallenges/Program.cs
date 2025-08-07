namespace MethodChallenges;

class Program
{
    static void Main(string[] args)
    {
        // Activity: Method Challenges
        // To familiarise yourself with methods in C# try to complete the following challenges. Pay attention to what you are calling INSIDE Main() and what you are calling OUTSIDE Main() (but still within the Progam class).
        // Notice when the instructions ask for a return and when they ask for a print statement (Console.WriteLine()).
        // Write your code in a new project in your working folder: dotnet new console -n "CSharpMethodChallenges" --use-program-main.
        // Remember it is best practice to run your code as you go along (i.e. after you have called each method to check everything is working as expected).

        // Code Checker
        // This code will form part of your code checker. Please make sure you have:
        // Created a method
        // At least one of your methods takes in an argument(s)
        // At least one of your methods return a value
        // Static void method is present (this will apply to any method only printing (Console.WriteLine())) to the terminal


        // Tasks
        // PrintMessage() Write a method named PrintMessage that prints "Welcome to my C# program!". Call it from Main().
        PrintMessage();

        // GreetUser() Write a method named GreetUser that takes a string parameter called name and prints "Hello, {name}!". Call it from Main() with different names.
        GreetUser("Jack");

        // CalcuateTotalWithTip() Write a method named CalculateTotalWithTip() that takes double price and double tipPercentage, and 🚨returns the price after adding the tip. Call it from Main() and print the total amount.
        double finalPrice = CalcuateTotalWithTip(100, 10);
        Console.WriteLine($"Your final amount with the tip added is: {finalPrice}");

        // FindSmallest() Write a method named FindSmallest that takes three int parameters and 🚨returns the smallest number. Call it from Main() and print the result. You are not expected to use arrays and loops.
        int smallest = FindSmallest(5, 90, 1);
        Console.WriteLine($"The smallest number you entered was: {smallest}");

    }

    // Task Methods
    // PrintMessage() Write a method named PrintMessage that prints "Welcome to my C# program!". Call it from Main().

    static void PrintMessage()
    {
        Console.WriteLine("Welcome to my C# program!");
    }

    // GreetUser() Write a method named GreetUser that takes a string parameter called name and prints "Hello, {name}!". Call it from Main() with different names.
    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    // CalcuateTotalWithTip() Write a method named CalculateTotalWithTip() that takes double price and double tipPercentage, and 🚨returns the price after adding the tip. Call it from Main() and print the total amount.
    static double CalcuateTotalWithTip(double price, double tipPercentage)
    {
        price += price * (tipPercentage / 100);
        return price;
    }

    // FindSmallest() Write a method named FindSmallest that takes three int parameters and 🚨returns the smallest number. Call it from Main() and print the result. You are not expected to use arrays and loops.
    static int FindSmallest(int num1, int num2, int num3)
    {
        int smallest = Math.Min(num1, num2);
        smallest = Math.Min(num3, smallest);
        return smallest;
    }

}
