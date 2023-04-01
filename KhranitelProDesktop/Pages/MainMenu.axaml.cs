using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace KhranitelProDesktop.Pages;

public partial class MainMenu : UserControl
{
    public MainMenu()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}