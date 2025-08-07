namespace BandNameGenerator;

class Program
{
    static void Main(string[] args)
    {
        BandNameGenerator("Willow Park", "Banjo");
    }

    static void BandNameGenerator(string streetName, string petName)
    {
        Console.WriteLine($"Your band name is {streetName} {petName}");
    }
}
