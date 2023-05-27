using FFXIVBot.Properties;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FFXIVBot
{
    public partial class Controls : Form
    {
        public Controls()
        {
            InitializeComponent();
        }

        private void Controls_Load(object sender, EventArgs e)
        {
            textBoxForward.Text = Helper.Forward.ToString();
            textBoxBackwards.Text = Helper.Backward.ToString();
            textBoxLeft.Text = Helper.LeftTurn.ToString();
            textBoxRight.Text = Helper.RightTurn.ToString();
            textBoxMLeft.Text = Helper.MoveLeft.ToString();
            textBoxMRight.Text = Helper.MoveRight.ToString();
            textBoxCraft.Text = Helper.Craft.ToString();
            textBoxGather.Text = Helper.Gather.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Settings.Default.turnLeft = textBoxLeft.Text.First();
            Settings.Default.turnRight = textBoxRight.Text.First();
            Settings.Default.moveLeft = textBoxMLeft.Text.First();
            Settings.Default.moveRight = textBoxMRight.Text.First();
            Settings.Default.forward = textBoxForward.Text.First();
            Settings.Default.back = textBoxBackwards.Text.First();
            Settings.Default.craftMacro = textBoxCraft.Text.First();
            Settings.Default.gatherMacro = textBoxGather.Text.First();

            Settings.Default.Save();

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}