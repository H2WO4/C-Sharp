namespace PokemonHierarchy.Models;

public abstract class Pokemon
{
    #region Properties
    public string Name { get; }
    
    public double Weight { get; }
    
    public abstract double Speed { get; }
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
        Console.WriteLine($"I weigh {Weight}.");
    }
    #endregion
}