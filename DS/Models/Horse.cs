using System.Text;

namespace DS.Models;

public class Horse
{
    #region Backing Fields
    private double _earnings;
    #endregion

    #region Properties
    /// <summary>
    /// The jockey riding this horse
    /// </summary>
    public Jockey Rider { get; set; }

    /// <summary>
    /// The name of the horse
    /// </summary>
    public string Name { get; }

    public string CapitalName
        => $"Horse {Name.ToUpper()}";

    /// <summary>
    /// How much this horse earned during their lifetime
    /// </summary>
    /// <exception cref="ArgumentException">If the value set is negative</exception>
    public double Earnings
    {
        get => _earnings;
        set => _earnings = value >= 0
                               ? value
                               : throw new ArgumentException("Cannot be negative", nameof(value));
    }

    /// <summary>
    /// How much races were won by this horse
    /// </summary>
    public int WonRaces { get; set; }
    #endregion

    #region Constructor
    public Horse(string name, Jockey rider)
    {
        Name  = name;
        Rider = rider;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Automatically increment the number of won races, and add the earnings
    /// </summary>
    /// <param name="earnings">How much was earned by winning the race</param>
    public void AddWonRace(double earnings)
    {
        WonRaces++;
        Earnings += earnings;
    }

    public override string ToString()
    {
        StringBuilder output = new();
        output.AppendLine($"Horse {Name}");
        output.AppendLine($"Jockey: {Rider}");
        output.AppendLine($"Earnings: {Earnings:C}, {WonRaces} victories");

        return output.ToString();
    }
    #endregion
}