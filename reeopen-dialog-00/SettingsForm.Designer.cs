namespace reeopen_dialog_00
{
    partial class SettingsForm
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
            this.groupSort = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.buttonApply = new System.Windows.Forms.Button();
            this.groupSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupSort.Controls.Add(this.radioButton2);
            this.groupSort.Controls.Add(this.radioButton1);
            this.groupSort.Location = new System.Drawing.Point(12, 27);
            this.groupSort.Name = "groupBox1";
            this.groupSort.Size = new System.Drawing.Size(247, 65);
            this.groupSort.TabIndex = 0;
            this.groupSort.TabStop = false;
            this.groupSort.Text = "Sort";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "None";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(98, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 19);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "Alphanumeric";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.buttonApply.Location = new System.Drawing.Point(184, 116);
            this.buttonApply.Name = "button1";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.groupSort);
            this.Name = "Settings";
            this.Text = "Settings";
            this.groupSort.ResumeLayout(false);
            this.groupSort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupSort;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button buttonApply;
    }
}