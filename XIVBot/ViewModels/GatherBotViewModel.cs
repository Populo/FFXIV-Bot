using System.ComponentModel;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace XIVBot.ViewModels;

public class GatherBotViewModel : ObservableObject
{
    #region Fields
    private double _sprintTime = 1.50;
    private double _gatherTime = 2.50;
    private string _oneK = "0h 0m 34s";
    private string _tenK = "0h 0m 32s";
    private int _timesGathered = 0;
    private string _buttonText = "Start Gathering";

    private readonly BackgroundWorker _worker;
    private bool _running = false;

    private string _macroText = @"/merror off
/micon ""Duty Action I""
/targetnpc
/ac ""Duty Action I""
/lockon
/automove";

    public Window Owner { get; set; }
    #endregion

    #region Text Properties
    public char Macro
    {
        get => Helper.Config.Craft;
    }
    
    public double SprintTime
    {
        get => _sprintTime;
        set => SetProperty(ref _sprintTime, Math.Round(value, 3));
    }
    
    public double GatherTime
    {
        get => _gatherTime;
        set => SetProperty(ref _gatherTime, Math.Round(value, 3));
    }

    public string OneK
    {
        get => _oneK;
        set => SetProperty(ref _oneK, value);
    }

    public string TenK
    {
        get => _tenK;
        set => SetProperty(ref _tenK, value);
    }

    public int TimesGathered
    {
        get => _timesGathered;
        set => SetProperty(ref _timesGathered, value);
    }

    public string ButtonText
    {
        get => _buttonText;
        set => SetProperty(ref _buttonText, value);
    }
    #endregion

    #region Button Properties

    public IRelayCommand SprintUp { get; set; }
    public IRelayCommand SprintDown { get; set; }
    public IRelayCommand GatherUp { get; set; }
    public IRelayCommand GatherDown { get; set; }
    public IRelayCommand GetMacro { get; set; }
    public IRelayCommand GatherButton { get; set; }

    #endregion

    public GatherBotViewModel()
    {
        SprintUp = new RelayCommand(() =>
        {
            SprintTime += 0.1;
            CalculateTime();
        });
        SprintDown = new RelayCommand(() =>
        {
            if (SprintTime >= 0.1) SprintTime -= 0.1;
            CalculateTime();
        });
        GatherUp = new RelayCommand(() =>
        {
            GatherTime += 0.1;
            CalculateTime();
        });
        GatherDown = new RelayCommand(() =>
        {
            if (GatherTime >= 0.1) GatherTime -= 0.1;
            CalculateTime();
        });
        GatherButton = new RelayCommand(StartBot);
        GetMacro = new RelayCommand(() =>
        {
            var bot = new Macro()
            {
                Owner = Owner
            };
            bot.MacroText = _macroText;
            bot.ShowDialog();
        });

        _worker = new BackgroundWorker()
        {
            WorkerSupportsCancellation = true
        };
        _worker.DoWork += (sender, args) =>
        {
            var worker = sender as BackgroundWorker ?? throw new Exception("Cannot get worker");

            if (null == Helper.Process || Helper.Process.HasExited) return;
            while (!worker.CancellationPending)
            {
                RunBot();
            }
        };
        
        CalculateTime();
    }
    
    private void RunBot()
    {
        var zeroKey = Helper.NumpadZero;
        var macroKey = Helper.GetKeyCode(Helper.Config.Gather);

        Helper.PressKeyForDuration(macroKey);
        Thread.Sleep((int)(SprintTime * 1000));
        Helper.PressKeyForDuration(zeroKey);

        Thread.Sleep((int)(GatherTime * 1000));

        ++TimesGathered;
    }

    private void StartBot()
    {
        if (_running)
        {
            Helper.AllowSleep();
            ButtonText = "Start Gathering";
            _worker.CancelAsync();
        }
        else
        {
            TimesGathered = 0;
            Helper.PreventSleep();
            ButtonText = "Stop Gathering";
            _worker.RunWorkerAsync();
        }

        _running = !_running;
    }
    
    public void CalculateTime()
    {
        ulong delay = (ulong)(SprintTime * 1000);
        ulong gather = (ulong)(GatherTime * 1000);

        var oneGather = TimeSpan.FromMilliseconds(delay + gather);

        var oneThousand = oneGather * 100;
        var tenThousand = oneGather * 1000;

        string oneKMin = oneThousand.ToString("%m"),
            oneKSec = oneThousand.ToString("%s"),
            tenKHour = tenThousand.ToString("%h"),
            tenKMin = tenThousand.ToString("%m"),
            tenKSec = tenThousand.ToString("%s");

        OneK = $"{oneKMin} m, {oneKSec} s";
        TenK = $"{tenKHour} h, {tenKMin} m, {tenKSec} s";
    }
}