namespace PA_Manager
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPrefs = new System.Windows.Forms.TabPage();
            this.pPrefs = new System.Windows.Forms.Panel();
            this.tbTLQual = new System.Windows.Forms.TextBox();
            this.tbTLFPSDen = new System.Windows.Forms.TextBox();
            this.tbTLFPSNum = new System.Windows.Forms.TextBox();
            this.tbTLInt = new System.Windows.Forms.TextBox();
            this.tbTLCam = new System.Windows.Forms.TextBox();
            this.tbLKVer = new System.Windows.Forms.TextBox();
            this.tbHCompat = new System.Windows.Forms.TextBox();
            this.tbASTimer = new System.Windows.Forms.TextBox();
            this.tbRMap = new System.Windows.Forms.TextBox();
            this.tbSVol = new System.Windows.Forms.TextBox();
            this.tbSMFreq = new System.Windows.Forms.TextBox();
            this.tbSHeight = new System.Windows.Forms.TextBox();
            this.tbSWidth = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFirstTime = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRRooms = new System.Windows.Forms.CheckBox();
            this.cbEnableDSP = new System.Windows.Forms.CheckBox();
            this.cbSwapStereo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSSampled = new System.Windows.Forms.CheckBox();
            this.cbMSampled = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFullScreen = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpSaves = new System.Windows.Forms.TabPage();
            this.btnRename = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lbSavedGames = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeGameDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToSystemTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutPAManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tpPrefs.SuspendLayout();
            this.pPrefs.SuspendLayout();
            this.tpSaves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPrefs);
            this.tabControl1.Controls.Add(this.tpSaves);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 548);
            this.tabControl1.TabIndex = 21;
            // 
            // tpPrefs
            // 
            this.tpPrefs.Controls.Add(this.pPrefs);
            this.tpPrefs.Location = new System.Drawing.Point(4, 22);
            this.tpPrefs.Name = "tpPrefs";
            this.tpPrefs.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrefs.Size = new System.Drawing.Size(352, 522);
            this.tpPrefs.TabIndex = 0;
            this.tpPrefs.Text = "Preferences";
            this.tpPrefs.UseVisualStyleBackColor = true;
            // 
            // pPrefs
            // 
            this.pPrefs.Controls.Add(this.tbTLQual);
            this.pPrefs.Controls.Add(this.tbTLFPSDen);
            this.pPrefs.Controls.Add(this.tbTLFPSNum);
            this.pPrefs.Controls.Add(this.tbTLInt);
            this.pPrefs.Controls.Add(this.tbTLCam);
            this.pPrefs.Controls.Add(this.tbLKVer);
            this.pPrefs.Controls.Add(this.tbHCompat);
            this.pPrefs.Controls.Add(this.tbASTimer);
            this.pPrefs.Controls.Add(this.tbRMap);
            this.pPrefs.Controls.Add(this.tbSVol);
            this.pPrefs.Controls.Add(this.tbSMFreq);
            this.pPrefs.Controls.Add(this.tbSHeight);
            this.pPrefs.Controls.Add(this.tbSWidth);
            this.pPrefs.Controls.Add(this.label13);
            this.pPrefs.Controls.Add(this.label12);
            this.pPrefs.Controls.Add(this.label11);
            this.pPrefs.Controls.Add(this.label10);
            this.pPrefs.Controls.Add(this.label9);
            this.pPrefs.Controls.Add(this.label8);
            this.pPrefs.Controls.Add(this.label7);
            this.pPrefs.Controls.Add(this.label6);
            this.pPrefs.Controls.Add(this.cbFirstTime);
            this.pPrefs.Controls.Add(this.label5);
            this.pPrefs.Controls.Add(this.cbRRooms);
            this.pPrefs.Controls.Add(this.cbEnableDSP);
            this.pPrefs.Controls.Add(this.cbSwapStereo);
            this.pPrefs.Controls.Add(this.label4);
            this.pPrefs.Controls.Add(this.cbSSampled);
            this.pPrefs.Controls.Add(this.cbMSampled);
            this.pPrefs.Controls.Add(this.label3);
            this.pPrefs.Controls.Add(this.cbFullScreen);
            this.pPrefs.Controls.Add(this.label2);
            this.pPrefs.Controls.Add(this.label1);
            this.pPrefs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrefs.Location = new System.Drawing.Point(3, 3);
            this.pPrefs.Name = "pPrefs";
            this.pPrefs.Size = new System.Drawing.Size(346, 516);
            this.pPrefs.TabIndex = 4;
            // 
            // tbTLQual
            // 
            this.tbTLQual.Location = new System.Drawing.Point(156, 488);
            this.tbTLQual.Name = "tbTLQual";
            this.tbTLQual.Size = new System.Drawing.Size(45, 20);
            this.tbTLQual.TabIndex = 20;
            // 
            // tbTLFPSDen
            // 
            this.tbTLFPSDen.Location = new System.Drawing.Point(156, 462);
            this.tbTLFPSDen.Name = "tbTLFPSDen";
            this.tbTLFPSDen.Size = new System.Drawing.Size(45, 20);
            this.tbTLFPSDen.TabIndex = 19;
            // 
            // tbTLFPSNum
            // 
            this.tbTLFPSNum.Location = new System.Drawing.Point(156, 436);
            this.tbTLFPSNum.Name = "tbTLFPSNum";
            this.tbTLFPSNum.Size = new System.Drawing.Size(45, 20);
            this.tbTLFPSNum.TabIndex = 18;
            // 
            // tbTLInt
            // 
            this.tbTLInt.Location = new System.Drawing.Point(156, 410);
            this.tbTLInt.Name = "tbTLInt";
            this.tbTLInt.Size = new System.Drawing.Size(45, 20);
            this.tbTLInt.TabIndex = 17;
            // 
            // tbTLCam
            // 
            this.tbTLCam.Location = new System.Drawing.Point(156, 384);
            this.tbTLCam.Name = "tbTLCam";
            this.tbTLCam.Size = new System.Drawing.Size(45, 20);
            this.tbTLCam.TabIndex = 16;
            // 
            // tbLKVer
            // 
            this.tbLKVer.Location = new System.Drawing.Point(156, 358);
            this.tbLKVer.Name = "tbLKVer";
            this.tbLKVer.Size = new System.Drawing.Size(150, 20);
            this.tbLKVer.TabIndex = 15;
            // 
            // tbHCompat
            // 
            this.tbHCompat.Location = new System.Drawing.Point(156, 332);
            this.tbHCompat.Name = "tbHCompat";
            this.tbHCompat.Size = new System.Drawing.Size(45, 20);
            this.tbHCompat.TabIndex = 14;
            // 
            // tbASTimer
            // 
            this.tbASTimer.Location = new System.Drawing.Point(156, 306);
            this.tbASTimer.Name = "tbASTimer";
            this.tbASTimer.Size = new System.Drawing.Size(45, 20);
            this.tbASTimer.TabIndex = 13;
            // 
            // tbRMap
            // 
            this.tbRMap.Location = new System.Drawing.Point(156, 257);
            this.tbRMap.Name = "tbRMap";
            this.tbRMap.Size = new System.Drawing.Size(150, 20);
            this.tbRMap.TabIndex = 11;
            // 
            // tbSVol
            // 
            this.tbSVol.Location = new System.Drawing.Point(156, 162);
            this.tbSVol.Name = "tbSVol";
            this.tbSVol.Size = new System.Drawing.Size(45, 20);
            this.tbSVol.TabIndex = 7;
            // 
            // tbSMFreq
            // 
            this.tbSMFreq.Location = new System.Drawing.Point(156, 136);
            this.tbSMFreq.Name = "tbSMFreq";
            this.tbSMFreq.Size = new System.Drawing.Size(45, 20);
            this.tbSMFreq.TabIndex = 6;
            // 
            // tbSHeight
            // 
            this.tbSHeight.Location = new System.Drawing.Point(156, 41);
            this.tbSHeight.Name = "tbSHeight";
            this.tbSHeight.Size = new System.Drawing.Size(45, 20);
            this.tbSHeight.TabIndex = 1;
            // 
            // tbSWidth
            // 
            this.tbSWidth.Location = new System.Drawing.Point(156, 15);
            this.tbSWidth.Name = "tbSWidth";
            this.tbSWidth.Size = new System.Drawing.Size(45, 20);
            this.tbSWidth.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 491);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Time Lapse Quality:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 465);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Time Laps FPS Denominator:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 439);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Time Lapse FPS Numerator:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Time Lapse Interval:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Time Lapse Camera:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Last Known Version:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hardware Compat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "AutoSave Timer:";
            // 
            // cbFirstTime
            // 
            this.cbFirstTime.AutoSize = true;
            this.cbFirstTime.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbFirstTime.Location = new System.Drawing.Point(71, 283);
            this.cbFirstTime.Name = "cbFirstTime";
            this.cbFirstTime.Size = new System.Drawing.Size(97, 17);
            this.cbFirstTime.TabIndex = 12;
            this.cbFirstTime.Text = "First Time Run:";
            this.cbFirstTime.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Recent Map:";
            // 
            // cbRRooms
            // 
            this.cbRRooms.AutoSize = true;
            this.cbRRooms.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbRRooms.Location = new System.Drawing.Point(68, 234);
            this.cbRRooms.Name = "cbRRooms";
            this.cbRRooms.Size = new System.Drawing.Size(100, 17);
            this.cbRRooms.TabIndex = 10;
            this.cbRRooms.Text = "Render Rooms:";
            this.cbRRooms.UseVisualStyleBackColor = true;
            // 
            // cbEnableDSP
            // 
            this.cbEnableDSP.AutoSize = true;
            this.cbEnableDSP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbEnableDSP.Location = new System.Drawing.Point(81, 211);
            this.cbEnableDSP.Name = "cbEnableDSP";
            this.cbEnableDSP.Size = new System.Drawing.Size(87, 17);
            this.cbEnableDSP.TabIndex = 9;
            this.cbEnableDSP.Text = "Enable DSP:";
            this.cbEnableDSP.UseVisualStyleBackColor = true;
            // 
            // cbSwapStereo
            // 
            this.cbSwapStereo.AutoSize = true;
            this.cbSwapStereo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbSwapStereo.Location = new System.Drawing.Point(78, 188);
            this.cbSwapStereo.Name = "cbSwapStereo";
            this.cbSwapStereo.Size = new System.Drawing.Size(90, 17);
            this.cbSwapStereo.TabIndex = 8;
            this.cbSwapStereo.Text = "Swap Stereo:";
            this.cbSwapStereo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sound Volume:";
            // 
            // cbSSampled
            // 
            this.cbSSampled.AutoSize = true;
            this.cbSSampled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbSSampled.Location = new System.Drawing.Point(70, 113);
            this.cbSSampled.Name = "cbSSampled";
            this.cbSSampled.Size = new System.Drawing.Size(98, 17);
            this.cbSSampled.TabIndex = 5;
            this.cbSSampled.Text = "SuperSampled:";
            this.cbSSampled.UseVisualStyleBackColor = true;
            // 
            // cbMSampled
            // 
            this.cbMSampled.AutoSize = true;
            this.cbMSampled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbMSampled.Location = new System.Drawing.Point(76, 90);
            this.cbMSampled.Name = "cbMSampled";
            this.cbMSampled.Size = new System.Drawing.Size(92, 17);
            this.cbMSampled.TabIndex = 3;
            this.cbMSampled.Text = "MultiSampled:";
            this.cbMSampled.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sound Mix Frequency:";
            // 
            // cbFullScreen
            // 
            this.cbFullScreen.AutoSize = true;
            this.cbFullScreen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbFullScreen.Location = new System.Drawing.Point(91, 67);
            this.cbFullScreen.Name = "cbFullScreen";
            this.cbFullScreen.Size = new System.Drawing.Size(80, 17);
            this.cbFullScreen.TabIndex = 2;
            this.cbFullScreen.Text = "Windowed:";
            this.cbFullScreen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Screen Height:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Screen Width:";
            // 
            // tpSaves
            // 
            this.tpSaves.Controls.Add(this.btnRename);
            this.tpSaves.Controls.Add(this.pbPreview);
            this.tpSaves.Controls.Add(this.btnNew);
            this.tpSaves.Controls.Add(this.btnDelete);
            this.tpSaves.Controls.Add(this.btnEdit);
            this.tpSaves.Controls.Add(this.btnCopy);
            this.tpSaves.Controls.Add(this.lbSavedGames);
            this.tpSaves.Location = new System.Drawing.Point(4, 22);
            this.tpSaves.Name = "tpSaves";
            this.tpSaves.Padding = new System.Windows.Forms.Padding(3);
            this.tpSaves.Size = new System.Drawing.Size(352, 522);
            this.tpSaves.TabIndex = 1;
            this.tpSaves.Text = "Saved Games";
            this.tpSaves.UseVisualStyleBackColor = true;
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(234, 126);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 5;
            this.btnRename.Text = "&Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPreview.Location = new System.Drawing.Point(8, 250);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(336, 210);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPreview.TabIndex = 5;
            this.pbPreview.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(234, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(234, 97);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(234, 39);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(234, 68);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "&Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lbSavedGames
            // 
            this.lbSavedGames.FormattingEnabled = true;
            this.lbSavedGames.Location = new System.Drawing.Point(8, 6);
            this.lbSavedGames.Name = "lbSavedGames";
            this.lbSavedGames.Size = new System.Drawing.Size(220, 238);
            this.lbSavedGames.TabIndex = 0;
            this.lbSavedGames.SelectedIndexChanged += new System.EventHandler(this.lbSavedGames_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(360, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadPreferencesToolStripMenuItem,
            this.savePreferencesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // reloadPreferencesToolStripMenuItem
            // 
            this.reloadPreferencesToolStripMenuItem.Name = "reloadPreferencesToolStripMenuItem";
            this.reloadPreferencesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.reloadPreferencesToolStripMenuItem.Text = "&Reload Preferences";
            this.reloadPreferencesToolStripMenuItem.Click += new System.EventHandler(this.reloadPreferencesToolStripMenuItem_Click);
            // 
            // savePreferencesToolStripMenuItem
            // 
            this.savePreferencesToolStripMenuItem.Name = "savePreferencesToolStripMenuItem";
            this.savePreferencesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.savePreferencesToolStripMenuItem.Text = "&Save Preferences";
            this.savePreferencesToolStripMenuItem.Click += new System.EventHandler(this.savePreferencesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeGameDirectoryToolStripMenuItem,
            this.minimizeToSystemTrayToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // changeGameDirectoryToolStripMenuItem
            // 
            this.changeGameDirectoryToolStripMenuItem.Name = "changeGameDirectoryToolStripMenuItem";
            this.changeGameDirectoryToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.changeGameDirectoryToolStripMenuItem.Text = "&Change Game Directory";
            this.changeGameDirectoryToolStripMenuItem.Click += new System.EventHandler(this.changeGameDirectoryToolStripMenuItem_Click);
            // 
            // minimizeToSystemTrayToolStripMenuItem
            // 
            this.minimizeToSystemTrayToolStripMenuItem.Name = "minimizeToSystemTrayToolStripMenuItem";
            this.minimizeToSystemTrayToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.minimizeToSystemTrayToolStripMenuItem.Text = "&Minimize to System Tray";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.aboutPAManagerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.helpToolStripMenuItem1.Text = "H&elp";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(172, 6);
            // 
            // aboutPAManagerToolStripMenuItem
            // 
            this.aboutPAManagerToolStripMenuItem.Name = "aboutPAManagerToolStripMenuItem";
            this.aboutPAManagerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.aboutPAManagerToolStripMenuItem.Text = "&About PA Manager";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 572);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(376, 610);
            this.Name = "frmMain";
            this.Text = "PA Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpPrefs.ResumeLayout(false);
            this.pPrefs.ResumeLayout(false);
            this.pPrefs.PerformLayout();
            this.tpSaves.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPrefs;
        private System.Windows.Forms.Panel pPrefs;
        private System.Windows.Forms.TextBox tbTLQual;
        private System.Windows.Forms.TextBox tbTLFPSDen;
        private System.Windows.Forms.TextBox tbTLFPSNum;
        private System.Windows.Forms.TextBox tbTLInt;
        private System.Windows.Forms.TextBox tbTLCam;
        private System.Windows.Forms.TextBox tbLKVer;
        private System.Windows.Forms.TextBox tbHCompat;
        private System.Windows.Forms.TextBox tbASTimer;
        private System.Windows.Forms.TextBox tbRMap;
        private System.Windows.Forms.TextBox tbSVol;
        private System.Windows.Forms.TextBox tbSMFreq;
        private System.Windows.Forms.TextBox tbSHeight;
        private System.Windows.Forms.TextBox tbSWidth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbFirstTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbRRooms;
        private System.Windows.Forms.CheckBox cbEnableDSP;
        private System.Windows.Forms.CheckBox cbSwapStereo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbSSampled;
        private System.Windows.Forms.CheckBox cbMSampled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbFullScreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpSaves;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ListBox lbSavedGames;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadPreferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePreferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeGameDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToSystemTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutPAManagerToolStripMenuItem;
    }
}

