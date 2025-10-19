using System.Windows;
using Velopack;

namespace XIVBot;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
/// 
public partial class App : Application
{
    [STAThread]
    private static void Main(string[] args)
    {
        VelopackApp.Build().Run();
        App app = new();
        app.InitializeComponent();
        app.Run();
    }
}