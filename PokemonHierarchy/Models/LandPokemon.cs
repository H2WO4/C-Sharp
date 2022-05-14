namespace PokemonHierarchy.Models;

public class LandPokemon : Pokemon
{
    #region Properties
<<<<<<< HEAD
    private double Height { get; }

    private int NumberLegs { get; }

    protected override double Speed
=======
    public double Height { get; }

    public int NumberLegs { get; }

    public override double Speed
>>>>>>> 72a638710efddbfb4bebd66286a95c8274f89237
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
<<<<<<< HEAD
        Console.WriteLine($"I am {Height:f2}m tall and run at {Speed:f2}km/h.");
=======
        Console.WriteLine($"I am {Height} tall and run at {Speed}km/h.");
>>>>>>> 72a638710efddbfb4bebd66286a95c8274f89237
    }
    #endregion
}