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
        private MainView parent;

        public PreferencesDialog(MainView parent)
        {
            InitializeComponent();

            this.parent = parent;

            bsnesPathInput.Text = Repo.bsnesLocation;
            snesXmlPathInput.Text = Repo.snesXmlLocation;
            snesRomPathInput.Text = Repo.snesRomLocation;
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

        private void selectSnesXmlButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            dialog.Title = "Please select a XML-File that contains a SNES ROM Library";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                snesXmlPathInput.Text = dialog.FileName;
            }
        }

        private void selectSnesRomButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                snesRomPathInput.Text = dialog.SelectedPath;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!snesRomPathInput.Text.EndsWith("\\"))
                snesRomPathInput.Text += "\\";

            Repo.bsnesLocation = bsnesPathInput.Text;
            Repo.snesXmlLocation = snesXmlPathInput.Text;
            Repo.snesRomLocation = snesRomPathInput.Text;

            Repo.saveSettings();

            parent.loadSnesLibrary();

            this.Close();
        }
    }
}
