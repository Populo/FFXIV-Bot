namespace FFXIVBot
{
    partial class GatheringBot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.buttonGather = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHotkey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorkerGatherBot = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonLeft = new System.Windows.Forms.RadioButton();
            this.radioButtonNone = new System.Windows.Forms.RadioButton();
            this.radioButtonRight = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownTurn = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTurn)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownDuration
            // 
            this.numericUpDownDuration.Location = new System.Drawing.Point(101, 33);
            this.numericUpDownDuration.Name = "numericUpDownDuration";
            this.numericUpDownDuration.Size = new System.Drawing.Size(114, 20);
            this.numericUpDownDuration.TabIndex = 12;
            this.numericUpDownDuration.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonGather
            // 
            this.buttonGather.Location = new System.Drawing.Point(12, 59);
            this.buttonGather.Name = "buttonGather";
            this.buttonGather.Size = new System.Drawing.Size(203, 41);
            this.buttonGather.TabIndex = 11;
            this.buttonGather.Text = "Gather";
            this.buttonGather.UseVisualStyleBackColor = true;
            this.buttonGather.Click += new System.EventHandler(this.buttonGather_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Wait Time (s):";
            // 
            // textBoxHotkey
            // 
            this.textBoxHotkey.Location = new System.Drawing.Point(102, 6);
            this.textBoxHotkey.MaxLength = 1;
            this.textBoxHotkey.Name = "textBoxHotkey";
            this.textBoxHotkey.Size = new System.Drawing.Size(113, 20);
            this.textBoxHotkey.TabIndex = 9;
            this.textBoxHotkey.TextChanged += new System.EventHandler(this.textBoxHotkey_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Macro Hotkey:";
            // 
            // backgroundWorkerGatherBot
            // 
            this.backgroundWorkerGatherBot.WorkerSupportsCancellation = true;
            this.backgroundWorkerGatherBot.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerGatherBot_DoWork);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDownTurn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.radioButtonRight);
            this.panel1.Controls.Add(this.radioButtonNone);
            this.panel1.Controls.Add(this.radioButtonLeft);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(256, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 82);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Turn:";
            // 
            // radioButtonLeft
            // 
            this.radioButtonLeft.AutoSize = true;
            this.radioButtonLeft.Location = new System.Drawing.Point(6, 16);
            this.radioButtonLeft.Name = "radioButtonLeft";
            this.radioButtonLeft.Size = new System.Drawing.Size(43, 17);
            this.radioButtonLeft.TabIndex = 1;
            this.radioButtonLeft.Text = "Left";
            this.radioButtonLeft.UseVisualStyleBackColor = true;
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.AutoSize = true;
            this.radioButtonNone.Checked = true;
            this.radioButtonNone.Location = new System.Drawing.Point(55, 16);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(51, 17);
            this.radioButtonNone.TabIndex = 2;
            this.radioButtonNone.TabStop = true;
            this.radioButtonNone.Text = "None";
            this.radioButtonNone.UseVisualStyleBackColor = true;
            // 
            // radioButtonRight
            // 
            this.radioButtonRight.AutoSize = true;
            this.radioButtonRight.Location = new System.Drawing.Point(112, 16);
            this.radioButtonRight.Name = "radioButtonRight";
            this.radioButtonRight.Size = new System.Drawing.Size(50, 17);
            this.radioButtonRight.TabIndex = 3;
            this.radioButtonRight.Text = "Right";
            this.radioButtonRight.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Turn Time (ms):";
            // 
            // numericUpDownTurn
            // 
            this.numericUpDownTurn.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownTurn.Location = new System.Drawing.Point(6, 52);
            this.numericUpDownTurn.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDownTurn.Name = "numericUpDownTurn";
            this.numericUpDownTurn.Size = new System.Drawing.Size(156, 20);
            this.numericUpDownTurn.TabIndex = 5;
            this.numericUpDownTurn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownTurn.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // GatheringBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 110);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericUpDownDuration);
            this.Controls.Add(this.buttonGather);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHotkey);
            this.Controls.Add(this.label1);
            this.Name = "GatheringBot";
            this.Text = "Auto Gathering";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTurn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownDuration;
        private System.Windows.Forms.Button buttonGather;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHotkey;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerGatherBot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownTurn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonRight;
        private System.Windows.Forms.RadioButton radioButtonNone;
        private System.Windows.Forms.RadioButton radioButtonLeft;
    }
}