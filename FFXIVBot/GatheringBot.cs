using FFXIVBot.Properties;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace FFXIVBot
{
    public partial class GatheringBot : Form
    {
        private bool Running = false;

        public GatheringBot()
        {
            InitializeComponent();
            textBoxHotkey.Text = Helper.Gather.ToString();

            CalculateTime();
            numericUpDownDuration.ValueChanged += (e, s) => CalculateTime();
            numericUpDownTurn.ValueChanged += (e, s) => CalculateTime();
            numericUpDownGather.ValueChanged += (e, s) => CalculateTime();
            radioButtonLeft.CheckedChanged += (e, s) => CalculateTime();
            radioButtonNone.CheckedChanged += (e, s) => CalculateTime();
            radioButtonRight.CheckedChanged += (e, s) => CalculateTime();
        }

        private void backgroundWorkerGatherBot_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
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
            var zeroKey = Helper.NumpadZero;
            var macroKey = Helper.GetKeyCode(Helper.Gather);

            Helper.PressKeyForDuration(macroKey);
            Thread.Sleep((int)(numericUpDownDuration.Value * 1000));
            Helper.PressKeyForDuration(zeroKey);

            Thread.Sleep((int)numericUpDownGather.Value * 1000);

            if (radioButtonNone.Checked) return;

            char key = ' ';

            if (radioButtonLeft.Checked)
            {
                key = Helper.LeftTurn;
            }
            else if (radioButtonRight.Checked)
            {
                key = Helper.RightTurn;
            }

            Helper.PressKeyForDuration(Helper.GetKeyCode(key), (int)numericUpDownDuration.Value);
        }

        private void buttonGather_Click(object sender, EventArgs e)
        {
            if (Running)
            {
                Helper.AllowSleep();
                buttonGather.Text = "Start Gathering";
                backgroundWorkerGatherBot.CancelAsync();
            }
            else
            {
                Helper.PreventSleep();
                buttonGather.Text = "Stop Gathering";
                backgroundWorkerGatherBot.RunWorkerAsync();
            }

            Running = !Running;
        }

        private void textBoxHotkey_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.gatherMacro = textBoxHotkey.Text.First();
            Settings.Default.Save();
        }

        private void CalculateTime()
        {
            var delay = numericUpDownDuration.Value * 1000;
            var turn = numericUpDownTurn.Value; // already in ms

            var fullTime = delay + (int)numericUpDownGather.Value * 1000; // x ms for 10 xp
            if (!radioButtonNone.Checked) fullTime += turn;


            var thousandXp = fullTime * 100; // 100 * 10 = 1000
            var seconds = thousandXp / 1000;
            seconds = Math.Round(seconds, 2);

            var fortyk = fullTime * 4500; // 10xp * 4500 gathers = 45,000xp
            var minutes = fortyk / 60000; // 60s * 1000ms
            minutes = Math.Round(minutes, 2);


            labelxp.Text = $"{seconds} seconds";
            labelFortyThou.Text = $"{minutes} minutes";
        }
    }
}
