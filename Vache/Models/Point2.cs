using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

using Vache.Utils;


namespace Vache.Models;

public class Point2
{
    #region Properties
    /// <summary>
    /// The coordinate on the X axis
    /// </summary>
    public double X { get; }

    /// <summary>
    /// The coordinate on the Y axis
    /// </summary>
    public double Y { get; }
    #endregion

    #region Constructor
    public Point2(double x, double y)
    {
        X = x;
        Y = y;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Translate a point along a vector
    /// </summary>
    /// <param name="vec">The vector to translate along</param>
    /// <returns>A new point at the corresponding coordinates</returns>
    [Pure]
    public Point2 Translate(Vector2 vec)
        => new(X + vec.X, Y + vec.Y);

    /// <summary>
    /// Parse a string into a point object
    /// </summary>
    /// <param name="input">The string to parse</param>
    /// <returns>The parsed point</returns>
    /// <exception cref="ArgumentException">If the input string is not parseable</exception>
    public static Point2 Parse(string input)
    {
        // Check whether the input string match the format
        if (Consts.PointRe.IsMatch(input) is false)
            throw new ArgumentException("Invalid format", nameof(input));

        // Extract the numerical values and put them into an array
        double[] components = Consts.NumberRe.Matches(input)
                                    .Select(match => double.Parse(match.Value))
                                    .ToArray();

        // Since the 1st regex ensures only 2 values, we can address them directly
        return new Point2(components[0], components[1]);
    }

    /// <summary>
    /// Try to parse a string into a point object
    /// </summary>
    /// <param name="input">The string to parse</param>
    /// <param name="output">The parsed point</param>
    /// <returns>Whether the parsing succeeded</returns>
    public static bool TryParse(string input, [NotNullWhen(true)] out Point2? output)
    {
        try
        {
            output = Parse(input);

            return true;
        }
        catch (ArgumentException)
        {
            output = null;

            return false;
        }
    }

    public override string ToString()
        => $"({X}, {Y})";
    #endregion

    #region Operators
    public static bool operator ==(Point2? fst, Point2? snd)
        => fst is null == snd is null || fst?.Equals(snd) is true;

    public static bool operator !=(Point2? fst, Point2? snd)
        => fst is null != snd is null || fst?.Equals(snd) is false;

    public override bool Equals(object? obj)
    {
        if (obj is Point2 other)
            return X - other.X is < 1e-10 and > -1e-10
                && Y - other.Y is < 1e-10 and > -1e-10;

        return false;
    }

    public override int GetHashCode()
        => HashCode.Combine(X, Y);
    #endregion
}