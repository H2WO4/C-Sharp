using PokemonHierarchy.Models;


namespace PokemonHierarchy;

public static class Program
{
    public static void Main(string[] args)
    {
        var charmander = new LandPokemon("Charmander", 8.5, 0.65, 2);
        var vaporeon   = new WaterPokemon("Vaporeon", 29, 3);

        charmander.Display();
<<<<<<< HEAD
        charmander.Move(20);
        
        Console.WriteLine();
        
        vaporeon.Display();
        vaporeon.Move(20);
=======
        vaporeon.Display();
>>>>>>> 72a638710efddbfb4bebd66286a95c8274f89237
    }
}