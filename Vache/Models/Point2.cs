using Vache.Interfaces;


namespace Vache.Models;

public class GeneralPoint2 : I_Point2
{
    #region Properties
    public double X { get; }

    public double Y { get; }
    #endregion

    #region Constructor
    public GeneralPoint2(double x, double y)
    {
        X = x;
        Y = y;
    }
    #endregion
}