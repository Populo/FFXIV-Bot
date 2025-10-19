using System.ComponentModel;
using System.Windows.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace XIVBot.ViewModels;

public class CraftBotViewModel : ObservableObject
{
    private int _duration = 30;
    private int _crafts = 1;
    private string _timer = "0h 0m 34s";
    private string _buttonText = "Start Crafting";
    private char _macro = '[';
    
    public IRelayCommand CraftButton { get; set; }
    public IRelayCommand DurationUp { get; set; }
    public IRelayCommand DurationDown { get; set; }
    public IRelayCommand CraftsUp { get; set; }
    public IRelayCommand CraftsDown { get; set; }

    private bool _running = false;
    private const int
        FirstWait = 500,
        SecondWait = 1500,
        ThirdWait = (int)(2.5 * 1000); // 2 seconds
    private readonly BackgroundWorker _craftWorker;

    public CraftBotViewModel()
    {
        _craftWorker = new BackgroundWorker
        {
            WorkerSupportsCancellation = true
        };
        _craftWorker.DoWork += (sender, args) =>
        {
            var worker = sender as BackgroundWorker ?? throw new Exception("Cannot get worker");

            if (null == Helper.Process || Helper.Process.HasExited) return;
            while (!worker.CancellationPending)
            {
                RunBot();
            }
        };

        CraftButton = new RelayCommand(StartCraftBot);
        DurationUp = new RelayCommand(() =>
        {
            ++Duration;
            UpdateTimers(EstimateTime());
        });
        CraftsUp = new RelayCommand(() =>
        {
            ++Crafts;
            UpdateTimers(EstimateTime());
        });
        DurationDown = new RelayCommand(() =>
        {
            if (_duration > 0) --Duration;
            UpdateTimers(EstimateTime());
        });
        CraftsDown = new RelayCommand(() =>
        {
            if (_crafts > 0) --Crafts;
            UpdateTimers(EstimateTime());
        });

        UpdateTimers(EstimateTime());
    }

    public int Duration
    {
        get => _duration;
        set => SetProperty(ref _duration, value);
    }
    public int Crafts
    {
        get => _crafts;
        set => SetProperty(ref _crafts, value);
    }
    public string Timer
    {
        get => _timer;
        set => SetProperty(ref _timer, value);
    }
    public string Button
    {
        get => _buttonText;
        set => SetProperty(ref _buttonText, value);
    }
    public char Macro
    {
        get => Helper.Config.Craft;
        set {
            if (value.ToString() == string.Empty) _macro = Helper.Config.Craft;
            else
            {
                var c = value.ToString().ToUpper()[0];
                SetProperty(ref _macro, c);
                Helper.Config.Craft = c;
            }
        }
    }

    public void UpdateTimers(TimeSpan time)
    {
        string hours = $"{time:%h}",
            minutes = $"{time:%m}",
            seconds = $"{time:%s}";

        Timer = $"{hours} h, {minutes} m, {seconds} s";
    }

    public TimeSpan EstimateTime()
    {
        ulong remaining = FirstWait + SecondWait + ThirdWait;

        remaining += (ulong)(Duration * 1000);

        remaining *= (ulong)Crafts;

        return TimeSpan.FromMilliseconds(remaining);
    }

    private void StartCraftBot()
    {
        if (_running)
        {
            Helper.AllowSleep();
            Button = "Start Crafting";
            _craftWorker.CancelAsync();
        }
        else
        {
            Helper.PreventSleep();
            Button = "Stop Crafting";
            _craftWorker.RunWorkerAsync();
        }

        _running = !_running;
    }

    private void RunBot()
    {
        if (Crafts <= 0)
        {
            StartCraftBot();
            return;
        }

        var zeroKey = Helper.NumpadZero;
        var macroKey = Helper.GetKeyCode(Helper.Config.Craft);

        Helper.PressKeyForDuration(zeroKey);
        Thread.Sleep(FirstWait);
        Helper.PressKeyForDuration(zeroKey);
        Thread.Sleep(SecondWait);
        Helper.PressKeyForDuration(macroKey);
        Thread.Sleep(_duration * 1000);

        Helper.PressKeyForDuration(Helper.NumpadZero);
        Thread.Sleep(ThirdWait);

        --Crafts;
    }

}
