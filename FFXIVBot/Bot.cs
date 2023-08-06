using FFXIVBot.Properties;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

[assembly: AssemblyVersion("2023.8.6.1")]
namespace FFXIVBot
{
    public partial class Bot : Form
    {
        public static Version Version;
        private SettingsBackup _settings { get; set; }
        private string jsonPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\FFXIVBot\\";
        private string jsonFile = "backup.json";
        private string fullJson => jsonPath + jsonFile;


        private bool Running { get; set; }
        
        private Random Random { get; set; }

        public Bot()
        {
            Version = typeof(Bot).Assembly.GetName().Version;

            InitializeComponent();

            Random = new Random();

            Running = false;

            Text = $"FFXIV Bot v{Version}";
            
            labelProcess_Click(this, EventArgs.Empty);

            FormClosing += Bot_FormClosing;

            _settings = Helper.SettingsObject;

            if (File.Exists(fullJson))
            {
                var oldSettings = JsonConvert.DeserializeObject<SettingsBackup>(File.ReadAllText(fullJson));

                if (oldSettings.Version < Version)
                {
                    Settings.Default.turnLeft = oldSettings.LeftTurn;
                    Settings.Default.turnRight = oldSettings.RightTurn;
                    Settings.Default.moveLeft = oldSettings.MoveLeft;
                    Settings.Default.moveRight = oldSettings.MoveRight;
                    Settings.Default.forward = oldSettings.Forward;
                    Settings.Default.back = oldSettings.Backward;
                    Settings.Default.craftMacro = oldSettings.Craft;
                    Settings.Default.gatherMacro = oldSettings.Gather;

                    Settings.Default.Save();

                    oldSettings.Version = Version;

                    _settings = oldSettings;
                }
            }
        }

        private void Bot_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Directory.Exists(jsonPath)) Directory.CreateDirectory(jsonPath);

            _settings = Helper.SettingsObject;
            File.WriteAllTextAsync(fullJson, JsonConvert.SerializeObject(_settings));
        }

        private void labelProcess_Click(object sender, EventArgs e)
        {
            Regex processRegex = new Regex(@"ffxiv(_d11)*");
            var process = Process.GetProcesses()
                .FirstOrDefault(p => processRegex.IsMatch(p.ProcessName));
            if (null != process)
            {
                labelProcess.Text = $"Connected to: {process.ProcessName} ({process.Id})";
                process.Exited += (s, args) =>
                {
                    labelProcess_Click(s, args);
                };
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
            Spinner spin = new Spinner
            {
                StartPosition = FormStartPosition.CenterParent
            };
            spin.ShowDialog();
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            var Controls = new Controls
            {
                StartPosition = FormStartPosition.CenterParent
            };
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
            Helper.PressKeyForDuration(keyCode, Random.Next(500, 1500));
        }

        private void buttonCrafting_Click(object sender, EventArgs e)
        {
            var bot = new CraftingBot
            {
                StartPosition = FormStartPosition.CenterParent
            };
            bot.ShowDialog();
        }

        private void buttonAutoGather_Click(object sender, EventArgs e)
        {
            var bot = new GatheringBot { StartPosition = FormStartPosition.CenterParent };
            bot.ShowDialog();
        }
    }
}