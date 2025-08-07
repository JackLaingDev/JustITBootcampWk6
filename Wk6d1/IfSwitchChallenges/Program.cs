namespace IfSwitchChallenges;

class Program
{
    static void Main(string[] args)
    {
        // ACTIVITY:
        // To familiarise yourself with user input and conditional statements in C# try to complete the following challenges:

        // TIP: research `Console.Write()` and `Console.ReadLine()`
        // TIP: Don't bother with `TryParse()`, stick to `int.Parse()` instead
        // TIP: Don't worry about the warnings about nullable reference types

        // - Larger Number: Ask the user for two numbers and print the larger of the two.
        Console.WriteLine("Enter a number:\n");
        int num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number:\n");
        int num2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"The largest number you told me is: {Math.Max(num1, num2)}");

        // - Discount Calculator: Ask for the total price of an order. Apply a 10% discount if the total is - over £100; otherwise, display the original price.
        Console.WriteLine("Enter the price of your order in whole numbers:\n");
        int num3 = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"I have applied a 10% discount, here is your new price: {num3 * 0.9}");

        // - Traffic Light System: Ask the user to enter "red", “amber", or "green" and display the corresponding action (e.g: "Stop", "Slow down", "Go").
        Console.WriteLine("Enter either 'red', 'amber' or 'green' and I will tell you what to do!:\n");
        string answer1 = Console.ReadLine();
        switch (answer1)
        {
            case "red":
                Console.WriteLine("Stop");
                break;
            case "amber":
                Console.WriteLine("Slow Down");
                break;
            case "green":
                Console.WriteLine("Go");
                break;
        }


        // - Student Grade Classification: Ask for a student's exam score and classify it as "Fail" (below 50), "Pass" (50-69), "Merit" (70-89), or "Distinction" (90-100).
        Console.WriteLine("Enter your exam score and I will grade it:\n");
        int answer2 = Int32.Parse(Console.ReadLine());

        if (answer2 < 50)
        {
            Console.WriteLine("Fail");
        }
        else if (answer2 < 70)
        {
            Console.WriteLine("Pass");
        }
        else if (answer2 < 90)
        {
            Console.WriteLine("Merit");
        }
        else
        {
            Console.WriteLine("Distinction");
        }
        
        // SWITCH STATEMENT CHALLENGES
 
        // VOWELS
        // Write a switch statement that checks a variable char letter = 'Z'; and prints whether the letter is a vowel (a, e, i, o, u) or a consonant. 
        // If it’s not a letter, print "Not a letter."
        
        // AGE: LEVEL UP (Optional)
        // TIP: You will need to research Switch Expressions in C# to do this one
        // TIP: switch expressions are designed to return a value not execute statements (don't put `Console.WriteLine`s in it)
        
        // Write a switch statement that checks the user’s age and prints a message depending on the age group: "Child" if 12 and under”, "Teenager" if 13-17, and "Adult" if 18 or older.
        // If the age is less than 0 or a non-numeric value, print "Invalid input".

    }
}
