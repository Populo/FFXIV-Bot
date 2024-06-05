using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using XIVBot.ViewModels;

namespace XIVBot;

public partial class CraftBot : Window
{
    private readonly CraftBotViewModel _viewModel;
    public CraftBot()
    {
        InitializeComponent();
        _viewModel = this.DataContext as CraftBotViewModel ?? throw new Exception("Cannot cast viewmodel");
    }

    private void ValidateNumberInput(object sender, TextCompositionEventArgs e)
    {
        if (string.IsNullOrEmpty(e.Text)) e.Handled = false;
        
        var regex = new Regex("[^0-9]");
        e.Handled = regex.IsMatch(e.Text);
    }

    private void TextboxLoseFocus(object sender, RoutedEventArgs e)
    {
        var box = sender as TextBox ?? throw new Exception("cannot get textbox");
        if (!string.IsNullOrWhiteSpace(box.Text)) return;
        
        if (box == DurationBox) _viewModel.Duration = 1;
        else if (box == AmountBox) _viewModel.Crafts = 1;
        
        _viewModel.UpdateTimers(_viewModel.EstimateTime());
    }

    private void TextBoxValueChanged(object sender, TextChangedEventArgs e)
    {
        if (null != _viewModel) _viewModel.UpdateTimers(_viewModel.EstimateTime());
    }
}