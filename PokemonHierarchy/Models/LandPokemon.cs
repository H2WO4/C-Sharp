namespace PokemonHierarchy.Models;

public class LandPokemon : Pokemon
{
    #region Properties
    public double Height { get; }

    public int NumberLegs { get; }

    public override double Speed
        => NumberLegs * Height * 3;
    #endregion

    #region Constructor
    public LandPokemon(string name, double weight, double height, int numberLegs)
        : base(name, weight)
    {
        Height     = height;
        NumberLegs = numberLegs;
    }
    #endregion

    #region Methods
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"I have {NumberLegs} legs.");
        Console.WriteLine($"I am {Height} tall and run at {Speed}km/h.");
    }
    #endregion
}