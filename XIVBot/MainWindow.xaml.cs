using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using XIVBot.ViewModels;

namespace XIVBot;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private XIVBotViewModel _viewModel;
    
    public MainWindow()
    {
        InitializeComponent();

        _viewModel = DataContext as XIVBotViewModel ?? throw new Exception("Cannot get viewmodel");
        _viewModel.Owner = this;
    }

    private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
    {
        GetFFProcess();
    }

    private void FfProcess_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        GetFFProcess();
    }
    
    private void GetFFProcess()
    {
        var processRegex = new Regex(@"ffxiv(_d11)*");
        var process = Process.GetProcesses()
            .FirstOrDefault(p => processRegex.IsMatch(p.ProcessName));
        if (null != process)
        {
            _viewModel.ProcessLabel = $@"Connected to: {process.ProcessName} ({process.Id})";
            process.Exited += (s, args) =>
            {
                GetFFProcess();
            };
            Helper.Process = process;
        }
        else
        {
            Helper.Process = null;
            _viewModel.ProcessLabel = "Click to connect to Final Fantasy";
        }
    }
}