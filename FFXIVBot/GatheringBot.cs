using FFXIVBot.Properties;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
            ulong delay = (ulong)(numericUpDownDuration.Value * 1000);
            ulong turn = (ulong)numericUpDownTurn.Value; // already in ms
            ulong gather = (ulong)(numericUpDownGather.Value * 1000);

            if (!radioButtonNone.Checked) delay += turn;

            var oneGather = TimeSpan.FromMilliseconds(delay + gather);

            var oneThousand = oneGather * 100;
            var tenThousand = oneGather * 1000;

            string oneKMin = oneThousand.ToString("%m"),
                   oneKSec = oneThousand.ToString("%s"),
                   tenKHour = tenThousand.ToString("%h"),
                   tenKMin = tenThousand.ToString("%m"),
                   tenKSec = tenThousand.ToString("%s");

            labelxp.Text = $"{oneKMin} m, {oneKSec} s";
            labelFortyThou.Text = $"{tenKHour} h, {tenKMin} m, {tenKSec} s";
        }
    }
}
