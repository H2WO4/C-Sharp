namespace DS.Models;

public class Jockey
{
    #region Properties
    /// <summary>
    /// The first name of the jockey
    /// </summary>
    public string FirstName { get; }

    /// <summary>
    /// How much does this jockey weights
    /// </summary>
    public int Weight { get; }
    #endregion

    #region Constructor
    public Jockey(string firstName, int weight)
    {
        FirstName = firstName;
        Weight    = weight;
    }
    #endregion

    #region Methods
    public override string ToString()
        => FirstName;
    #endregion
}