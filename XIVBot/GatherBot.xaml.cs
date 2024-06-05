using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using XIVBot.ViewModels;

namespace XIVBot
{
    /// <summary>
    /// Interaction logic for GatherBot.xaml
    /// </summary>
    public partial class GatherBot : Window
    {
        private readonly GatherBotViewModel _viewModel;
        
        public GatherBot()
        {
            InitializeComponent();
            
            _viewModel = DataContext as GatherBotViewModel ?? throw new Exception("Cannot get model");
            _viewModel.Owner = this;
        }
        
        private void ValidateNumberInput(object sender, TextCompositionEventArgs e)
        {
            var box = sender as TextBox ?? throw new Exception("cannot get textbox");
            
            var regex = new Regex("^[0-9]*(\\.[0-9]*)?$");
            if (!regex.IsMatch(box.Text.Insert(box.SelectionStart, e.Text)))
                e.Handled = true;
        }
        
        private void TextChangeHandler(object sender, TextChangedEventArgs e)
        {
            if (null != _viewModel) _viewModel.CalculateTime();
        }

        private void TextboxLoseFocus(object sender, RoutedEventArgs e)
        {
            var box = sender as TextBox ?? throw new Exception("cannot get textbox");
            if (!string.IsNullOrWhiteSpace(box.Text)) return;
            
            if (box == SprintBox) _viewModel.SprintTime = 1;
            else if (box == GatherBox) _viewModel.GatherTime = 1;
        
            _viewModel.CalculateTime();
        }
    }
}
