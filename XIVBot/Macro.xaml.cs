using System.Windows;

namespace XIVBot;

public partial class Macro : Window
{
    public string MacroText { get; set; }
    public Macro()
    {
        InitializeComponent();
    }

    private void Macro_OnLoaded(object sender, RoutedEventArgs e)
    {
        MacroBox.Text = MacroText;
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        Clipboard.SetDataObject(MacroText);
    }
}