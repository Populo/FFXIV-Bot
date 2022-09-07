using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFXIVBot
{
    public partial class Bot : Form
    {
        public static Version Version = new Version(1, 0);
        
        private bool Running { get; set; }
        
        private Random Random { get; set; }

        public Bot()
        {
            InitializeComponent();

            Random = new Random();

            Running = false;

            Text = $"FFXIV Bot v{Version}";
            
            labelProcess_Click(this, EventArgs.Empty);
        }

        private void labelProcess_Click(object sender, EventArgs e)
        {
            Regex processRegex = new Regex(@"ffxiv(_d11)*");
            var process = Process.GetProcesses().FirstOrDefault(p => processRegex.IsMatch(p.ProcessName));
            if (null != process)
            {
                labelProcess.Text = $"Connected to: {process.ProcessName} ({process.Id})";
                Helper.Process = process;
            }
            else
            {
                Helper.Process = null;
                labelProcess.Text = "Click to connect to Final Fantasy";
            }
        }

        private void buttonSpinner_Click(object sender, EventArgs e)
        {
            Spinner spin = new Spinner();
            spin.ShowDialog();
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            var Controls = new Controls();
            Controls.ShowDialog();
        }

        private void buttonAFK_Click(object sender, EventArgs e)
        {
            if (Running)
            {
                buttonAFK.Text = "Start AFK Bot";
                buttonOptions.Enabled = true;
                buttonSpinner.Enabled = true;
                backgroundWorkerAfkBot.CancelAsync();
            }
            else
            {
                buttonAFK.Text = "Stop AFK Bot";
                buttonOptions.Enabled = false;
                buttonSpinner.Enabled = false;
                backgroundWorkerAfkBot.RunWorkerAsync();
            }

            Running = !Running;
        }

        private void backgroundWorkerAfkBot_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            if (null != Helper.Process && !Helper.Process.HasExited)
            {
                while (!worker.CancellationPending)
                {
                    RunAfkBot();
                }
            }
        }

        private void RunAfkBot()
        {
            var key = Helper.GetRandomKey();
            var keyCode = Helper.GetKeyCode(key);
            Helper.PressKeyForDuration(Random.Next(500, 1500), keyCode);
        }
    }
}