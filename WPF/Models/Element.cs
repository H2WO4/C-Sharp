namespace WPF.Models;

public class Element
{
    #region Properties
    public string Name { get; }

    public bool Revealed { get; } = false;

    public bool Primitive { get; } = false;
    #endregion

    #region Constructor
    public Element(string name, Category category)
    {
        Name = name;
        
        category.Elements.Add(this);
    }
    #endregion
}