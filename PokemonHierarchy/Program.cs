using PokemonHierarchy.Models;


namespace PokemonHierarchy;

public static class Program
{
    public static void Main(string[] args)
    {
        var charmander = new LandPokemon("Charmander", 8.5, 0.65, 2);
        var vaporeon   = new WaterPokemon("Vaporeon", 29, 3);

        charmander.Display();
        charmander.Move(20);
        
        Console.WriteLine();
        
        vaporeon.Display();
        vaporeon.Move(20);
    }
}