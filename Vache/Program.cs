using System.Diagnostics.CodeAnalysis;

using Vache.Models;


namespace Vache;

public static class Program
{
    public const double TOLERANCE = 1e-2;

    [ExcludeFromCodeCoverage]
    public static void Main(string[] args)
    {
        // Ask the user to define the field
        Polygon2 field = Polygon2.FromInput();

        // Display all the infos about said field
        Console.WriteLine($"The area of the field is: {field.Area}");
        Console.WriteLine($"It's center of gravity is at: {field.CenterOfGravity}");
        Console.WriteLine(field.IsPointInside(field.CenterOfGravity)
                              ? "The cow is still in the field!"
                              : "The cow is outside of the field...");
    }
}
