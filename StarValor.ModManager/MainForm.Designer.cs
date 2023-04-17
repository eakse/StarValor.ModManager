namespace StarValor.ModManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dlgAppExe = new System.Windows.Forms.OpenFileDialog();
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.tsIcon = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.pageSettings = new System.Windows.Forms.TabPage();
            this.cbHideMe = new System.Windows.Forms.CheckBox();
            this.lblRanBIE = new System.Windows.Forms.Label();
            this.picRanBIE = new System.Windows.Forms.PictureBox();
            this.btnLaunchSV = new System.Windows.Forms.Button();
            this.lblLocatedBIE = new System.Windows.Forms.Label();
            this.lblLocateSV = new System.Windows.Forms.Label();
            this.btnInstallBIE = new System.Windows.Forms.Button();
            this.picInstalledBIE = new System.Windows.Forms.PictureBox();
            this.picLocatedSV = new System.Windows.Forms.PictureBox();
            this.btnLocateSV = new System.Windows.Forms.Button();
            this.editAppDir = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tblLayout.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.pageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRanBIE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInstalledBIE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLocatedSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgAppExe
            // 
            this.dlgAppExe.DefaultExt = "exe";
            this.dlgAppExe.FileName = "Star Valor.exe";
            this.dlgAppExe.Filter = "Star Valor executable|Star Valor.exe";
            this.dlgAppExe.ReadOnlyChecked = true;
            this.dlgAppExe.Title = "Select \"Star Valor.exe\"";
            this.dlgAppExe.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgAppExe_FileOk);
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 1;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Controls.Add(this.statusMain, 0, 2);
            this.tblLayout.Controls.Add(this.tbLog, 0, 1);
            this.tblLayout.Controls.Add(this.tabSettings, 0, 0);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 3;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLayout.Size = new System.Drawing.Size(1184, 761);
            this.tblLayout.TabIndex = 4;
            // 
            // statusMain
            // 
            this.statusMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsIcon,
            this.tsStatus});
            this.statusMain.Location = new System.Drawing.Point(0, 730);
            this.statusMain.MinimumSize = new System.Drawing.Size(0, 30);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(1184, 31);
            this.statusMain.SizingGrip = false;
            this.statusMain.TabIndex = 18;
            this.statusMain.Text = "statusMain";
            // 
            // tsIcon
            // 
            this.tsIcon.AutoSize = false;
            this.tsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsIcon.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsIcon.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.tsIcon.Margin = new System.Windows.Forms.Padding(3, 2, 0, 1);
            this.tsIcon.Name = "tsIcon";
            this.tsIcon.Size = new System.Drawing.Size(25, 28);
            // 
            // tsStatus
            // 
            this.tsStatus.AutoSize = false;
            this.tsStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsStatus.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(4, 26);
            this.tsStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLog.Location = new System.Drawing.Point(0, 584);
            this.tbLog.Margin = new System.Windows.Forms.Padding(0);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(1184, 146);
            this.tbLog.TabIndex = 17;
            this.tbLog.TabStop = false;
            // 
            // tabSettings
            // 
            this.tabSettings.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabSettings.Controls.Add(this.pageSettings);
            this.tabSettings.Controls.Add(this.tabPage1);
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettings.Location = new System.Drawing.Point(3, 3);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(1178, 578);
            this.tabSettings.TabIndex = 4;
            // 
            // pageSettings
            // 
            this.pageSettings.Controls.Add(this.cbHideMe);
            this.pageSettings.Controls.Add(this.lblRanBIE);
            this.pageSettings.Controls.Add(this.picRanBIE);
            this.pageSettings.Controls.Add(this.btnLaunchSV);
            this.pageSettings.Controls.Add(this.lblLocatedBIE);
            this.pageSettings.Controls.Add(this.lblLocateSV);
            this.pageSettings.Controls.Add(this.btnInstallBIE);
            this.pageSettings.Controls.Add(this.picInstalledBIE);
            this.pageSettings.Controls.Add(this.picLocatedSV);
            this.pageSettings.Controls.Add(this.btnLocateSV);
            this.pageSettings.Controls.Add(this.editAppDir);
            this.pageSettings.Location = new System.Drawing.Point(4, 25);
            this.pageSettings.Margin = new System.Windows.Forms.Padding(0);
            this.pageSettings.Name = "pageSettings";
            this.pageSettings.Padding = new System.Windows.Forms.Padding(4);
            this.pageSettings.Size = new System.Drawing.Size(1170, 549);
            this.pageSettings.TabIndex = 1;
            this.pageSettings.Text = "Settings";
            // 
            // cbHideMe
            // 
            this.cbHideMe.AutoSize = true;
            this.cbHideMe.Checked = true;
            this.cbHideMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHideMe.Location = new System.Drawing.Point(467, 71);
            this.cbHideMe.Name = "cbHideMe";
            this.cbHideMe.Size = new System.Drawing.Size(198, 17);
            this.cbHideMe.TabIndex = 13;
            this.cbHideMe.Text = "&Hide this window while SV is running";
            this.cbHideMe.UseVisualStyleBackColor = true;
            this.cbHideMe.Visible = false;
            // 
            // lblRanBIE
            // 
            this.lblRanBIE.AutoSize = true;
            this.lblRanBIE.Location = new System.Drawing.Point(33, 72);
            this.lblRanBIE.Name = "lblRanBIE";
            this.lblRanBIE.Size = new System.Drawing.Size(92, 13);
            this.lblRanBIE.TabIndex = 12;
            this.lblRanBIE.Text = "BepInEx initialized";
            // 
            // picRanBIE
            // 
            this.picRanBIE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRanBIE.Location = new System.Drawing.Point(3, 66);
            this.picRanBIE.Name = "picRanBIE";
            this.picRanBIE.Size = new System.Drawing.Size(24, 24);
            this.picRanBIE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRanBIE.TabIndex = 11;
            this.picRanBIE.TabStop = false;
            // 
            // btnLaunchSV
            // 
            this.btnLaunchSV.Location = new System.Drawing.Point(293, 66);
            this.btnLaunchSV.Name = "btnLaunchSV";
            this.btnLaunchSV.Size = new System.Drawing.Size(167, 24);
            this.btnLaunchSV.TabIndex = 10;
            this.btnLaunchSV.Text = "&Launch Star Valor";
            this.btnLaunchSV.UseVisualStyleBackColor = true;
            // 
            // lblLocatedBIE
            // 
            this.lblLocatedBIE.AutoSize = true;
            this.lblLocatedBIE.Location = new System.Drawing.Point(33, 42);
            this.lblLocatedBIE.Name = "lblLocatedBIE";
            this.lblLocatedBIE.Size = new System.Drawing.Size(95, 13);
            this.lblLocatedBIE.TabIndex = 9;
            this.lblLocatedBIE.Text = "BepInExe Installed";
            // 
            // lblLocateSV
            // 
            this.lblLocateSV.AutoSize = true;
            this.lblLocateSV.Location = new System.Drawing.Point(33, 12);
            this.lblLocateSV.Name = "lblLocateSV";
            this.lblLocateSV.Size = new System.Drawing.Size(115, 13);
            this.lblLocateSV.TabIndex = 8;
            this.lblLocateSV.Text = "Star Valor EXE located";
            // 
            // btnInstallBIE
            // 
            this.btnInstallBIE.Location = new System.Drawing.Point(293, 36);
            this.btnInstallBIE.Name = "btnInstallBIE";
            this.btnInstallBIE.Size = new System.Drawing.Size(167, 24);
            this.btnInstallBIE.TabIndex = 6;
            this.btnInstallBIE.Text = "&Download && Install BepInEx";
            this.btnInstallBIE.UseVisualStyleBackColor = true;
            // 
            // picInstalledBIE
            // 
            this.picInstalledBIE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picInstalledBIE.Location = new System.Drawing.Point(3, 36);
            this.picInstalledBIE.Name = "picInstalledBIE";
            this.picInstalledBIE.Size = new System.Drawing.Size(24, 24);
            this.picInstalledBIE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInstalledBIE.TabIndex = 5;
            this.picInstalledBIE.TabStop = false;
            // 
            // picLocatedSV
            // 
            this.picLocatedSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLocatedSV.Location = new System.Drawing.Point(3, 6);
            this.picLocatedSV.Name = "picLocatedSV";
            this.picLocatedSV.Size = new System.Drawing.Size(24, 24);
            this.picLocatedSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLocatedSV.TabIndex = 4;
            this.picLocatedSV.TabStop = false;
            // 
            // btnLocateSV
            // 
            this.btnLocateSV.Location = new System.Drawing.Point(293, 6);
            this.btnLocateSV.Name = "btnLocateSV";
            this.btnLocateSV.Size = new System.Drawing.Size(167, 24);
            this.btnLocateSV.TabIndex = 2;
            this.btnLocateSV.Text = "Locate Star Valor &EXE";
            this.btnLocateSV.UseVisualStyleBackColor = true;
            // 
            // editAppDir
            // 
            this.editAppDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editAppDir.Location = new System.Drawing.Point(467, 7);
            this.editAppDir.MinimumSize = new System.Drawing.Size(4, 24);
            this.editAppDir.Name = "editAppDir";
            this.editAppDir.Size = new System.Drawing.Size(624, 20);
            this.editAppDir.TabIndex = 0;
            this.editAppDir.Visible = false;
            this.editAppDir.WordWrap = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1170, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tblLayout);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Star Valor Mod Manager";
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.pageSettings.ResumeLayout(false);
            this.pageSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRanBIE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInstalledBIE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLocatedSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog dlgAppExe;
        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel tsIcon;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage pageSettings;
        private System.Windows.Forms.CheckBox cbHideMe;
        private System.Windows.Forms.Label lblRanBIE;
        private System.Windows.Forms.PictureBox picRanBIE;
        private System.Windows.Forms.Button btnLaunchSV;
        private System.Windows.Forms.Label lblLocatedBIE;
        private System.Windows.Forms.Label lblLocateSV;
        private System.Windows.Forms.Button btnInstallBIE;
        private System.Windows.Forms.PictureBox picInstalledBIE;
        private System.Windows.Forms.PictureBox picLocatedSV;
        private System.Windows.Forms.Button btnLocateSV;
        private System.Windows.Forms.TextBox editAppDir;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

