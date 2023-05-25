using System;
using System.ComponentModel;
using System.Configuration;
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

            Thread.Sleep(3 * 1000);

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
            ConfigurationManager.AppSettings["gatherMacro"] = textBoxHotkey.Text;
        }
    }
}
