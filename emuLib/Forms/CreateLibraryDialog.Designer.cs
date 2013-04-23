namespace emuLib.Forms
{
    partial class CreateLibraryDialog
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
            this.okButton = new System.Windows.Forms.Button();
            this.selectRomButton = new System.Windows.Forms.Button();
            this.romPathInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectXmlButton = new System.Windows.Forms.Button();
            this.xmlPathInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.systemComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(375, 149);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 16;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // selectRomButton
            // 
            this.selectRomButton.Location = new System.Drawing.Point(418, 109);
            this.selectRomButton.Name = "selectRomButton";
            this.selectRomButton.Size = new System.Drawing.Size(32, 20);
            this.selectRomButton.TabIndex = 15;
            this.selectRomButton.Text = "...";
            this.selectRomButton.UseVisualStyleBackColor = true;
            this.selectRomButton.Click += new System.EventHandler(this.selectSnesRomButton_Click);
            // 
            // romPathInput
            // 
            this.romPathInput.Location = new System.Drawing.Point(12, 110);
            this.romPathInput.Name = "romPathInput";
            this.romPathInput.Size = new System.Drawing.Size(400, 20);
            this.romPathInput.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ROMs path:";
            // 
            // selectXmlButton
            // 
            this.selectXmlButton.Location = new System.Drawing.Point(418, 70);
            this.selectXmlButton.Name = "selectXmlButton";
            this.selectXmlButton.Size = new System.Drawing.Size(32, 20);
            this.selectXmlButton.TabIndex = 12;
            this.selectXmlButton.Text = "...";
            this.selectXmlButton.UseVisualStyleBackColor = true;
            this.selectXmlButton.Click += new System.EventHandler(this.selectSnesXmlButton_Click);
            // 
            // xmlPathInput
            // 
            this.xmlPathInput.Location = new System.Drawing.Point(12, 71);
            this.xmlPathInput.Name = "xmlPathInput";
            this.xmlPathInput.Size = new System.Drawing.Size(400, 20);
            this.xmlPathInput.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "XML path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "System:";
            // 
            // systemComboBox
            // 
            this.systemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.systemComboBox.FormattingEnabled = true;
            this.systemComboBox.Location = new System.Drawing.Point(12, 29);
            this.systemComboBox.Name = "systemComboBox";
            this.systemComboBox.Size = new System.Drawing.Size(438, 21);
            this.systemComboBox.TabIndex = 18;
            // 
            // CreateLibraryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 183);
            this.Controls.Add(this.systemComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.selectRomButton);
            this.Controls.Add(this.romPathInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectXmlButton);
            this.Controls.Add(this.xmlPathInput);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateLibraryDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Create Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button selectRomButton;
        private System.Windows.Forms.TextBox romPathInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectXmlButton;
        private System.Windows.Forms.TextBox xmlPathInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox systemComboBox;
    }
}