using System.Text.RegularExpressions;


namespace Vache.Utils;

public static class Consts
{
    #region Regex
    /// <summary>
    /// Describes any valid IEEE floating point number
    /// </summary>
    private const string NUM_PATTERN = @"[-+]?(\d+\.?|\d*\.\d+)(e[+-]?\d+)?";

    /// <summary>
    /// Regex matching any valid IEEE floating point number
    /// </summary>
    public static readonly Regex NumberRe = new(NUM_PATTERN);

    /// <summary>
    /// Regex matching the pattern "(a, b)"
    /// </summary>
    public static readonly Regex PointRe = new($@"\({NUM_PATTERN}, ?{NUM_PATTERN}\)");

    /// <summary>
    /// Regex matching the pattern "{a, b}"
    /// </summary>
    public static readonly Regex VectorRe = new($@"\{{{NUM_PATTERN}, ?{NUM_PATTERN}\}}");

    /// <summary>
    /// Regex matching the pattern "(a, b), (c, d), ..." repeating at least thrice
    /// </summary>
    public static readonly Regex PolygonRe = new($@"^(?:\({NUM_PATTERN}, ?{NUM_PATTERN}\)(?:, ?|$)){{3,}}$");
    #endregion
}