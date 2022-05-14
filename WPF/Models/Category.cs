<<<<<<< HEAD
﻿using System.Collections.Generic;


namespace WPF.Models;

public class Category
{
    #region Variables
    public static readonly List<Category> AllCategories = new();
    #endregion

    #region Properties
    public string Name { get; }

    public List<Element> Elements { get; } = new();
    #endregion

    #region Constructor
    public Category(string name)
    {
        Name = name;
        
        AllCategories.Add(this);
    }
    #endregion

    #region Methods
    public static Category GetCategory(string name)
        => AllCategories.Find(cat => cat.Name == name)!;
    #endregion
=======
﻿namespace WPF.Models;

public class Category
{
    
>>>>>>> 72a638710efddbfb4bebd66286a95c8274f89237
}