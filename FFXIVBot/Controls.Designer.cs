using System.ComponentModel;

namespace FFXIVBot
{
    partial class Controls
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
            textBoxLeft = new System.Windows.Forms.TextBox();
            textBoxRight = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBoxForward = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBoxMLeft = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBoxBackwards = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            textBoxMRight = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            buttonSave = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            textBoxCraft = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            textBoxGather = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(8, 17);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Turn Left";
            // 
            // textBoxLeft
            // 
            textBoxLeft.Location = new System.Drawing.Point(177, 14);
            textBoxLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxLeft.MaxLength = 1;
            textBoxLeft.Name = "textBoxLeft";
            textBoxLeft.Size = new System.Drawing.Size(114, 23);
            textBoxLeft.TabIndex = 1;
            // 
            // textBoxRight
            // 
            textBoxRight.Location = new System.Drawing.Point(177, 44);
            textBoxRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxRight.MaxLength = 1;
            textBoxRight.Name = "textBoxRight";
            textBoxRight.Size = new System.Drawing.Size(114, 23);
            textBoxRight.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(8, 47);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Turn Right";
            // 
            // textBoxForward
            // 
            textBoxForward.Location = new System.Drawing.Point(177, 74);
            textBoxForward.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxForward.MaxLength = 1;
            textBoxForward.Name = "textBoxForward";
            textBoxForward.Size = new System.Drawing.Size(114, 23);
            textBoxForward.TabIndex = 5;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(8, 77);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Forward";
            // 
            // textBoxMLeft
            // 
            textBoxMLeft.Location = new System.Drawing.Point(177, 104);
            textBoxMLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxMLeft.MaxLength = 1;
            textBoxMLeft.Name = "textBoxMLeft";
            textBoxMLeft.Size = new System.Drawing.Size(114, 23);
            textBoxMLeft.TabIndex = 7;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(8, 107);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Move Left";
            // 
            // textBoxBackwards
            // 
            textBoxBackwards.Location = new System.Drawing.Point(177, 164);
            textBoxBackwards.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxBackwards.MaxLength = 1;
            textBoxBackwards.Name = "textBoxBackwards";
            textBoxBackwards.Size = new System.Drawing.Size(114, 23);
            textBoxBackwards.TabIndex = 11;
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(8, 167);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(70, 20);
            label7.TabIndex = 10;
            label7.Text = "Backwards";
            // 
            // textBoxMRight
            // 
            textBoxMRight.Location = new System.Drawing.Point(177, 134);
            textBoxMRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxMRight.MaxLength = 1;
            textBoxMRight.Name = "textBoxMRight";
            textBoxMRight.Size = new System.Drawing.Size(114, 23);
            textBoxMRight.TabIndex = 9;
            // 
            // label8
            // 
            label8.Location = new System.Drawing.Point(8, 137);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(88, 20);
            label8.TabIndex = 8;
            label8.Text = "Move Right";
            // 
            // buttonSave
            // 
            buttonSave.Location = new System.Drawing.Point(7, 252);
            buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(88, 23);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(203, 252);
            buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(88, 23);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxCraft
            // 
            textBoxCraft.Location = new System.Drawing.Point(177, 193);
            textBoxCraft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxCraft.MaxLength = 1;
            textBoxCraft.Name = "textBoxCraft";
            textBoxCraft.Size = new System.Drawing.Size(114, 23);
            textBoxCraft.TabIndex = 17;
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(8, 196);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(118, 20);
            label5.TabIndex = 16;
            label5.Text = "Craft Macro";
            // 
            // textBoxGather
            // 
            textBoxGather.Location = new System.Drawing.Point(177, 223);
            textBoxGather.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxGather.MaxLength = 1;
            textBoxGather.Name = "textBoxGather";
            textBoxGather.Size = new System.Drawing.Size(114, 23);
            textBoxGather.TabIndex = 19;
            // 
            // label9
            // 
            label9.Location = new System.Drawing.Point(8, 226);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(144, 20);
            label9.TabIndex = 18;
            label9.Text = "Gather Macro";
            // 
            // Controls
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(306, 281);
            Controls.Add(textBoxGather);
            Controls.Add(label9);
            Controls.Add(textBoxCraft);
            Controls.Add(label5);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxBackwards);
            Controls.Add(label7);
            Controls.Add(textBoxMRight);
            Controls.Add(label8);
            Controls.Add(textBoxMLeft);
            Controls.Add(label4);
            Controls.Add(textBoxForward);
            Controls.Add(label3);
            Controls.Add(textBoxRight);
            Controls.Add(label2);
            Controls.Add(textBoxLeft);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Controls";
            Text = "Controls";
            Load += Controls_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxBackwards;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMRight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;

        private System.Windows.Forms.TextBox textBoxRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxForward;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMLeft;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLeft;

        #endregion

        private System.Windows.Forms.TextBox textBoxCraft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGather;
        private System.Windows.Forms.Label label9;
    }
}