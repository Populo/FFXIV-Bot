namespace FFXIVBot
{
    partial class Bot
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
            this.buttonSpinner = new System.Windows.Forms.Button();
            this.buttonAFK = new System.Windows.Forms.Button();
            this.buttonCrafting = new System.Windows.Forms.Button();
            this.buttonAutomation = new System.Windows.Forms.Button();
            this.labelProcess = new System.Windows.Forms.Label();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.backgroundWorkerAfkBot = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // buttonSpinner
            // 
            this.buttonSpinner.Location = new System.Drawing.Point(12, 12);
            this.buttonSpinner.Name = "buttonSpinner";
            this.buttonSpinner.Size = new System.Drawing.Size(260, 56);
            this.buttonSpinner.TabIndex = 0;
            this.buttonSpinner.Text = "Spin Bot";
            this.buttonSpinner.UseVisualStyleBackColor = true;
            this.buttonSpinner.Click += new System.EventHandler(this.buttonSpinner_Click);
            // 
            // buttonAFK
            // 
            this.buttonAFK.Location = new System.Drawing.Point(12, 74);
            this.buttonAFK.Name = "buttonAFK";
            this.buttonAFK.Size = new System.Drawing.Size(260, 56);
            this.buttonAFK.TabIndex = 1;
            this.buttonAFK.Text = "Start AFK Bot";
            this.buttonAFK.UseVisualStyleBackColor = true;
            this.buttonAFK.Click += new System.EventHandler(this.buttonAFK_Click);
            // 
            // buttonCrafting
            // 
            this.buttonCrafting.Enabled = false;
            this.buttonCrafting.Location = new System.Drawing.Point(12, 136);
            this.buttonCrafting.Name = "buttonCrafting";
            this.buttonCrafting.Size = new System.Drawing.Size(260, 56);
            this.buttonCrafting.TabIndex = 2;
            this.buttonCrafting.Text = "Auto Crafting";
            this.buttonCrafting.UseVisualStyleBackColor = true;
            // 
            // buttonAutomation
            // 
            this.buttonAutomation.Enabled = false;
            this.buttonAutomation.Location = new System.Drawing.Point(12, 198);
            this.buttonAutomation.Name = "buttonAutomation";
            this.buttonAutomation.Size = new System.Drawing.Size(260, 56);
            this.buttonAutomation.TabIndex = 3;
            this.buttonAutomation.Text = "Custom Automation";
            this.buttonAutomation.UseVisualStyleBackColor = true;
            // 
            // labelProcess
            // 
            this.labelProcess.Location = new System.Drawing.Point(12, 269);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(166, 19);
            this.labelProcess.TabIndex = 4;
            this.labelProcess.Text = "Click to connect to Final Fantasy";
            this.labelProcess.Click += new System.EventHandler(this.labelProcess_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.Location = new System.Drawing.Point(194, 260);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(78, 30);
            this.buttonOptions.TabIndex = 5;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = true;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // backgroundWorkerAfkBot
            // 
            this.backgroundWorkerAfkBot.WorkerSupportsCancellation = true;
            this.backgroundWorkerAfkBot.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerAfkBot_DoWork);
            // 
            // Bot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 299);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.labelProcess);
            this.Controls.Add(this.buttonAutomation);
            this.Controls.Add(this.buttonCrafting);
            this.Controls.Add(this.buttonAFK);
            this.Controls.Add(this.buttonSpinner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bot";
            this.Text = "FFXIV Bot v1.0";
            this.ResumeLayout(false);
        }

        private System.ComponentModel.BackgroundWorker backgroundWorkerAfkBot;

        private System.Windows.Forms.Button buttonOptions;

        private System.Windows.Forms.Label labelProcess;

        private System.Windows.Forms.Button buttonSpinner;
        private System.Windows.Forms.Button buttonAFK;
        private System.Windows.Forms.Button buttonCrafting;
        private System.Windows.Forms.Button buttonAutomation;

        #endregion
    }
}