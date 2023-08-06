namespace FFXIVBot
{
    partial class MacroBox
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
            textBoxMacro = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // textBoxMacro
            // 
            textBoxMacro.Location = new System.Drawing.Point(12, 12);
            textBoxMacro.Multiline = true;
            textBoxMacro.Name = "textBoxMacro";
            textBoxMacro.ReadOnly = true;
            textBoxMacro.Size = new System.Drawing.Size(228, 169);
            textBoxMacro.TabIndex = 0;
            // 
            // MacroBox
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(252, 193);
            Controls.Add(textBoxMacro);
            Name = "MacroBox";
            Text = "Macro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.TextBox textBoxMacro;
    }
}