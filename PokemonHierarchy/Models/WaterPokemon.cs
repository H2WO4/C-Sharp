namespace PokemonHierarchy.Models;

public class WaterPokemon : Pokemon
{
    #region Properties
<<<<<<< HEAD
    private int NumberFins { get; }

    protected override double Speed
=======
    public int NumberFins { get; }

    public override double Speed
>>>>>>> 72a638710efddbfb4bebd66286a95c8274f89237
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
<<<<<<< HEAD
        Console.WriteLine($"I swim at {Speed:f2}km/h.");
=======
        Console.WriteLine($"I swim at {Speed}km/h.");
>>>>>>> 72a638710efddbfb4bebd66286a95c8274f89237
    }
    #endregion
}