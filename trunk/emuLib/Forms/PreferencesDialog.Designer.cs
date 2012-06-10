namespace emuLib.Forms
{
    partial class PreferencesDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.bsnesPathInput = new System.Windows.Forms.TextBox();
            this.selectBsnesButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "bsnes path:";
            // 
            // bsnesPathInput
            // 
            this.bsnesPathInput.Location = new System.Drawing.Point(12, 25);
            this.bsnesPathInput.Name = "bsnesPathInput";
            this.bsnesPathInput.Size = new System.Drawing.Size(400, 20);
            this.bsnesPathInput.TabIndex = 1;
            // 
            // selectBsnesButton
            // 
            this.selectBsnesButton.Location = new System.Drawing.Point(418, 24);
            this.selectBsnesButton.Name = "selectBsnesButton";
            this.selectBsnesButton.Size = new System.Drawing.Size(32, 20);
            this.selectBsnesButton.TabIndex = 2;
            this.selectBsnesButton.Text = "...";
            this.selectBsnesButton.UseVisualStyleBackColor = true;
            this.selectBsnesButton.Click += new System.EventHandler(this.selectBsnesButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(375, 51);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // PreferencesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 86);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.selectBsnesButton);
            this.Controls.Add(this.bsnesPathInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferencesDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Preferences";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bsnesPathInput;
        private System.Windows.Forms.Button selectBsnesButton;
        private System.Windows.Forms.Button okButton;
    }
}