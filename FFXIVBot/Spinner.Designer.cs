using System.ComponentModel;

namespace FFXIVBot
{
    partial class Spinner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSpinLeft = new System.Windows.Forms.Button();
            this.buttonSpinRight = new System.Windows.Forms.Button();
            this.labelButtons = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSpinLeft
            // 
            this.buttonSpinLeft.Location = new System.Drawing.Point(12, 33);
            this.buttonSpinLeft.Name = "buttonSpinLeft";
            this.buttonSpinLeft.Size = new System.Drawing.Size(111, 35);
            this.buttonSpinLeft.TabIndex = 2;
            this.buttonSpinLeft.Text = "Spin Left";
            this.buttonSpinLeft.UseVisualStyleBackColor = true;
            this.buttonSpinLeft.Click += new System.EventHandler(this.buttonSpinLeft_Click);
            // 
            // buttonSpinRight
            // 
            this.buttonSpinRight.Location = new System.Drawing.Point(129, 33);
            this.buttonSpinRight.Name = "buttonSpinRight";
            this.buttonSpinRight.Size = new System.Drawing.Size(111, 35);
            this.buttonSpinRight.TabIndex = 3;
            this.buttonSpinRight.Text = "Spin Right";
            this.buttonSpinRight.UseVisualStyleBackColor = true;
            this.buttonSpinRight.Click += new System.EventHandler(this.buttonSpinRight_Click);
            // 
            // labelButtons
            // 
            this.labelButtons.Location = new System.Drawing.Point(16, 8);
            this.labelButtons.Name = "labelButtons";
            this.labelButtons.Size = new System.Drawing.Size(107, 22);
            this.labelButtons.TabIndex = 4;
            this.labelButtons.Text = "spin keys: a/d";
            this.labelButtons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Spinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 80);
            this.Controls.Add(this.labelButtons);
            this.Controls.Add(this.buttonSpinRight);
            this.Controls.Add(this.buttonSpinLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Spinner";
            this.Text = "Spinner";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonSpinRight;

        private System.Windows.Forms.Label labelButtons;
        private System.Windows.Forms.Button buttonSpinLeft;

        #endregion
    }
}