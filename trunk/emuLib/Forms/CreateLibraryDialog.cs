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
    public partial class CreateLibraryDialog : Form
    {
        private MainView parent;

        public CreateLibraryDialog(MainView parent)
        {
            InitializeComponent();

            this.parent = parent;

            systemComboBox.Items.Add("SNES");
        }

        private void selectSnesXmlButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            dialog.Title = "Please select a XML-File that contains a SNES ROM Library";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                xmlPathInput.Text = dialog.FileName;
            }
        }

        private void selectSnesRomButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                romPathInput.Text = dialog.SelectedPath;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!romPathInput.Text.EndsWith("\\"))
                romPathInput.Text += "\\";

            this.Visible = false;

            Repo.snesLib = new GameLib((string)systemComboBox.SelectedItem, romPathInput.Text, xmlPathInput.Text);
            Repo.serializeGameLib();

            parent.loadSnesLibrary();

            this.Close();
        }
    }
}
