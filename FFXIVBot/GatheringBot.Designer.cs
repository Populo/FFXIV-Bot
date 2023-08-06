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
            numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            buttonGather = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            textBoxHotkey = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            backgroundWorkerGatherBot = new System.ComponentModel.BackgroundWorker();
            panel1 = new System.Windows.Forms.Panel();
            numericUpDownTurn = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            radioButtonRight = new System.Windows.Forms.RadioButton();
            radioButtonNone = new System.Windows.Forms.RadioButton();
            radioButtonLeft = new System.Windows.Forms.RadioButton();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            labelxp = new System.Windows.Forms.Label();
            numericUpDownGather = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            labelFortyThou = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTurn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGather).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownDuration
            // 
            numericUpDownDuration.DecimalPlaces = 2;
            numericUpDownDuration.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownDuration.Location = new System.Drawing.Point(118, 38);
            numericUpDownDuration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericUpDownDuration.Name = "numericUpDownDuration";
            numericUpDownDuration.Size = new System.Drawing.Size(133, 23);
            numericUpDownDuration.TabIndex = 12;
            numericUpDownDuration.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // buttonGather
            // 
            buttonGather.Location = new System.Drawing.Point(13, 96);
            buttonGather.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonGather.Name = "buttonGather";
            buttonGather.Size = new System.Drawing.Size(237, 47);
            buttonGather.TabIndex = 11;
            buttonGather.Text = "Gather";
            buttonGather.UseVisualStyleBackColor = true;
            buttonGather.Click += buttonGather_Click;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(14, 40);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 18);
            label2.TabIndex = 10;
            label2.Text = "Run Time (s):";
            // 
            // textBoxHotkey
            // 
            textBoxHotkey.Location = new System.Drawing.Point(119, 7);
            textBoxHotkey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxHotkey.MaxLength = 1;
            textBoxHotkey.Name = "textBoxHotkey";
            textBoxHotkey.Size = new System.Drawing.Size(131, 23);
            textBoxHotkey.TabIndex = 9;
            textBoxHotkey.TextChanged += textBoxHotkey_TextChanged;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(14, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 18);
            label1.TabIndex = 8;
            label1.Text = "Macro Hotkey:";
            // 
            // backgroundWorkerGatherBot
            // 
            backgroundWorkerGatherBot.WorkerSupportsCancellation = true;
            backgroundWorkerGatherBot.DoWork += backgroundWorkerGatherBot_DoWork;
            // 
            // panel1
            // 
            panel1.Controls.Add(numericUpDownTurn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(radioButtonRight);
            panel1.Controls.Add(radioButtonNone);
            panel1.Controls.Add(radioButtonLeft);
            panel1.Controls.Add(label3);
            panel1.Location = new System.Drawing.Point(299, 7);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(195, 95);
            panel1.TabIndex = 13;
            // 
            // numericUpDownTurn
            // 
            numericUpDownTurn.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownTurn.Location = new System.Drawing.Point(7, 60);
            numericUpDownTurn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericUpDownTurn.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownTurn.Name = "numericUpDownTurn";
            numericUpDownTurn.Size = new System.Drawing.Size(182, 23);
            numericUpDownTurn.TabIndex = 5;
            numericUpDownTurn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            numericUpDownTurn.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(4, 42);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(90, 15);
            label4.TabIndex = 4;
            label4.Text = "Turn Time (ms):";
            // 
            // radioButtonRight
            // 
            radioButtonRight.AutoSize = true;
            radioButtonRight.Location = new System.Drawing.Point(131, 18);
            radioButtonRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButtonRight.Name = "radioButtonRight";
            radioButtonRight.Size = new System.Drawing.Size(53, 19);
            radioButtonRight.TabIndex = 3;
            radioButtonRight.Text = "Right";
            radioButtonRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonNone
            // 
            radioButtonNone.AutoSize = true;
            radioButtonNone.Checked = true;
            radioButtonNone.Location = new System.Drawing.Point(64, 18);
            radioButtonNone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButtonNone.Name = "radioButtonNone";
            radioButtonNone.Size = new System.Drawing.Size(54, 19);
            radioButtonNone.TabIndex = 2;
            radioButtonNone.TabStop = true;
            radioButtonNone.Text = "None";
            radioButtonNone.UseVisualStyleBackColor = true;
            // 
            // radioButtonLeft
            // 
            radioButtonLeft.AutoSize = true;
            radioButtonLeft.Location = new System.Drawing.Point(7, 18);
            radioButtonLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButtonLeft.Name = "radioButtonLeft";
            radioButtonLeft.Size = new System.Drawing.Size(45, 19);
            radioButtonLeft.TabIndex = 1;
            radioButtonLeft.Text = "Left";
            radioButtonLeft.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(4, 0);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 15);
            label3.TabIndex = 0;
            label3.Text = "Turn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(303, 105);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(72, 15);
            label5.TabIndex = 14;
            label5.Text = "1k xp every: ";
            // 
            // labelxp
            // 
            labelxp.AutoSize = true;
            labelxp.Location = new System.Drawing.Point(379, 105);
            labelxp.Name = "labelxp";
            labelxp.Size = new System.Drawing.Size(65, 15);
            labelxp.TabIndex = 15;
            labelxp.Text = "69 minutes";
            // 
            // numericUpDownGather
            // 
            numericUpDownGather.DecimalPlaces = 2;
            numericUpDownGather.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownGather.Location = new System.Drawing.Point(118, 67);
            numericUpDownGather.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericUpDownGather.Name = "numericUpDownGather";
            numericUpDownGather.Size = new System.Drawing.Size(133, 23);
            numericUpDownGather.TabIndex = 17;
            numericUpDownGather.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label6
            // 
            label6.Location = new System.Drawing.Point(14, 69);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(98, 18);
            label6.TabIndex = 16;
            label6.Text = "Gather Time (s):";
            // 
            // labelFortyThou
            // 
            labelFortyThou.AutoSize = true;
            labelFortyThou.Location = new System.Drawing.Point(379, 120);
            labelFortyThou.Name = "labelFortyThou";
            labelFortyThou.Size = new System.Drawing.Size(65, 15);
            labelFortyThou.TabIndex = 19;
            labelFortyThou.Text = "69 minutes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(297, 120);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(78, 15);
            label7.TabIndex = 20;
            label7.Text = "10k xp every: ";
            // 
            // GatheringBot
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(507, 154);
            Controls.Add(label7);
            Controls.Add(labelFortyThou);
            Controls.Add(numericUpDownGather);
            Controls.Add(label6);
            Controls.Add(labelxp);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(numericUpDownDuration);
            Controls.Add(buttonGather);
            Controls.Add(label2);
            Controls.Add(textBoxHotkey);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GatheringBot";
            Text = "Auto Gathering";
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTurn).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGather).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelxp;
        private System.Windows.Forms.NumericUpDown numericUpDownGather;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelFortyThou;
        private System.Windows.Forms.Label label7;
    }
}