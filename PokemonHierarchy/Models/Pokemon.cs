namespace PokemonHierarchy.Models;

public abstract class Pokemon
{
    #region Properties
<<<<<<< HEAD
    private string Name { get; }

    protected double Weight { get; }

    protected abstract double Speed { get; }
=======
    public string Name { get; }
    
    public double Weight { get; }
    
    public abstract double Speed { get; }
>>>>>>> 72a638710efddbfb4bebd66286a95c8274f89237
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
<<<<<<< HEAD
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
=======
        Console.WriteLine($"I weigh {Weight}.");
>>>>>>> 72a638710efddbfb4bebd66286a95c8274f89237
    }
    #endregion
}