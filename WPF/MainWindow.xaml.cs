using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

using WPF.Models;


namespace WPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }

    #region Set-Up
    private void Start(object? sender, EventArgs e)
    {
        InitCategories();
        InitElements();
    }
    
    private static void InitCategories()
    {
        _ = new Category("Primary");
        _ = new Category("Fire");
        _ = new Category("Water");
        _ = new Category("Air");
        _ = new Category("Earth");
    }

    private static void InitElements()
    {
        _ = new Element("Fire", Category.GetCategory("Primary"));
        _ = new Element("Sun", Category.GetCategory("Fire"));
    }
    #endregion
    
    #region Components Initializations
    private void ListBox1_Init(object? sender, EventArgs e)
    {
        var list = (sender as ListBox)!;

        foreach (Category category in Category.AllCategories
                                              .OrderBy(cat => cat.Name))
            list.Items.Add(category.Name);
    }
    
    private void ListBox2_Init(object? sender, EventArgs e)
    {
        var list = (sender as ListBox)!;

        for (var i = 10; i < 20; i++)
            list.Items.Add(i);
    }
    
    private void ListBox3_Init(object? sender, EventArgs e)
    {
        var list = (sender as ListBox)!;

        for (var i = 20; i < 30; i++)
            list.Items.Add(i);
    }
    
    private void ListBox4_Init(object? sender, EventArgs e)
    {
        var list = (sender as ListBox)!;

        foreach (Category category in Category.AllCategories
                                              .OrderBy(cat => cat.Name))
            list.Items.Add(category.Name);
    }

    private void TextBox_Init(object? sender, EventArgs e)
    {
        var text = (sender as TextBox)!;

        text.IsEnabled     = false;
        text.TextAlignment = TextAlignment.Center;
        
        text.Text += "\nHello";
    }
    #endregion

    private void ListBox1_Select(object sender, RoutedEventArgs e)
    {
        string selected = ListBox1.SelectedItems[0] as string
                       ?? throw new ArgumentException(nameof(selected));

        Category category = Category.AllCategories
                                    .Find(cat => cat.Name == selected)!;
        
        ListBox2.Items.Clear();
        foreach (Element element in category.Elements
                                            .OrderBy(elem => elem.Name))
            ListBox2.Items.Add(element.Name);
    }
    
    private void ListBox4_Select(object sender, RoutedEventArgs e)
    {
        string selected = ListBox4.SelectedItems[0] as string
                       ?? throw new ArgumentException(nameof(selected));

        Category category = Category.AllCategories
                                    .Find(cat => cat.Name == selected)!;
        
        ListBox3.Items.Clear();
        foreach (Element element in category.Elements
                                            .OrderBy(elem => elem.Name))
            ListBox3.Items.Add(element.Name);
    }
}