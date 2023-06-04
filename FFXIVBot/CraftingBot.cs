using FFXIVBot.Properties;
using System;
using System.ComponentModel;
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

            numericUpDownCount.ValueChanged += (s, e) => UpdateTimers(EstimateTime());
            numericUpDownDuration.ValueChanged += (s, e) => UpdateTimers(EstimateTime());
            UpdateTimers(EstimateTime());
        }

        private void backgroundWorkerCraftBot_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            if (null != Helper.Process && !Helper.Process.HasExited)
            {
                while (!worker.CancellationPending)
                {
                    RunBot();
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

            Helper.PressKeyForDuration(Helper.NumpadZero);
            Thread.Sleep(_thirdWait);

            numericUpDownCount.DownButton();
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

        public void UpdateTimers(TimeSpan time)
        {
            string hours = time.ToString("%h"),
                   minutes = time.ToString("%m"),
                   seconds = time.ToString("%s");

            string format = $"{hours} h, {minutes} m, {seconds} s";

            labelTotal.Text = format;
        }

        public TimeSpan EstimateTime()
        {
            ulong remaining = _firstWait + _secondWait + _thirdWait;
            remaining += (ulong)(numericUpDownDuration.Value * 1000);

            remaining *= (ulong)numericUpDownCount.Value;

            return TimeSpan.FromMilliseconds(remaining);
        }

        private void textBoxHotkey_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.craftMacro = textBoxHotkey.Text.First();
            Settings.Default.Save();
        }
    }
}