using DS.Models;

namespace DS;

public static class Program
{
    public static void Main(string[ ] args)
    {
        // Initialize test objects to default values
        Jockey michou = new("Michel-Marcel", 56);
        Horse  juin   = new("Une de Mai", michou) { Earnings = 0, WonRaces = 0 };
        
        // Display it
        Console.WriteLine(juin);

        // Add the test race win
        juin.AddWonRace(10_000);
        
        // Display it
        Console.WriteLine(juin);
    }
}