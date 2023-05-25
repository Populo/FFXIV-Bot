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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHotkey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCraft = new System.Windows.Forms.Button();
            this.numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorkerCraftBot = new System.ComponentModel.BackgroundWorker();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Macro Hotkey:";
            // 
            // textBoxHotkey
            // 
            this.textBoxHotkey.Location = new System.Drawing.Point(129, 4);
            this.textBoxHotkey.MaxLength = 1;
            this.textBoxHotkey.Name = "textBoxHotkey";
            this.textBoxHotkey.Size = new System.Drawing.Size(113, 20);
            this.textBoxHotkey.TabIndex = 1;
            this.textBoxHotkey.TextChanged += new System.EventHandler(this.textBoxHotkey_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Macro Duration (s):";
            // 
            // buttonCraft
            // 
            this.buttonCraft.Location = new System.Drawing.Point(12, 85);
            this.buttonCraft.Name = "buttonCraft";
            this.buttonCraft.Size = new System.Drawing.Size(230, 41);
            this.buttonCraft.TabIndex = 4;
            this.buttonCraft.Text = "Craft";
            this.buttonCraft.UseVisualStyleBackColor = true;
            this.buttonCraft.Click += new System.EventHandler(this.buttonCraft_Click);
            // 
            // numericUpDownDuration
            // 
            this.numericUpDownDuration.Location = new System.Drawing.Point(128, 31);
            this.numericUpDownDuration.Name = "numericUpDownDuration";
            this.numericUpDownDuration.Size = new System.Drawing.Size(114, 20);
            this.numericUpDownDuration.TabIndex = 5;
            this.numericUpDownDuration.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // backgroundWorkerCraftBot
            // 
            this.backgroundWorkerCraftBot.WorkerSupportsCancellation = true;
            this.backgroundWorkerCraftBot.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCraftBot_DoWork);
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Location = new System.Drawing.Point(128, 57);
            this.numericUpDownCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(114, 20);
            this.numericUpDownCount.TabIndex = 7;
            this.numericUpDownCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Craft Amount:\r\n";
            // 
            // CraftingBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 136);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownDuration);
            this.Controls.Add(this.buttonCraft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHotkey);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CraftingBot";
            this.Text = "Auto Crafting";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.NumericUpDown numericUpDownDuration;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCraftBot;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHotkey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCraft;

        #endregion
    }
}