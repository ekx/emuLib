namespace emuLib
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.libTable = new BrightIdeasSoftware.ObjectListView();
            this.nameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.genreColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.manColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.yearColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.viewDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.detailsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsGroupedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.gamesCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.gameTitle = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.readManualLabel = new System.Windows.Forms.LinkLabel();
            this.playButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cartArt = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.boxArt = new System.Windows.Forms.PictureBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveTable = new BrightIdeasSoftware.ObjectListView();
            this.nrColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.nColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.dateColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.libTable)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartArt)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxArt)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveTable)).BeginInit();
            this.SuspendLayout();
            // 
            // libTable
            // 
            this.libTable.AllColumns.Add(this.nameColumn);
            this.libTable.AllColumns.Add(this.genreColumn);
            this.libTable.AllColumns.Add(this.manColumn);
            this.libTable.AllColumns.Add(this.yearColumn);
            this.libTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.libTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.genreColumn,
            this.manColumn,
            this.yearColumn});
            this.libTable.FullRowSelect = true;
            this.libTable.Location = new System.Drawing.Point(0, 27);
            this.libTable.MultiSelect = false;
            this.libTable.Name = "libTable";
            this.libTable.OwnerDraw = true;
            this.libTable.ShowGroups = false;
            this.libTable.Size = new System.Drawing.Size(928, 720);
            this.libTable.TabIndex = 2;
            this.libTable.UseCompatibleStateImageBehavior = false;
            this.libTable.UseFiltering = true;
            this.libTable.View = System.Windows.Forms.View.Details;
            this.libTable.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.libTable_ItemsChanged);
            this.libTable.SelectionChanged += new System.EventHandler(this.libTable_SelectionChanged);
            this.libTable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.libTable_KeyPress);
            this.libTable.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.libTable_MouseDoubleClick);
            // 
            // nameColumn
            // 
            this.nameColumn.AspectName = "name";
            this.nameColumn.FillsFreeSpace = true;
            this.nameColumn.ImageAspectName = "";
            this.nameColumn.Text = "Name";
            this.nameColumn.UseInitialLetterForGroup = true;
            this.nameColumn.Width = 268;
            // 
            // genreColumn
            // 
            this.genreColumn.AspectName = "genre";
            this.genreColumn.MaximumWidth = 120;
            this.genreColumn.MinimumWidth = 120;
            this.genreColumn.Text = "Genre";
            this.genreColumn.Width = 120;
            // 
            // manColumn
            // 
            this.manColumn.AspectName = "manufacturer";
            this.manColumn.MaximumWidth = 155;
            this.manColumn.MinimumWidth = 155;
            this.manColumn.Text = "Manufacturer";
            this.manColumn.Width = 155;
            // 
            // yearColumn
            // 
            this.yearColumn.AspectName = "year";
            this.yearColumn.MaximumWidth = 40;
            this.yearColumn.MinimumWidth = 40;
            this.yearColumn.Text = "Year";
            this.yearColumn.Width = 40;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDropDownButton,
            this.spacer,
            this.gamesCountLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 750);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1261, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // viewDropDownButton
            // 
            this.viewDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.viewDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsMenuItem,
            this.detailsGroupedMenuItem,
            this.largeIconsMenuItem});
            this.viewDropDownButton.Image = global::emuLib.Properties.Resources.View;
            this.viewDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewDropDownButton.Name = "viewDropDownButton";
            this.viewDropDownButton.Size = new System.Drawing.Size(29, 20);
            // 
            // detailsMenuItem
            // 
            this.detailsMenuItem.Name = "detailsMenuItem";
            this.detailsMenuItem.Size = new System.Drawing.Size(166, 22);
            this.detailsMenuItem.Text = "Details";
            this.detailsMenuItem.Click += new System.EventHandler(this.detailsMenuItem_Click);
            // 
            // detailsGroupedMenuItem
            // 
            this.detailsGroupedMenuItem.Name = "detailsGroupedMenuItem";
            this.detailsGroupedMenuItem.Size = new System.Drawing.Size(166, 22);
            this.detailsGroupedMenuItem.Text = "Details (Grouped)";
            this.detailsGroupedMenuItem.Click += new System.EventHandler(this.detailsGroupedMenuItem_Click);
            // 
            // largeIconsMenuItem
            // 
            this.largeIconsMenuItem.Name = "largeIconsMenuItem";
            this.largeIconsMenuItem.Size = new System.Drawing.Size(166, 22);
            this.largeIconsMenuItem.Text = "Large Icons";
            this.largeIconsMenuItem.Click += new System.EventHandler(this.largeIconsMenuItem_Click);
            // 
            // spacer
            // 
            this.spacer.Name = "spacer";
            this.spacer.Size = new System.Drawing.Size(1165, 17);
            this.spacer.Spring = true;
            // 
            // gamesCountLabel
            // 
            this.gamesCountLabel.Name = "gamesCountLabel";
            this.gamesCountLabel.Size = new System.Drawing.Size(52, 17);
            this.gamesCountLabel.Text = "0 Games";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.helpMenu,
            this.searchBox});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1261, 27);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createLibraryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 23);
            this.fileMenu.Text = "File";
            // 
            // createLibraryToolStripMenuItem
            // 
            this.createLibraryToolStripMenuItem.Name = "createLibraryToolStripMenuItem";
            this.createLibraryToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.createLibraryToolStripMenuItem.Text = "Create Library";
            this.createLibraryToolStripMenuItem.Click += new System.EventHandler(this.createLibraryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 23);
            this.editMenu.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 23);
            this.helpMenu.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aboutMenuItem.Text = "About emuLib";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // searchBox
            // 
            this.searchBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.searchBox.AutoSize = false;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Margin = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(160, 23);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // gameTitle
            // 
            this.gameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.Location = new System.Drawing.Point(934, 277);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(314, 36);
            this.gameTitle.TabIndex = 6;
            this.gameTitle.Text = "No game selected";
            this.gameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(933, 313);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(73, 13);
            this.manufacturerLabel.TabIndex = 7;
            this.manufacturerLabel.Text = "Manufacturer:";
            // 
            // yearLabel
            // 
            this.yearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(933, 326);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(49, 13);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.Text = "Release:";
            // 
            // genreLabel
            // 
            this.genreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(933, 339);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 9;
            this.genreLabel.Text = "Genre:";
            // 
            // readManualLabel
            // 
            this.readManualLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.readManualLabel.AutoSize = true;
            this.readManualLabel.Location = new System.Drawing.Point(933, 352);
            this.readManualLabel.Name = "readManualLabel";
            this.readManualLabel.Size = new System.Drawing.Size(70, 13);
            this.readManualLabel.TabIndex = 10;
            this.readManualLabel.TabStop = true;
            this.readManualLabel.Text = "Read manual";
            this.readManualLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.readManualLabel_LinkClicked);
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.Location = new System.Drawing.Point(6, 312);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(295, 23);
            this.playButton.TabIndex = 13;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(934, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(315, 244);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cartArt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(307, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cartridge";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cartArt
            // 
            this.cartArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cartArt.Location = new System.Drawing.Point(24, 29);
            this.cartArt.Name = "cartArt";
            this.cartArt.Size = new System.Drawing.Size(256, 159);
            this.cartArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartArt.TabIndex = 6;
            this.cartArt.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.boxArt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(307, 218);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cover";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // boxArt
            // 
            this.boxArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxArt.Location = new System.Drawing.Point(31, 8);
            this.boxArt.Name = "boxArt";
            this.boxArt.Size = new System.Drawing.Size(242, 201);
            this.boxArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxArt.TabIndex = 7;
            this.boxArt.TabStop = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(934, 380);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(315, 367);
            this.tabControl2.TabIndex = 15;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.descriptionBox);
            this.tabPage3.Controls.Add(this.playButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(307, 341);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Description";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionBox.BackColor = System.Drawing.SystemColors.Window;
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionBox.Location = new System.Drawing.Point(6, 6);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionBox.Size = new System.Drawing.Size(295, 300);
            this.descriptionBox.TabIndex = 13;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.loadButton);
            this.tabPage4.Controls.Add(this.saveTable);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(307, 341);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Savestates";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.Enabled = false;
            this.loadButton.Location = new System.Drawing.Point(6, 312);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(295, 23);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveTable
            // 
            this.saveTable.AllColumns.Add(this.nrColumn);
            this.saveTable.AllColumns.Add(this.nColumn);
            this.saveTable.AllColumns.Add(this.dateColumn);
            this.saveTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nrColumn,
            this.nColumn,
            this.dateColumn});
            this.saveTable.FullRowSelect = true;
            this.saveTable.Location = new System.Drawing.Point(6, 6);
            this.saveTable.MultiSelect = false;
            this.saveTable.Name = "saveTable";
            this.saveTable.OwnerDraw = true;
            this.saveTable.Size = new System.Drawing.Size(295, 300);
            this.saveTable.TabIndex = 0;
            this.saveTable.UseCompatibleStateImageBehavior = false;
            this.saveTable.UseFiltering = true;
            this.saveTable.View = System.Windows.Forms.View.Details;
            // 
            // nrColumn
            // 
            this.nrColumn.AspectName = "nr";
            this.nrColumn.MaximumWidth = 20;
            this.nrColumn.MinimumWidth = 20;
            this.nrColumn.Text = "#";
            this.nrColumn.Width = 20;
            // 
            // nColumn
            // 
            this.nColumn.AspectName = "savename";
            this.nColumn.AspectToStringFormat = "";
            this.nColumn.FillsFreeSpace = true;
            this.nColumn.Text = "Name";
            this.nColumn.Width = 140;
            // 
            // dateColumn
            // 
            this.dateColumn.AspectName = "date";
            this.dateColumn.MaximumWidth = 110;
            this.dateColumn.MinimumWidth = 110;
            this.dateColumn.Text = "Date";
            this.dateColumn.Width = 110;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 772);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.readManualLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.libTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainView";
            this.Text = "emuLib";
            ((System.ComponentModel.ISupportInitialize)(this.libTable)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartArt)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boxArt)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saveTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView libTable;
        private BrightIdeasSoftware.OLVColumn nameColumn;
        private BrightIdeasSoftware.OLVColumn genreColumn;
        private BrightIdeasSoftware.OLVColumn manColumn;
        private BrightIdeasSoftware.OLVColumn yearColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripTextBox searchBox;
        private System.Windows.Forms.ToolStripDropDownButton viewDropDownButton;
        private System.Windows.Forms.ToolStripStatusLabel spacer;
        private System.Windows.Forms.ToolStripStatusLabel gamesCountLabel;
        private System.Windows.Forms.ToolStripMenuItem detailsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsGroupedMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.LinkLabel readManualLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox cartArt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox boxArt;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button loadButton;
        private BrightIdeasSoftware.ObjectListView saveTable;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private BrightIdeasSoftware.OLVColumn nColumn;
        private BrightIdeasSoftware.OLVColumn dateColumn;
        private System.Windows.Forms.ToolStripMenuItem createLibraryToolStripMenuItem;
        private BrightIdeasSoftware.OLVColumn nrColumn;
    }
}

