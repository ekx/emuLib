using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace emuLib.Forms
{
    public partial class PreferencesDialog : Form
    {
        public PreferencesDialog()
        {
            InitializeComponent();

            bsnesPathInput.Text = Repo.bsnesLocation;
        }

        private void selectBsnesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
            dialog.Title = "Please select the bsnes executable";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bsnesPathInput.Text = dialog.FileName;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Repo.bsnesLocation = bsnesPathInput.Text;

            Repo.saveSettings();

            this.Close();
        }
    }
}
