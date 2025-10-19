using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Velopack;
using XIVBot.Services;

namespace XIVBot.ViewModels;

public class OptionsViewModel : ObservableObject
{
    #region Text Fields
    
    private string _updateLabel = "Check for updates";
    
    public string UpdateButtonText
    {
        get => _updateLabel;
        set => SetProperty(ref _updateLabel, value);
    }
    
    #endregion
    
    #region Buttons
    
    public IRelayCommand SaveButton { get; set; }
    public IRelayCommand UpdateButton { get; set; }

    private UpdateInfo? _updateInfo { get; set; }
    
    #endregion
    
    #region Text Properties

    public char Forward
    {
        get => Helper.Config.Forward;
        set => Helper.Config.Forward = value.ToString().ToUpper()[0];
    }

    public char Backward
    {
        get => Helper.Config.Backward;
        set => Helper.Config.Backward = value.ToString().ToUpper()[0];
    }

    public char MoveLeft
    {
        get => Helper.Config.MoveLeft;
        set => Helper.Config.MoveLeft = value.ToString().ToUpper()[0];
    }

    public char MoveRight
    {
        get => Helper.Config.MoveRight;
        set => Helper.Config.MoveRight = value.ToString().ToUpper()[0];
    }

    public char LeftTurn
    {
        get => Helper.Config.LeftTurn;
        set => Helper.Config.LeftTurn = value.ToString().ToUpper()[0];
    }
    
    public char RightTurn
    {
        get => Helper.Config.RightTurn;
        set => Helper.Config.RightTurn = value.ToString().ToUpper()[0];
    }
    
    public char Jump
    {
        get => Helper.Config.Jump;
        set => Helper.Config.Jump = value.ToString().ToUpper()[0];
    }
    
    public char Gather
    {
        get => Helper.Config.Gather;
        set => Helper.Config.Gather = value.ToString().ToUpper()[0];
    }
    
    public char Craft
    {
        get => Helper.Config.Craft;
        set => Helper.Config.Craft = value.ToString().ToUpper()[0];
    }
    #endregion


    public OptionsViewModel()
    {
        SaveButton = new RelayCommand<Window>((window) =>
        {
            Helper.WriteConfig();
            MessageBox.Show("Config Saved");

            window?.Close();
        });
        
        UpdateButton = new AsyncRelayCommand<Window>(async (window) =>
        {
            if (null == _updateInfo)
            {
                UpdateButtonText = "Checking for updates...";
                _updateInfo = await UpdateService.CheckForUpdatesAsync();
                UpdateButtonText = null != _updateInfo ? $"Click to update ({_updateInfo.TargetFullRelease.Version})" : "No updates available";
            }
            else
            {
                await UpdateService.UpdateAppAsync(_updateInfo);
            }
        });
    }
}