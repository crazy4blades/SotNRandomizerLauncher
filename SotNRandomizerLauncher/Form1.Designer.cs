﻿namespace SotNRandomizerLauncher
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpNews = new System.Windows.Forms.GroupBox();
            this.lblWeekSeed = new System.Windows.Forms.LinkLabel();
            this.lblEventSubtext = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNextEvent = new System.Windows.Forms.Label();
            this.btnTutorials = new System.Windows.Forms.Button();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPlaceholder = new System.Windows.Forms.Button();
            this.grpTools = new System.Windows.Forms.GroupBox();
            this.pbBizhawk = new System.Windows.Forms.PictureBox();
            this.pbLiveSplit = new System.Windows.Forms.PictureBox();
            this.pbRandoTools = new System.Windows.Forms.PictureBox();
            this.lblBizhawk = new System.Windows.Forms.Label();
            this.lblLivesplit = new System.Windows.Forms.Label();
            this.lblRandoTools = new System.Windows.Forms.Label();
            this.btnUpdateBizhawk = new System.Windows.Forms.Button();
            this.btnUpdateLiveSplit = new System.Windows.Forms.Button();
            this.btnUpdateRandoTools = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.grpSeed = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pgbRandomizing = new System.Windows.Forms.ProgressBar();
            this.lblSelectedSeed = new System.Windows.Forms.Label();
            this.btnPpfFile = new System.Windows.Forms.Button();
            this.lblPlayLastSeed = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblOfflineMode = new System.Windows.Forms.Label();
            this.lblPalette = new System.Windows.Forms.Label();
            this.lblLiner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReloadSkin = new System.Windows.Forms.Button();
            this.btnRandomizer = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCore = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPalette = new System.Windows.Forms.ComboBox();
            this.cbLiner = new System.Windows.Forms.ComboBox();
            this.grpNews.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.grpTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBizhawk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLiveSplit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRandoTools)).BeginInit();
            this.grpSeed.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNews
            // 
            this.grpNews.BackColor = System.Drawing.Color.Transparent;
            this.grpNews.Controls.Add(this.lblWeekSeed);
            this.grpNews.Controls.Add(this.lblEventSubtext);
            this.grpNews.Controls.Add(this.label2);
            this.grpNews.Controls.Add(this.lblNextEvent);
            this.grpNews.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.grpNews.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpNews.Location = new System.Drawing.Point(15, 12);
            this.grpNews.Name = "grpNews";
            this.grpNews.Size = new System.Drawing.Size(444, 100);
            this.grpNews.TabIndex = 0;
            this.grpNews.TabStop = false;
            this.grpNews.Text = "News";
            // 
            // lblWeekSeed
            // 
            this.lblWeekSeed.AutoSize = true;
            this.lblWeekSeed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWeekSeed.LinkColor = System.Drawing.Color.IndianRed;
            this.lblWeekSeed.Location = new System.Drawing.Point(157, 69);
            this.lblWeekSeed.Name = "lblWeekSeed";
            this.lblWeekSeed.Size = new System.Drawing.Size(156, 21);
            this.lblWeekSeed.TabIndex = 3;
            this.lblWeekSeed.TabStop = true;
            this.lblWeekSeed.Text = "Seed Not Available";
            this.lblWeekSeed.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblEventSubtext
            // 
            this.lblEventSubtext.Location = new System.Drawing.Point(107, 39);
            this.lblEventSubtext.Name = "lblEventSubtext";
            this.lblEventSubtext.Size = new System.Drawing.Size(331, 28);
            this.lblEventSubtext.TabIndex = 2;
            this.lblEventSubtext.Text = "Event info not available\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seed of the Week: ";
            // 
            // lblNextEvent
            // 
            this.lblNextEvent.AutoSize = true;
            this.lblNextEvent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNextEvent.Location = new System.Drawing.Point(14, 18);
            this.lblNextEvent.Name = "lblNextEvent";
            this.lblNextEvent.Size = new System.Drawing.Size(284, 21);
            this.lblNextEvent.TabIndex = 0;
            this.lblNextEvent.Text = "Next Event: Event title not available";
            // 
            // btnTutorials
            // 
            this.btnTutorials.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnTutorials.Location = new System.Drawing.Point(552, 17);
            this.btnTutorials.Name = "btnTutorials";
            this.btnTutorials.Size = new System.Drawing.Size(164, 29);
            this.btnTutorials.TabIndex = 1;
            this.btnTutorials.Text = "Tutorials";
            this.btnTutorials.UseVisualStyleBackColor = true;
            this.btnTutorials.Click += new System.EventHandler(this.btnTutorials_Click);
            // 
            // btnConfigure
            // 
            this.btnConfigure.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnConfigure.Location = new System.Drawing.Point(552, 83);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(164, 29);
            this.btnConfigure.TabIndex = 2;
            this.btnConfigure.Text = "Settings";
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpOptions
            // 
            this.grpOptions.BackColor = System.Drawing.Color.Transparent;
            this.grpOptions.Controls.Add(this.button1);
            this.grpOptions.Controls.Add(this.btnPlaceholder);
            this.grpOptions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.grpOptions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpOptions.Location = new System.Drawing.Point(538, 138);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(189, 152);
            this.grpOptions.TabIndex = 3;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Community and Tools";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(14, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Profile and Leaderboards";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnPlaceholder
            // 
            this.btnPlaceholder.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnPlaceholder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlaceholder.Location = new System.Drawing.Point(14, 21);
            this.btnPlaceholder.Name = "btnPlaceholder";
            this.btnPlaceholder.Size = new System.Drawing.Size(164, 29);
            this.btnPlaceholder.TabIndex = 11;
            this.btnPlaceholder.Text = "Replay Viewer";
            this.btnPlaceholder.UseVisualStyleBackColor = true;
            this.btnPlaceholder.Click += new System.EventHandler(this.btnPlaceholder_Click);
            // 
            // grpTools
            // 
            this.grpTools.BackColor = System.Drawing.Color.Transparent;
            this.grpTools.Controls.Add(this.pbBizhawk);
            this.grpTools.Controls.Add(this.pbLiveSplit);
            this.grpTools.Controls.Add(this.pbRandoTools);
            this.grpTools.Controls.Add(this.lblBizhawk);
            this.grpTools.Controls.Add(this.lblLivesplit);
            this.grpTools.Controls.Add(this.lblRandoTools);
            this.grpTools.Controls.Add(this.btnUpdateBizhawk);
            this.grpTools.Controls.Add(this.btnUpdateLiveSplit);
            this.grpTools.Controls.Add(this.btnUpdateRandoTools);
            this.grpTools.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.grpTools.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpTools.Location = new System.Drawing.Point(15, 138);
            this.grpTools.Name = "grpTools";
            this.grpTools.Size = new System.Drawing.Size(444, 152);
            this.grpTools.TabIndex = 7;
            this.grpTools.TabStop = false;
            this.grpTools.Text = "Tool Versions";
            // 
            // pbBizhawk
            // 
            this.pbBizhawk.Image = global::SotNRandomizerLauncher.Properties.Resources.v_update;
            this.pbBizhawk.InitialImage = global::SotNRandomizerLauncher.Properties.Resources.v_update;
            this.pbBizhawk.Location = new System.Drawing.Point(210, 109);
            this.pbBizhawk.Name = "pbBizhawk";
            this.pbBizhawk.Size = new System.Drawing.Size(30, 30);
            this.pbBizhawk.TabIndex = 12;
            this.pbBizhawk.TabStop = false;
            this.toolTip.SetToolTip(this.pbBizhawk, "Double Click Here to force an update.");
            this.pbBizhawk.Click += new System.EventHandler(this.pbBizhawk_Click);
            // 
            // pbLiveSplit
            // 
            this.pbLiveSplit.Image = global::SotNRandomizerLauncher.Properties.Resources.v_update;
            this.pbLiveSplit.InitialImage = global::SotNRandomizerLauncher.Properties.Resources.v_update;
            this.pbLiveSplit.Location = new System.Drawing.Point(210, 65);
            this.pbLiveSplit.Name = "pbLiveSplit";
            this.pbLiveSplit.Size = new System.Drawing.Size(30, 30);
            this.pbLiveSplit.TabIndex = 11;
            this.pbLiveSplit.TabStop = false;
            this.toolTip.SetToolTip(this.pbLiveSplit, "Double Click Here to force an update.");
            this.pbLiveSplit.DoubleClick += new System.EventHandler(this.pbLiveSplit_DoubleClick);
            // 
            // pbRandoTools
            // 
            this.pbRandoTools.Image = global::SotNRandomizerLauncher.Properties.Resources.v_update;
            this.pbRandoTools.InitialImage = global::SotNRandomizerLauncher.Properties.Resources.v_update;
            this.pbRandoTools.Location = new System.Drawing.Point(210, 20);
            this.pbRandoTools.Name = "pbRandoTools";
            this.pbRandoTools.Size = new System.Drawing.Size(30, 30);
            this.pbRandoTools.TabIndex = 10;
            this.pbRandoTools.TabStop = false;
            this.toolTip.SetToolTip(this.pbRandoTools, "Double Click Here to force an update.");
            this.pbRandoTools.DoubleClick += new System.EventHandler(this.pbRandoTools_DoubleClick);
            // 
            // lblBizhawk
            // 
            this.lblBizhawk.AutoSize = true;
            this.lblBizhawk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBizhawk.Location = new System.Drawing.Point(15, 115);
            this.lblBizhawk.Name = "lblBizhawk";
            this.lblBizhawk.Size = new System.Drawing.Size(98, 17);
            this.lblBizhawk.TabIndex = 9;
            this.lblBizhawk.Text = "Bizhawk v1.4.3";
            // 
            // lblLivesplit
            // 
            this.lblLivesplit.AutoSize = true;
            this.lblLivesplit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLivesplit.Location = new System.Drawing.Point(15, 70);
            this.lblLivesplit.Name = "lblLivesplit";
            this.lblLivesplit.Size = new System.Drawing.Size(101, 17);
            this.lblLivesplit.TabIndex = 8;
            this.lblLivesplit.Text = "LiveSplit v1.8.2";
            // 
            // lblRandoTools
            // 
            this.lblRandoTools.AutoSize = true;
            this.lblRandoTools.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRandoTools.Location = new System.Drawing.Point(15, 26);
            this.lblRandoTools.Name = "lblRandoTools";
            this.lblRandoTools.Size = new System.Drawing.Size(147, 17);
            this.lblRandoTools.TabIndex = 7;
            this.lblRandoTools.Text = "SotN Rando Tools v1.9";
            // 
            // btnUpdateBizhawk
            // 
            this.btnUpdateBizhawk.Enabled = false;
            this.btnUpdateBizhawk.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnUpdateBizhawk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateBizhawk.Location = new System.Drawing.Point(246, 110);
            this.btnUpdateBizhawk.Name = "btnUpdateBizhawk";
            this.btnUpdateBizhawk.Size = new System.Drawing.Size(182, 29);
            this.btnUpdateBizhawk.TabIndex = 6;
            this.btnUpdateBizhawk.Text = "Up to Date";
            this.btnUpdateBizhawk.UseVisualStyleBackColor = true;
            this.btnUpdateBizhawk.Click += new System.EventHandler(this.btnUpdateBizhawk_Click);
            // 
            // btnUpdateLiveSplit
            // 
            this.btnUpdateLiveSplit.Enabled = false;
            this.btnUpdateLiveSplit.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnUpdateLiveSplit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateLiveSplit.Location = new System.Drawing.Point(246, 65);
            this.btnUpdateLiveSplit.Name = "btnUpdateLiveSplit";
            this.btnUpdateLiveSplit.Size = new System.Drawing.Size(182, 29);
            this.btnUpdateLiveSplit.TabIndex = 5;
            this.btnUpdateLiveSplit.Text = "Up to Date";
            this.btnUpdateLiveSplit.UseVisualStyleBackColor = true;
            this.btnUpdateLiveSplit.Click += new System.EventHandler(this.btnUpdateLiveSplit_Click);
            // 
            // btnUpdateRandoTools
            // 
            this.btnUpdateRandoTools.Enabled = false;
            this.btnUpdateRandoTools.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnUpdateRandoTools.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateRandoTools.Location = new System.Drawing.Point(246, 21);
            this.btnUpdateRandoTools.Name = "btnUpdateRandoTools";
            this.btnUpdateRandoTools.Size = new System.Drawing.Size(182, 29);
            this.btnUpdateRandoTools.TabIndex = 4;
            this.btnUpdateRandoTools.Text = "Up to Date";
            this.btnUpdateRandoTools.UseVisualStyleBackColor = true;
            this.btnUpdateRandoTools.Click += new System.EventHandler(this.btnUpdateRandoTools_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlay.Location = new System.Drawing.Point(538, 371);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(189, 95);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // grpSeed
            // 
            this.grpSeed.BackColor = System.Drawing.Color.Transparent;
            this.grpSeed.Controls.Add(this.lblStatus);
            this.grpSeed.Controls.Add(this.pgbRandomizing);
            this.grpSeed.Controls.Add(this.lblSelectedSeed);
            this.grpSeed.Controls.Add(this.btnPpfFile);
            this.grpSeed.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.grpSeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpSeed.Location = new System.Drawing.Point(15, 365);
            this.grpSeed.Name = "grpSeed";
            this.grpSeed.Size = new System.Drawing.Size(517, 101);
            this.grpSeed.TabIndex = 1;
            this.grpSeed.TabStop = false;
            this.grpSeed.Text = "Select Seed";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(243, 72);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(148, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Waiting for Randomization";
            // 
            // pgbRandomizing
            // 
            this.pgbRandomizing.Location = new System.Drawing.Point(246, 46);
            this.pgbRandomizing.Name = "pgbRandomizing";
            this.pgbRandomizing.Size = new System.Drawing.Size(250, 23);
            this.pgbRandomizing.TabIndex = 2;
            // 
            // lblSelectedSeed
            // 
            this.lblSelectedSeed.AutoSize = true;
            this.lblSelectedSeed.Location = new System.Drawing.Point(243, 30);
            this.lblSelectedSeed.Name = "lblSelectedSeed";
            this.lblSelectedSeed.Size = new System.Drawing.Size(97, 13);
            this.lblSelectedSeed.TabIndex = 1;
            this.lblSelectedSeed.Text = "No Seed Selected";
            this.lblSelectedSeed.Click += new System.EventHandler(this.lblSelectedSeed_Click);
            // 
            // btnPpfFile
            // 
            this.btnPpfFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPpfFile.FlatAppearance.BorderSize = 0;
            this.btnPpfFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnPpfFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnPpfFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPpfFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPpfFile.ForeColor = System.Drawing.Color.Transparent;
            this.btnPpfFile.Image = global::SotNRandomizerLauncher.Properties.Resources.upload_icon;
            this.btnPpfFile.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnPpfFile.Location = new System.Drawing.Point(18, 30);
            this.btnPpfFile.Name = "btnPpfFile";
            this.btnPpfFile.Size = new System.Drawing.Size(210, 49);
            this.btnPpfFile.TabIndex = 0;
            this.btnPpfFile.Text = "Select your Randomizer\r\nSeed file (.ppf)";
            this.btnPpfFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPpfFile.UseVisualStyleBackColor = false;
            this.btnPpfFile.Click += new System.EventHandler(this.btnPpfFile_Click);
            this.btnPpfFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnPpfFile_DragDrop);
            // 
            // lblPlayLastSeed
            // 
            this.lblPlayLastSeed.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayLastSeed.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblPlayLastSeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayLastSeed.Location = new System.Drawing.Point(538, 465);
            this.lblPlayLastSeed.Name = "lblPlayLastSeed";
            this.lblPlayLastSeed.Size = new System.Drawing.Size(247, 37);
            this.lblPlayLastSeed.TabIndex = 3;
            this.lblPlayLastSeed.Text = "Play Last Seed:\r\n-seedname-";
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 200;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 200;
            this.toolTip.ReshowDelay = 40;
            // 
            // lblOfflineMode
            // 
            this.lblOfflineMode.AutoSize = true;
            this.lblOfflineMode.BackColor = System.Drawing.Color.Transparent;
            this.lblOfflineMode.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblOfflineMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOfflineMode.Location = new System.Drawing.Point(662, 1);
            this.lblOfflineMode.Name = "lblOfflineMode";
            this.lblOfflineMode.Size = new System.Drawing.Size(76, 13);
            this.lblOfflineMode.TabIndex = 9;
            this.lblOfflineMode.Text = "Offline Mode";
            this.toolTip.SetToolTip(this.lblOfflineMode, "You have no internet connection. Restart the Launcher when you have connection to" +
        " reload the Launcher.");
            this.lblOfflineMode.Visible = false;
            // 
            // lblPalette
            // 
            this.lblPalette.AutoSize = true;
            this.lblPalette.BackColor = System.Drawing.Color.Transparent;
            this.lblPalette.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblPalette.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPalette.Location = new System.Drawing.Point(73, 18);
            this.lblPalette.Name = "lblPalette";
            this.lblPalette.Size = new System.Drawing.Size(84, 13);
            this.lblPalette.TabIndex = 14;
            this.lblPalette.Text = "Alucard Palette";
            this.toolTip.SetToolTip(this.lblPalette, "You have no internet connection. Restart the Launcher when you have connection to" +
        " reload the Launcher.");
            // 
            // lblLiner
            // 
            this.lblLiner.AutoSize = true;
            this.lblLiner.BackColor = System.Drawing.Color.Transparent;
            this.lblLiner.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblLiner.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLiner.Location = new System.Drawing.Point(222, 18);
            this.lblLiner.Name = "lblLiner";
            this.lblLiner.Size = new System.Drawing.Size(74, 13);
            this.lblLiner.TabIndex = 15;
            this.lblLiner.Text = "Alucard Liner";
            this.toolTip.SetToolTip(this.lblLiner, "You have no internet connection. Restart the Launcher when you have connection to" +
        " reload the Launcher.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "?";
            this.toolTip.SetToolTip(this.label1, "Modifies the Colors of Alucard in-game. You must choose\r\nyour Palette & Liner bef" +
        "ore selecting the PPF file.\r\nClick to see all the possible Skins (will open in y" +
        "our browser).");
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btnReloadSkin
            // 
            this.btnReloadSkin.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnReloadSkin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReloadSkin.Location = new System.Drawing.Point(354, 332);
            this.btnReloadSkin.Name = "btnReloadSkin";
            this.btnReloadSkin.Size = new System.Drawing.Size(97, 21);
            this.btnReloadSkin.TabIndex = 13;
            this.btnReloadSkin.Text = "Reload Skin";
            this.toolTip.SetToolTip(this.btnReloadSkin, "Skins are loaded when you select the Randomizer Seed.\r\nPress here if you haven\'t " +
        "selected your preferred skin\r\nbefore loading the Randomizer Seed file.");
            this.btnReloadSkin.UseVisualStyleBackColor = true;
            this.btnReloadSkin.Click += new System.EventHandler(this.btnReloadSkin_Click);
            // 
            // btnRandomizer
            // 
            this.btnRandomizer.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnRandomizer.Location = new System.Drawing.Point(552, 50);
            this.btnRandomizer.Name = "btnRandomizer";
            this.btnRandomizer.Size = new System.Drawing.Size(164, 29);
            this.btnRandomizer.TabIndex = 8;
            this.btnRandomizer.Text = "Randomizer";
            this.btnRandomizer.UseVisualStyleBackColor = true;
            this.btnRandomizer.Click += new System.EventHandler(this.btnRandomizer_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 6.75F);
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVersion.Location = new System.Drawing.Point(1, 482);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(28, 12);
            this.lblVersion.TabIndex = 10;
            this.lblVersion.Text = "v0.4.4";
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // lblCore
            // 
            this.lblCore.BackColor = System.Drawing.Color.Transparent;
            this.lblCore.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCore.Location = new System.Drawing.Point(611, 355);
            this.lblCore.Name = "lblCore";
            this.lblCore.Size = new System.Drawing.Size(116, 14);
            this.lblCore.TabIndex = 11;
            this.lblCore.Text = "Core: FastCore";
            this.lblCore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCore.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbPalette);
            this.groupBox1.Controls.Add(this.cbLiner);
            this.groupBox1.Controls.Add(this.lblLiner);
            this.groupBox1.Controls.Add(this.lblPalette);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(15, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 63);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visual Customization";
            // 
            // cbPalette
            // 
            this.cbPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPalette.FormattingEnabled = true;
            this.cbPalette.Items.AddRange(new object[] {
            "Dark Cloth (Default)",
            "Bloody Tears",
            "Blue Danube",
            "Swamp Thing",
            "White Knight",
            "Royal Purple",
            "Pink Passion",
            "Shadow Prince",
            "Disabled",
            "Random"});
            this.cbPalette.Location = new System.Drawing.Point(50, 36);
            this.cbPalette.Name = "cbPalette";
            this.cbPalette.Size = new System.Drawing.Size(135, 21);
            this.cbPalette.TabIndex = 16;
            // 
            // cbLiner
            // 
            this.cbLiner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLiner.FormattingEnabled = true;
            this.cbLiner.Items.AddRange(new object[] {
            "Gold Trim (Default)",
            "Silver Trim",
            "Bronze Trim",
            "Onyx Trim",
            "Coral Trim",
            "Disabled",
            "Random"});
            this.cbLiner.Location = new System.Drawing.Point(194, 36);
            this.cbLiner.Name = "cbLiner";
            this.cbLiner.Size = new System.Drawing.Size(135, 21);
            this.cbLiner.TabIndex = 14;
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SotNRandomizerLauncher.Properties.Resources.gradient;
            this.ClientSize = new System.Drawing.Size(739, 497);
            this.Controls.Add(this.btnReloadSkin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblOfflineMode);
            this.Controls.Add(this.btnRandomizer);
            this.Controls.Add(this.lblPlayLastSeed);
            this.Controls.Add(this.grpSeed);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grpTools);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.btnConfigure);
            this.Controls.Add(this.btnTutorials);
            this.Controls.Add(this.grpNews);
            this.Controls.Add(this.lblCore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Symphony of the Night Randomizer Launcher";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.DragLeave += new System.EventHandler(this.frmMain_DragLeave);
            this.grpNews.ResumeLayout(false);
            this.grpNews.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpTools.ResumeLayout(false);
            this.grpTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBizhawk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLiveSplit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRandoTools)).EndInit();
            this.grpSeed.ResumeLayout(false);
            this.grpSeed.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNews;
        private System.Windows.Forms.Button btnTutorials;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.GroupBox grpTools;
        private System.Windows.Forms.PictureBox pbRandoTools;
        private System.Windows.Forms.Label lblBizhawk;
        private System.Windows.Forms.Label lblLivesplit;
        private System.Windows.Forms.Label lblRandoTools;
        private System.Windows.Forms.Button btnUpdateBizhawk;
        private System.Windows.Forms.Button btnUpdateLiveSplit;
        private System.Windows.Forms.Button btnUpdateRandoTools;
        private System.Windows.Forms.PictureBox pbBizhawk;
        private System.Windows.Forms.PictureBox pbLiveSplit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox grpSeed;
        private System.Windows.Forms.Button btnPpfFile;
        private System.Windows.Forms.ProgressBar pgbRandomizing;
        private System.Windows.Forms.Label lblSelectedSeed;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEventSubtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNextEvent;
        private System.Windows.Forms.Label lblPlayLastSeed;
        private System.Windows.Forms.LinkLabel lblWeekSeed;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnRandomizer;
        private System.Windows.Forms.Label lblOfflineMode;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnPlaceholder;
        private System.Windows.Forms.Label lblCore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPalette;
        private System.Windows.Forms.ComboBox cbLiner;
        private System.Windows.Forms.Label lblLiner;
        private System.Windows.Forms.Label lblPalette;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReloadSkin;
    }
}

