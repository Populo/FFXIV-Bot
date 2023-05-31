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
        private const int _firstWait = 500,
                          _secondWait = 1250,
                          _thirdWait = 2 * 1000; // 2 seconds

        public CraftingBot()
        {
            InitializeComponent();
            textBoxHotkey.Text = Helper.Craft.ToString();

            numericUpDownCount.ValueChanged += (s, e) => EstimateTime();
            numericUpDownDuration.ValueChanged += (s, e) => EstimateTime();
            EstimateTime();
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
            Thread.Sleep(_firstWait);
            Helper.PressKeyForDuration(zeroKey);
            Thread.Sleep(_secondWait);
            Helper.PressKeyForDuration(macroKey);
            Thread.Sleep((int)(numericUpDownDuration.Value * 1000));

            Thread.Sleep(_thirdWait);

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

        public void EstimateTime()
        {
            int remaining = _firstWait + _secondWait + _thirdWait;
            remaining += (int)(numericUpDownDuration.Value * 1000);

            remaining *= (int)numericUpDownCount.Value;

            var seconds = Math.Round((decimal)remaining / 1000, 2);

            if (seconds < 600) labelEstimate.Text = $"{seconds} seconds";
            else if (seconds < 6000) labelEstimate.Text = $"{Math.Round(seconds/60, 2)} minutes";
        }

        private void textBoxHotkey_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.craftMacro = textBoxHotkey.Text.First();
            Settings.Default.Save();
        }
    }
}