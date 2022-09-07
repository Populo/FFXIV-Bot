using System;
using System.Configuration;
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
            textBoxJump.Text = Helper.Jump.ToString();
            textBoxLeft.Text = Helper.LeftTurn.ToString();
            textBoxRight.Text = Helper.RightTurn.ToString();
            textBoxMLeft.Text = Helper.MoveLeft.ToString();
            textBoxMRight.Text = Helper.MoveRight.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["turnLeft"] = textBoxLeft.Text;
            ConfigurationManager.AppSettings["turnRight"] = textBoxRight.Text;
            ConfigurationManager.AppSettings["jump"] = textBoxJump.Text;
            ConfigurationManager.AppSettings["forward"] = textBoxForward.Text;
            ConfigurationManager.AppSettings["back"] = textBoxBackwards.Text;
            ConfigurationManager.AppSettings["moveLeft"] = textBoxMLeft.Text;
            ConfigurationManager.AppSettings["moveRight"] = textBoxMRight.Text;
            
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}