namespace PokemonHierarchy.Models;

public class WaterPokemon : Pokemon
{
    #region Properties
    private int NumberFins { get; }

    protected override double Speed
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
        Console.WriteLine($"I swim at {Speed:f2}km/h.");
    }
    #endregion
}