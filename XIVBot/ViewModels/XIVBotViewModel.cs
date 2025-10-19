using System.ComponentModel;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using XIVBot.Services;

namespace XIVBot.ViewModels;

public class XIVBotViewModel : ObservableObject
{
    #region Private Properties

    private Random Random { get; }

    #endregion
    
    #region Fields

    private bool _spinning = false;
    private bool _afk = false;

    private readonly BackgroundWorker _afkWorker;

    private bool _afkEnabled = true;
    private bool _leftEnabled = true;
    private bool _rightEnabled = true;
    private bool _optionsEnabled = true;

    private string _afkBotText = "Start AFK Bot";
    private string _leftSpinText = "Start Spinning Left";
    private string _rightSpinText = "Start Spinning Right";
    
    private bool _updateFound = false;

    private string _processLabel = "Click to connect to Final Fantasy";

    #endregion

    #region Button Objects

    public IRelayCommand AfkBot { get; set; }
    public IRelayCommand SpinLeft { get; set; }
    public IRelayCommand SpinRight { get; set; }
    public IRelayCommand GatherBot { get; set; }
    public IRelayCommand CraftingBot { get; set; }
    public IRelayCommand MGPFarm { get; set; }
    public IRelayCommand Options { get; set; }

    #endregion

    #region Properties

    public Window Owner { get; set; }
    
    public string AfkBotText
    {
        get => _afkBotText;
        set => SetProperty(ref _afkBotText, value);
    }

    public string LeftSpinText
    {
        get => _leftSpinText;
        set => SetProperty(ref _leftSpinText, value);
    }

    public string RightSpinText
    {
        get => _rightSpinText;
        set => SetProperty(ref _rightSpinText, value);
    }

    public bool AfkEnabled
    {
        get => _afkEnabled;
        set => SetProperty(ref _afkEnabled, value);
    }

    public bool LeftEnabled
    {
        get => _leftEnabled;
        set => SetProperty(ref _leftEnabled, value);
    }

    public bool RightEnabled
    {
        get => _rightEnabled;
        set => SetProperty(ref _rightEnabled, value);
    }

    public bool OptionsEnabled
    {
        get => _optionsEnabled;
        set => SetProperty(ref _optionsEnabled, value);
    }

    public string ProcessLabel
    {
        get => _processLabel;
        set => SetProperty(ref _processLabel, value);
    }
    
    public string SettingsText
    {
        get => _updateFound ? "Settings (Update Available)" : "Settings";
    }
    
    public bool UpdateFound
    {
        get => _updateFound;
        set
        {
            if (SetProperty(ref _updateFound, value))
            {
                OnPropertyChanged(nameof(SettingsText));
            }
        }
    }

    public string BotTitle => $"XIV Bot v{Helper.BotVersion}";

    #endregion

    public XIVBotViewModel()
    {
        Random = new Random();
        
        AfkBot = new RelayCommand(StartAfkBot);
        SpinLeft = new RelayCommand(() =>
        {
            RunSpinBot(true);
        });
        SpinRight = new RelayCommand(() =>
        {
            RunSpinBot(false);
        });
        GatherBot = new RelayCommand(() =>
        {
            var bot = new GatherBot()
            {
                Owner = Owner,
            };
            bot.ShowDialog();
        });
        CraftingBot = new RelayCommand(() =>
        {
            var bot = new CraftBot()
            {
                Owner = Owner
            };
            bot.ShowDialog();
        });
        MGPFarm = new RelayCommand(() =>
        {
            var bot = new MGPBot()
            {
                Owner = Owner
            };
            bot.ShowDialog();
        });
        Options = new RelayCommand(() =>
        {
            var bot = new Options()
            {
                Owner = Owner
            };
            bot.ShowDialog();
        });
        
        _afkWorker = new BackgroundWorker()
        {
            WorkerSupportsCancellation = true
        };
        _afkWorker.DoWork += (sender, args) =>
        {
            var worker = sender as BackgroundWorker ?? throw new Exception("Cannot create afk worker");

            if (null != Helper.Process && !Helper.Process.HasExited)
            {
                while (!worker.CancellationPending)
                {
                    RunAfkBot();
                }
            }
        };

        // Check for updates on startup without blocking
        Task.Run(async () =>
        {
            try
            {
                var updateInfo = await UpdateService.CheckForUpdatesAsync();
                if (updateInfo != null)
                {
                    // Update UI on the UI thread
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        UpdateFound = true;
                    });
                }
            }
            catch (Exception ex)
            {
                // Handle any errors silently or log them
                Console.WriteLine($"Update check failed: {ex.Message}");
            }
        });
    }

    private void StartAfkBot()
    {
        if (_afk)
        {
            AfkBotText = "Start AFK Bot";
            OptionsEnabled = true;
            LeftEnabled = true;
            RightEnabled = true;
            _afkWorker.CancelAsync();
        }
        else
        {
            AfkBotText = "Stop AFK Bot";
            OptionsEnabled = false;
            LeftEnabled = false;
            RightEnabled = false;
            _afkWorker.RunWorkerAsync();
        }

        _afk = !_afk;
    }
    
    private void RunAfkBot()
    {
        var key = Helper.GetRandomKey();
        var keyCode = Helper.GetKeyCode(key);
        Helper.PressKeyForDuration(keyCode, Random.Next(500, 1500));
    }

    private void RunSpinBot(bool left)
    {
        var key = left ? Helper.Config.LeftTurn : Helper.Config.RightTurn;

        AfkEnabled = _spinning;
        
        if (_spinning)
        {
            if (left)
            {
                LeftSpinText = "Start Spinning Left";
                RightEnabled = true;
            }
            else
            {
                RightSpinText = "Start Spinning Right";
                LeftEnabled = true;
            }
            Helper.LiftKey(key);
        }
        else
        {
            if (left)
            {
                LeftSpinText = "Stop Spinning Left";
                RightEnabled = false;
            }
            else
            {
                RightSpinText = "Stop Spinning Right";
                LeftEnabled = false;
            }
            Helper.PressKey(key);
        }
        
        _spinning = !_spinning;
    }
}