namespace ExceptionHandlingChallenges;

class Program
{
    static void Main(string[] args)
    {
        // Tasks:
        // Write a console application that:

        // Asks the user to enter two numbers, one after the other.
        try
        {
            Console.WriteLine("Enter 2 Numbers, press enter to submit a number");

            string answer1 = Console.ReadLine();
            string answer2 = Console.ReadLine();

            // Converts each input from a string to an integer using int.Parse() (or similar).
            int num1 = int.Parse(answer1);
            int num2 = int.Parse(answer2);

            // Divides the first number by the second and prints the result.
            decimal result = num1 / num2;
            Console.WriteLine($"{num1} divided by {num2} = {result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: One of the inputs was not a valid number: {ex.Message}");
        }
        // Catches the exception for dividing by zero.
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: You cannot divide by zero: {ex.Message}");
        }
        // A catch block to catch all other errors
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }

        // But! You must also:
        // * Use a try-catch block to handle two possible issues:
        // (1) the input is not a number
        // (2) the second number is zero
        // * Do some research to see which exeception you would use in each case
        // * Print the exception message using ex.Message

        // Check-list
        // Code compiles and runs (static void Main)
        // Console.WriteLine used
        // Try-catch block present
        // Specific exception caught (e.g. FormatException
        }
}
