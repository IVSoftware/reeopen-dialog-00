namespace reeopen_dialog_00
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMultiline = new System.Windows.Forms.TextBox();
            this.settingsMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMultiline
            // 
            this.textBoxMultiline.Location = new System.Drawing.Point(25, 12);
            this.textBoxMultiline.Multiline = true;
            this.textBoxMultiline.Name = "textBoxMultiline";
            this.textBoxMultiline.Size = new System.Drawing.Size(128, 227);
            this.textBoxMultiline.TabIndex = 0;
            // 
            // settingsMenu
            // 
            this.settingsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsMenu.Image = global::reeopen_dialog_00.Properties.Resources.ellipsis_menu;
            this.settingsMenu.Location = new System.Drawing.Point(123, 12);
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(30, 30);
            this.settingsMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsMenu.TabIndex = 1;
            this.settingsMenu.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 261);
            this.Controls.Add(this.settingsMenu);
            this.Controls.Add(this.textBoxMultiline);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.settingsMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxMultiline;
        private PictureBox settingsMenu;
    }
}