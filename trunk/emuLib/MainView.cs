using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BrightIdeasSoftware;
using emuLib.Forms;
using System.Diagnostics;

namespace emuLib
{
    public partial class MainView : Form
    {
        private Game sel;

        public MainView()
        {
            InitializeComponent();

            Win32Utility.SetCueText(searchBox.TextBox, " Search Games");

            ToolStripLabel searchIcon = new ToolStripLabel();
            searchIcon.Image = Properties.Resources.Search;
            searchIcon.Alignment = ToolStripItemAlignment.Right;
            searchIcon.Padding = new Padding(0, 0, 10, 0);
            menuStrip.Items.Add(searchIcon);

            Repo.loadSettings();

            loadSnesLibrary();
        }

        public void loadSnesLibrary()
        {
            if (Repo.snesRomLocation != null && Repo.snesXmlLocation != null)
            {
                Repo.snesLib = new GameLib("SNES", Repo.snesRomLocation, Repo.snesXmlLocation);

                this.nameColumn.ImageGetter = delegate(object row)
                {
                    Game g = (Game)row;
                    return g.name;
                };

                detailsMenuItem.Checked = true;
                libTable.LargeImageList = Repo.snesLib.getBoxArt();
                //libTable.SmallImageList = Repo.snesLib.getBoxArt();

                libTable.SetObjects(Repo.snesLib.getGames());
            }
        }

        private void libTable_SelectionChanged(object sender, EventArgs e)
        {
            if (libTable.SelectedObject != null)
            {
                sel = (Game)libTable.SelectedObject;

                cartArt.Image = Repo.snesLib.getCartridgeArt(sel.name);
                boxArt.Image = Repo.snesLib.getBoxArt(sel.name);

                gameTitle.Text = sel.name;
                manufacturerLabel.Text = "Manufacturer: " + sel.manufacturer;
                yearLabel.Text = "Release: " + sel.year;
                genreLabel.Text = "Genre: " + sel.genre;

                descriptionBox.Text = Repo.snesLib.getDescription(sel.name);
            }
        }

        private void libTable_ItemsChanged(object sender, BrightIdeasSoftware.ItemsChangedEventArgs e)
        {
            gamesCountLabel.Text = libTable.Items.Count + " Games";
        }

        private void detailsMenuItem_Click(object sender, EventArgs e)
        {
            detailsMenuItem.Checked = true;
            detailsGroupedMenuItem.Checked = false;
            largeIconsMenuItem.Checked = false;

            libTable.View = View.Details;
            libTable.ShowGroups = false;
        }

        private void detailsGroupedMenuItem_Click(object sender, EventArgs e)
        {
            detailsMenuItem.Checked = false;
            detailsGroupedMenuItem.Checked = true;
            largeIconsMenuItem.Checked = false;

            libTable.View = View.Details;
            libTable.ShowGroups = true;
            libTable.Sort(0);
        }

        private void largeIconsMenuItem_Click(object sender, EventArgs e)
        {
            detailsMenuItem.Checked = false;
            detailsGroupedMenuItem.Checked = false;
            largeIconsMenuItem.Checked = true;

            libTable.View = View.LargeIcon;
            libTable.ShowGroups = false;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            libTable.ModelFilter = TextMatchFilter.Contains(this.libTable, searchBox.Text);
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog ad = new AboutDialog();
            ad.Show();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferencesDialog pd = new PreferencesDialog(this);
            pd.Show();
        }

        private void readManualLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Repo.snesLib.openManual(sel.name);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void libTable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            startGame();
        }

        private void libTable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                startGame();
            }
        }

        private void startGame()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();        
            startInfo.FileName = Repo.bsnesLocation;
            startInfo.Arguments = "\"" + Repo.snesLib.getRomPath(sel.name) + "\"";
            Process.Start(startInfo);
        }
    }
}
