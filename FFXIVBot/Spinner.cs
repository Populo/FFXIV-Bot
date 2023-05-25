using System;
using System.Windows.Forms;

namespace FFXIVBot
{
    public partial class Spinner : Form
    {
        private bool Spinning { get; set; }
        
        public Spinner()
        {
            InitializeComponent();

            Spinning = false;
            
            labelButtons.Text = $"spin keys: {Helper.LeftTurn}/{Helper.RightTurn}";
        }

        public void UpdateKeys()
        {
            labelButtons.Text = $"spin keys: {Helper.LeftTurn}/{Helper.RightTurn}";
        }

        private void buttonSpinLeft_Click(object sender, EventArgs e)
        {
            int key = Helper.GetKeyCode(Helper.LeftTurn);

            if (Spinning)
            {
                Helper.LiftKey(key);
                buttonSpinRight.Enabled = true;
                Spinning = false;
            }
            else
            {
                Spinning = true;
                buttonSpinRight.Enabled = false;
                Helper.PressKey(key);
            }
        }

        private void buttonSpinRight_Click(object sender, EventArgs e)
        {
            int key = Helper.GetKeyCode(Helper.RightTurn);

            if (Spinning)
            {
               // Helper.LiftKey(key);
                buttonSpinLeft.Enabled = true;
                Spinning = false;
            }
            else
            {
                Spinning = true;
                buttonSpinLeft.Enabled = false;
             //   Helper.PressKey(key);
            }
        }
    }
}