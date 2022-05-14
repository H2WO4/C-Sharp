using System.Diagnostics.CodeAnalysis;

using Vache.Utils;


namespace Vache.Models;

public class Vector2
{
    #region Variables
    private double? _norm;
    #endregion

    #region Properties
    /// <summary>
    /// The X component of the vector
    /// </summary>
    public double X { get; }

    /// <summary>
    /// The Y component of the vector
    /// </summary>
    public double Y { get; }

    /// <summary>
    /// The norm of the vector
    /// </summary>
    public double Norm
        => _norm ??= GetNorm();
    #endregion

    #region Constructors
    public Vector2(double x, double y)
    {
        X = x;
        Y = y;
    }

    public Vector2(Point2 start, Point2 end)
    {
        X = end.X - start.X;
        Y = end.Y - start.Y;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Calculate the scalar product between this and another vector
    /// </summary>
    /// <param name="other">The other vector</param>
    /// <returns>The scalar product of the two vectors</returns>
    public double Scalar(Vector2 other)
        => X * other.X + Y * other.Y;

    /// <summary>
    /// Calculate the determinant between this and another vector
    /// </summary>
    /// <param name="other">The other vector</param>
    /// <returns>The determinant of the two vectors</returns>
    public double Determinant(Vector2 other)
        => X * other.Y - other.X * Y;

    /// <summary>
    /// Calculate the norm of the vector
    /// </summary>
    /// <returns>The norm of the vector</returns>
    private double GetNorm()
        => Math.Sqrt(X * X + Y * Y);

    /// <summary>
    /// Parse a string into a vector object
    /// </summary>
    /// <param name="input">The string to parse</param>
    /// <returns>The parsed vector</returns>
    /// <exception cref="ArgumentException">If the input string is not parseable</exception>
    public static Vector2 Parse(string input)
    {
        // Check whether the input string match the format
        if (Consts.VectorRe.IsMatch(input) is false)
            throw new ArgumentException("Invalid format", nameof(input));

        // Extract the numerical values and put them into an array
        double[] components = Consts.NumberRe.Matches(input)
                                    .Select(match => double.Parse(match.Value))
                                    .ToArray();

        // Since the 1st regex ensures only 2 values, we can address them directly
        return new Vector2(components[0], components[1]);
    }

    /// <summary>
    /// Try to parse a string into a vector object
    /// </summary>
    /// <param name="input">The string to parse</param>
    /// <param name="output">The parsed vector</param>
    /// <returns>Whether the parsing succeeded</returns>
    public static bool TryParse(string input, [NotNullWhen(true)] out Vector2? output)
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
        => $"{{{X}, {Y}}}";
    #endregion

    #region Operators
    public static Vector2 operator +(Vector2 fst, Vector2 snd)
        => new(fst.X + snd.X, fst.Y + snd.Y);

    public static Vector2 operator -(Vector2 fst, Vector2 snd)
        => new(fst.X - snd.X, fst.Y - snd.Y);

    public static Vector2 operator *(Vector2 vec, double k)
        => new(vec.X * k, vec.Y * k);

    public static Vector2 operator /(Vector2 vec, double k)
        => new(vec.X / k, vec.Y / k);

    public static Vector2 operator -(Vector2 vec)
        => new(-vec.X, -vec.Y);

    public static bool operator ==(Vector2? fst, Vector2? snd)
        => fst is null == snd is null || fst?.Equals(snd) is true;
    
    public static bool operator !=(Vector2? fst, Vector2? snd)
        => fst is null != snd is null || fst?.Equals(snd) is false;

    public override bool Equals(object? obj)
    {
        if (obj is Vector2 other)
            return X - other.X is < 1e-10 and > -1e-10
                && Y - other.Y is < 1e-10 and > -1e-10;

        return false;
    }

    public override int GetHashCode()
        => HashCode.Combine(X, Y);
    #endregion
}