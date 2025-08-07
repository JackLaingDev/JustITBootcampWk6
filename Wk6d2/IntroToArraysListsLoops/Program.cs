namespace IntroToArraysListsLoops;

class Program
{
    static void Main(string[] args)
    {
        int[] dailySteps = new int[3];

        dailySteps[0] = 5_000;
        dailySteps[1] = 11_000;
        dailySteps[2] = 4000;

        Console.WriteLine(string.Join(", ", dailySteps));

        string[] names = { "Jack", "Yusuf", "Ugnius" };
        Console.WriteLine(string.Join(", ", names));

        string myName = names[0];
        Console.WriteLine(myName);

        // Lists
        List<string> readingList = new List<string>();

        readingList.Add("Harry Potter");
        readingList.Add("Diary of a Wimpy Kid");

        Console.WriteLine(string.Join(", ", readingList));

    }
}
