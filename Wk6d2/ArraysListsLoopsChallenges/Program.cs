namespace ArraysListsLoopsChallenges;

class Program
{
    static void Main(string[] args)
    {
        // Activity Brief: Lists and Arrays

        // Part I: Array Challenges

        // Tasks
        // declare and initialise an array of 5 decimals
        decimal[] decimals = { 1.33m, 7.2m, 9.10m, 3.5m, 12.7m };

        // Print out (Console.WriteLine()) the first and last element
        Console.WriteLine($"First Element: {decimals[0]} Last Element: {decimals[4]}");

        // Print out (Console.WriteLine()) the length of your decimal array
        Console.WriteLine($"Decimals array length is: {decimals.Count()}");

        // create an array of strings
        string[] strings = ["Egg", "Milk", "Bread"];

        // Print out (Console.WriteLine()) one element, then update it (use square bracket notation) and print the whole array.​
        // TIP: Try something other than names...what about crisp flavours? Coffee beans? Beer? Pokemnon names? Characters in a book?
        Console.WriteLine(strings[1]);
        strings[1] = "Water";
        Console.WriteLine(strings[1]);

        // Part II: List Challenges

        // Tasks
        // Modify a List by Adding and Removing Elements: Create a List<int> with two numbers. Add a third number to the list, then remove the first number. Print the final contents of the list.​
        List<int> numbers = new List<int> { 9, 42 };

        numbers.Add(32);
        numbers.Remove(numbers[0]);

        Console.WriteLine(string.Join(", ", numbers));

        // Insert and Access List Elements: Create a List<char> with two letters. Insert a new letter at the beginning of the list and print the first and last elements.​
        List<char> chars = new List<char> { 'd', 'g' };
        chars.Insert(0, 'p');

        Console.WriteLine($"First Element: {chars[0]} Last Element: {chars[2]}");

        // Check for the Existence of an Element in a List: Create a List<double> with three suitable values. Check if a specific number exists in the list and print the result.​ If you wish, you could ask for user input.
        List<double> doubles = new List<double> { 3.42, 20.3, 16.9 };

        Console.WriteLine("Enter a number to see if our array contains it!");
        double answer = double.Parse(Console.ReadLine());

        if (doubles.Contains(answer))
        {
            Console.WriteLine($"Doubles contains {answer}");
        }


        // Part III: Loop Challenges

        // Tasks
        // Collect Favourite Foods (writing a while loop)
        // Ask the user to enter favorite foods one by one using a do-while loop. Add each to a list.
        // If they type "finished", break the loop
        // Print the final list after exiting the loop

        Console.WriteLine("Enter as many food items as you want, then type 'finished' to see them!");
        List<string> foods = new List<string>();

        do
        {
            string input = Console.ReadLine();

            if (input == "")
            {
                Console.WriteLine("You didn't type anything!");
            }
            else if (input == "finished")
            {
                break;
            }
            else
            {
                foods.Add(input);
                Console.WriteLine("Thankyou for your response, we have added it to our list!");
                continue;
            }
        } while (true);
        Console.WriteLine($"Here are your food items: {string.Join(", ", foods)}");

        // You are tasked with assigning students with a random superpower. 
        // Don't worry about duplicates, different students can have the same superpower. 
        // create a list of students 
        // create a list of superpowers 
        // Use the Random class to generate a random int you can use as your index to select a superpower 
        // Loop through the students, assigning random superpowers as you go . 
        // Refactor your code so that the bulk of your 'assigning superpowers' logic sits outside of Main() in its own method 
        assignPowers();
    }

    static void assignPowers()
    {
        List<string> powers = new List<string> {"Flight", "Super Strength", "Super Speed" };
        List<string> students = new List<string>{ "Max", "Zoe", "Jack"};
        Random rand = new Random();

        foreach (string student in students)
        {
            string randomPower = powers[rand.Next(powers.Count)];
            Console.WriteLine($"{student} has been assigned the super power: {randomPower}");
        }
    }
}
