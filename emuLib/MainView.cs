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
using emuLib.Model;

namespace emuLib
{
    public partial class MainView : Form
    {
        private Game sel;

        public MainView()
        {
            InitializeComponent();
            initializeListViews();

            Win32Utility.SetCueText(searchBox.TextBox, " Search Games");

            ToolStripLabel searchIcon = new ToolStripLabel();
            searchIcon.Image = Properties.Resources.Search;
            searchIcon.Alignment = ToolStripItemAlignment.Right;
            searchIcon.Padding = new Padding(0, 0, 10, 0);
            menuStrip.Items.Add(searchIcon);

            Repo.loadSettings();

            loadSnesLibrary();
            setSelectedView(Repo.loadSelectedView());
        }

        private void initializeListViews()
        {
            this.nameColumn.ImageGetter = delegate(object row)
            {
                Game g = (Game)row;
                return g.name;
            };

            this.nColumn.GroupKeyGetter = delegate(object row)
            {
                Save s = (Save)row;
                if (s.type == SaveType.Normal)
                    return "Normal";
                if (s.type == SaveType.StateManager)
                    return "State Manager";

                return "Normal";
            };

            this.nrColumn.GroupKeyGetter = delegate(object row)
            {
                Save s = (Save)row;
                if (s.type == SaveType.Normal)
                    return "Normal";
                if (s.type == SaveType.StateManager)
                    return "State Manager";

                return "Normal";
            };

            this.dateColumn.GroupKeyGetter = delegate(object row)
            {
                Save s = (Save)row;
                if (s.type == SaveType.Normal)
                    return "Normal";
                if (s.type == SaveType.StateManager)
                    return "State Manager";

                return "Normal";
            };
        }

        public void loadSnesLibrary()
        {
            if (File.Exists(Repo.FILENAME))
            {
                if(Repo.snesLib == null)
                    Repo.deserializeGameLib();

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

                saveTable.SetObjects(Repo.snesLib.getSaveList(sel.name));
            }
        }

        private void libTable_ItemsChanged(object sender, BrightIdeasSoftware.ItemsChangedEventArgs e)
        {
            gamesCountLabel.Text = libTable.Items.Count + " Games";
        }

        private void detailsMenuItem_Click(object sender, EventArgs e)
        {
            setSelectedView("details");
        }

        private void detailsGroupedMenuItem_Click(object sender, EventArgs e)
        {
            setSelectedView("grouped");
        }

        private void largeIconsMenuItem_Click(object sender, EventArgs e)
        {
            setSelectedView("icons");
        }

        private void setSelectedView(string type)
        {
            if (type == null)
                return;

            if (type.Equals("details"))
            {
                detailsMenuItem.Checked = true;
                detailsGroupedMenuItem.Checked = false;
                largeIconsMenuItem.Checked = false;

                libTable.View = View.Details;
                libTable.ShowGroups = false;

                Repo.saveSelectedView("details");
            }
            else if (type.Equals("grouped"))
            {
                detailsMenuItem.Checked = false;
                detailsGroupedMenuItem.Checked = true;
                largeIconsMenuItem.Checked = false;

                libTable.View = View.Details;
                libTable.ShowGroups = true;
                libTable.Sort(0);

                Repo.saveSelectedView("grouped");
            }
            else if (type.Equals("icons"))
            {
                detailsMenuItem.Checked = false;
                detailsGroupedMenuItem.Checked = false;
                largeIconsMenuItem.Checked = true;

                libTable.View = View.LargeIcon;
                libTable.ShowGroups = false;

                Repo.saveSelectedView("icons");
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text.Length > 1)
            {
                TextMatchFilter filter = TextMatchFilter.Contains(this.libTable, searchBox.Text);
                libTable.ModelFilter = filter;
                libTable.DefaultRenderer = new HighlightTextRenderer(filter);
            }
            else
            {
                TextMatchFilter filter = null;
                libTable.ModelFilter = filter;
                libTable.DefaultRenderer = new HighlightTextRenderer(filter);
            }
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog ad = new AboutDialog();
            ad.Show();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferencesDialog pd = new PreferencesDialog();
            pd.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateLibraryDialog cld = new CreateLibraryDialog(this);
            cld.Show();
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

        private void loadButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = Repo.bsnesLocation;
            Save temp = (Save)saveTable.SelectedObject;
            startInfo.Arguments = "\"" + Repo.snesLib.getRomPath(sel.name) + "\"" + temp.filename + "\"";
            Process.Start(startInfo);
        }
    }
}
