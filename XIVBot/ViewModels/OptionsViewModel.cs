using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace XIVBot.ViewModels;

public class OptionsViewModel : ObservableObject
{
    #region Text Fields
    
    #endregion
    
    #region Buttons
    
    public IRelayCommand SaveButton { get; set; }
    public IRelayCommand CancelButton { get; set; }
    
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

    public Options OptionsWindow { get; set; }

    public OptionsViewModel()
    {
        SaveButton = new RelayCommand(() =>
        {
            Helper.WriteConfig();
            MessageBox.Show("Config Saved");
            
            if (null != OptionsWindow) OptionsWindow.Close();
        });
        CancelButton = new RelayCommand(() =>
        {
            Helper.Config = Config.LoadConfig();
            
            if (null != OptionsWindow) OptionsWindow.Close();
        });
    }
}