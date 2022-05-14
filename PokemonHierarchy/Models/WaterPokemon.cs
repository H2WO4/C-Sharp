namespace PokemonHierarchy.Models;

public class WaterPokemon : Pokemon
{
    #region Properties
    public int NumberFins { get; }

    public override double Speed
        => Weight / 25d * NumberFins;
    #endregion

    #region Constructors
    public WaterPokemon(string name, double weight, int numberFins)
        : base(name, weight)
    {
        NumberFins = numberFins;
    }
    #endregion

    #region Methods
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"I have {NumberFins} fins.");
        Console.WriteLine($"I swim at {Speed}km/h.");
    }
    #endregion
}