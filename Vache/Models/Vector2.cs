using Vache.Interfaces;


namespace Vache.Models;

public class GeneralVector2 : I_Vector2
{
    #region Variables
    private double? _norm;
    #endregion
    
    #region Properties
    public double X { get; }

    public double Y { get; }

    public double Norm
        => _norm ??= GetNorm();
    #endregion

    #region Constructor
    public GeneralVector2(double x, double y)
    {
        X = x;
        Y = y;
    }
    #endregion

    #region Methods
    protected virtual double GetNorm()
        => Math.Sqrt(X * X + Y * Y);

    public double Scalar(I_Vector2 other)
        => X * other.X + Y * other.Y;
    #endregion
}