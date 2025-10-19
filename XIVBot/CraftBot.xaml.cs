using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using XIVBot.ViewModels;

namespace XIVBot;

public partial class CraftBot : Window
{
    private readonly CraftBotViewModel _viewModel;
    private DispatcherTimer _btnTimer;

    public CraftBot()
    {
        InitializeComponent();
        _viewModel = this.DataContext as CraftBotViewModel ?? throw new Exception("Cannot cast viewmodel");

        _btnTimer = new DispatcherTimer()
        {
            Interval = TimeSpan.FromMilliseconds(250),
            IsEnabled = false
        };
        _btnTimer.Tick += btnTimer_checkMacro;
    }

    private void btnTimer_checkMacro(object? sender, EventArgs e)
    {
        Craft.IsEnabled = CraftMacro.Text != string.Empty;
        if (Craft.IsEnabled) _btnTimer.Stop();
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
        else if (box == CraftMacro) _viewModel.Macro = Helper.Config.Craft;
        
        _viewModel.UpdateTimers(_viewModel.EstimateTime());
    }

    private void TextBoxValueChanged(object sender, TextChangedEventArgs e)
    {
        if (null != _viewModel) _viewModel.UpdateTimers(_viewModel.EstimateTime());
    }

    private void CraftMacro_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (_viewModel != null) _btnTimer.Start();
    }
}