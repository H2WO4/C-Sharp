namespace PokemonHierarchy.Models;

public abstract class Pokemon
{
    #region Properties
    private string Name { get; }

    protected double Weight { get; }

    protected abstract double Speed { get; }
    #endregion

    #region Constructor
    public Pokemon(string name, double weight)
    {
        Name   = name;
        Weight = weight;
    }
    #endregion

    #region Methods
    public virtual void Display()
    {
        Console.WriteLine($"My name is {Name}.");
        Console.WriteLine($"I weigh {Weight}kg.");
    }

    public void Move(int minutes)
    {
        switch (this)
        {
            case LandPokemon:
                Console.WriteLine($"I walked {minutes / 60d * Speed:f2}km in {minutes} minutes.");

                break;

            case WaterPokemon:
                Console.WriteLine($"I swam {minutes / 60d * Speed:f2}km in {minutes} minutes.");

                break;
        }
    }
    #endregion
}