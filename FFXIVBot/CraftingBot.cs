using FFXIVBot.Properties;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace FFXIVBot
{
    public partial class CraftingBot : Form
    {
        private bool Running = false;
        
        public CraftingBot()
        {
            InitializeComponent();
            textBoxHotkey.Text = Helper.Craft.ToString();
        }

        private void backgroundWorkerCraftBot_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            if (null != Helper.Process && !Helper.Process.HasExited)
            {
                while (!worker.CancellationPending)
                {
                    RunBot();
                    Helper.PressKeyForDuration(Helper.NumpadZero);
                }
            }
        }

        private void RunBot()
        {
            if (numericUpDownCount.Value <= 0)
            {
                buttonCraft_Click(null, null);
                return;
            }
                        
            var zeroKey = Helper.NumpadZero;
            var macroKey = Helper.GetKeyCode(Helper.Craft);

            Helper.PressKeyForDuration(zeroKey);
            Thread.Sleep(500);
            Helper.PressKeyForDuration(zeroKey);
            Thread.Sleep(1250);
            Helper.PressKeyForDuration(macroKey);
            Thread.Sleep((int)(numericUpDownDuration.Value * 1000));
            
            Thread.Sleep(2 * 1000);
            
            numericUpDownCount.Value -= 1;
        }

        private void buttonCraft_Click(object sender, EventArgs e)
        {
            if (Running)
            {
                Helper.AllowSleep();
                buttonCraft.Text = "Start Crafting";
                backgroundWorkerCraftBot.CancelAsync();
            }
            else
            {
                Helper.PreventSleep();
                buttonCraft.Text = "Stop Crafting";
                backgroundWorkerCraftBot.RunWorkerAsync();
            }

            Running = !Running;
        }

        private void textBoxHotkey_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.craftMacro = textBoxHotkey.Text.First();
            Settings.Default.Save();
        }
    }
}