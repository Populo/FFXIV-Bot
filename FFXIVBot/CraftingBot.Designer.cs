using System.ComponentModel;

namespace FFXIVBot
{
    partial class CraftingBot
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
            label1 = new System.Windows.Forms.Label();
            textBoxHotkey = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            buttonCraft = new System.Windows.Forms.Button();
            numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            backgroundWorkerCraftBot = new BackgroundWorker();
            numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            labelTotal = new System.Windows.Forms.Label();
            ((ISupportInitialize)numericUpDownDuration).BeginInit();
            ((ISupportInitialize)numericUpDownCount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(14, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 18);
            label1.TabIndex = 0;
            label1.Text = "Macro Hotkey:";
            // 
            // textBoxHotkey
            // 
            textBoxHotkey.Location = new System.Drawing.Point(154, 5);
            textBoxHotkey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxHotkey.MaxLength = 1;
            textBoxHotkey.Name = "textBoxHotkey";
            textBoxHotkey.Size = new System.Drawing.Size(131, 23);
            textBoxHotkey.TabIndex = 1;
            textBoxHotkey.TextChanged += textBoxHotkey_TextChanged;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(14, 40);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(128, 18);
            label2.TabIndex = 2;
            label2.Text = "Macro Duration (s):";
            // 
            // buttonCraft
            // 
            buttonCraft.Location = new System.Drawing.Point(13, 120);
            buttonCraft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonCraft.Name = "buttonCraft";
            buttonCraft.Size = new System.Drawing.Size(273, 47);
            buttonCraft.TabIndex = 4;
            buttonCraft.Text = "Craft";
            buttonCraft.UseVisualStyleBackColor = true;
            buttonCraft.Click += buttonCraft_Click;
            // 
            // numericUpDownDuration
            // 
            numericUpDownDuration.Location = new System.Drawing.Point(153, 36);
            numericUpDownDuration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericUpDownDuration.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownDuration.Name = "numericUpDownDuration";
            numericUpDownDuration.Size = new System.Drawing.Size(133, 23);
            numericUpDownDuration.TabIndex = 5;
            numericUpDownDuration.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // backgroundWorkerCraftBot
            // 
            backgroundWorkerCraftBot.WorkerSupportsCancellation = true;
            backgroundWorkerCraftBot.DoWork += backgroundWorkerCraftBot_DoWork;
            // 
            // numericUpDownCount
            // 
            numericUpDownCount.Location = new System.Drawing.Point(153, 66);
            numericUpDownCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericUpDownCount.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownCount.Name = "numericUpDownCount";
            numericUpDownCount.Size = new System.Drawing.Size(133, 23);
            numericUpDownCount.TabIndex = 7;
            numericUpDownCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(14, 70);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 18);
            label3.TabIndex = 6;
            label3.Text = "Craft Amount:\r\n";
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(14, 99);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(98, 18);
            label4.TabIndex = 8;
            label4.Text = "Craft Time:";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new System.Drawing.Point(154, 99);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new System.Drawing.Size(65, 15);
            labelTotal.TabIndex = 9;
            labelTotal.Text = "69 Minutes";
            // 
            // CraftingBot
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(299, 177);
            Controls.Add(labelTotal);
            Controls.Add(label4);
            Controls.Add(numericUpDownCount);
            Controls.Add(label3);
            Controls.Add(numericUpDownDuration);
            Controls.Add(buttonCraft);
            Controls.Add(label2);
            Controls.Add(textBoxHotkey);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CraftingBot";
            Text = "Auto Crafting";
            ((ISupportInitialize)numericUpDownDuration).EndInit();
            ((ISupportInitialize)numericUpDownCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.NumericUpDown numericUpDownDuration;
        private BackgroundWorker backgroundWorkerCraftBot;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHotkey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCraft;

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotal;
    }
}