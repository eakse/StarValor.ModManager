using StarValor.ModManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;


namespace StarValor.ModManager
{
    public partial class MainForm : Form
    {
        public bool downloadDone = false;
        public bool downloadSuccess = false;

        private Font fntLocatedSV;
        private Font fntInstalledBIE;
        private Font fntRanBIE;
        private const string exeSV = "Star Valor.exe";
        private const string defaultBIE = @"BepInEx\";
        private const string defaultBIEplugin = @"plugins\";
        private const string defaultBIEconfig = @"config\";
        private string dllBIE = @"core\BepInEx.dll";
        private string logFile = $@"{AppContext.BaseDirectory}\StarValor.ModManager.log";
        private string settingsFile = $@"{AppContext.BaseDirectory}\StarValor.ModManager.Settings.xml";
        public char bh = '─';
        public char bv = '│';
        public char btl = '┌';
        public char btr = '┐';
        public char bbl = '└';
        public char bbr = '┘';
        public string eol = $"{Environment.NewLine}";
        public string line;
        public int textWidth = 80;
        public SettingsSVMM settings = new SettingsSVMM();
        public bool settingsChanged = false;
        //private Process processSV;

        public MainForm()
        {
            InitializeComponent();
            if (File.Exists(logFile)) { File.Delete(logFile); }
            line = new string(bh, textWidth);
            //ApplyTheme();
        }

        public bool LocatedSV() => File.Exists(settings.SVexe);
        public bool LocatedBIE() => LocatedSV() && File.Exists($"{settings.BIEpath}{dllBIE}");
        public bool LocatedBIEPlugins() => Directory.Exists(settings.BIEpathPlugin);
        public bool RanBIE() => Directory.Exists($"{settings.BIEpath}{defaultBIEconfig}");

        public bool AllGood() => settings.locatedSV && settings.locatedBIE && settings.ranBIE;

        public void CustomUpdate()
        {
            if (!settingsChanged)
            {
                if (settings.locatedSV != LocatedSV()) { settingsChanged = true; }
                if (settings.locatedBIE != LocatedBIE()) { settingsChanged = true; }
                if (settings.ranBIE != RanBIE()) { settingsChanged = true; }
            }
            settings.locatedSV = LocatedSV();
            settings.locatedBIE = LocatedBIE();
            settings.ranBIE = RanBIE();
            
            tsIcon.BackgroundImage = AllGood() ? Resources.OK : Resources.NOK;

            // Ugly reset, but it works
            tsStatus.Click -= new EventHandler(btnBepInEx_Click);
            tsStatus.Click -= new EventHandler(btnBrowseAppDir_Click);
            tsStatus.Click -= new EventHandler(btnLaunchSV_Click);

            if (!AllGood())
            {
                if (!settings.ranBIE)
                {
                    tsStatus.Text = "Star Valor needs to run at least once for it to initialize properly. Click me to run Star Valor. Exit after getting to the main menu.";
                    tsStatus.Click += new EventHandler(btnLaunchSV_Click);
                }
                if (!settings.locatedBIE)
                {
                    tsStatus.Text = "BepInEx needs to be installed in the Star Valor game folder. Click me to download BepInEx.";
                    tsStatus.Click += new EventHandler(btnBepInEx_Click);
                }
                if (!settings.locatedSV)
                {
                    tsStatus.Text = "Mod Manager does not know where Star Valor is installed, click me to locate the Star Valor EXE.";
                    tsStatus.Click += new EventHandler(btnBrowseAppDir_Click);
                }
            }
            else 
            { 
                tsStatus.Text = "All is good, click me to start Star Valor.";
                tsStatus.Click += new EventHandler(btnLaunchSV_Click);
            }

            lblLocateSV.Text = settings.locatedSV ? "Star Valor EXE located" : "Star Valor EXE NOT located.";
            lblLocatedBIE.Text = settings.locatedBIE ? "BepInEx located" : "BepInEx NOT located.";
            lblRanBIE.Text = settings.ranBIE ? "BepInEx initialized" : "BepInEx NOT initialized.";
            picLocatedSV.Image = LocatedSV() ? Resources.OK : Resources.NOK;
            picInstalledBIE.Image = LocatedBIE() ? Resources.OK : Resources.NOK;
            picRanBIE.Image = RanBIE() ? Resources.OK : Resources.NOK;
            editAppDir.Text = settings.SVpath;

            btnInstallBIE.Enabled = settings.locatedSV;
            btnLaunchSV.Enabled = settings.locatedBIE;
            tbLog.SelectionStart = tbLog.TextLength;
            tbLog.ScrollToCaret();
            if (settingsChanged) { SaveSettings(); logSettings(); }
        }
        private void CustomUpdate(object sender, EventArgs e)
        {
            CustomUpdate();
        }

        private void LoadSettings()
        {
            if (File.Exists(settingsFile))
            {
                logTitle("Loading settings.");
                var serializer = new XmlSerializer(typeof(SettingsSVMM));
                using (var reader = XmlReader.Create(settingsFile))
                {
                    settings = (SettingsSVMM)serializer.Deserialize(reader);
                }
            }
            else { loggity("No existing settings found, generating default settings file."); }
            logSettings();
            CustomUpdate();
        }

        private void SaveSettings()
        {
            loggity("Saving settings.");
            if (File.Exists(settingsFile)) { File.Delete(settingsFile); }
            var serializer = new XmlSerializer(typeof(SettingsSVMM));
            using (var writer = XmlWriter.Create(settingsFile, new XmlWriterSettings { Indent = true }))
            {
                serializer.Serialize(writer, settings);
            }
            settingsChanged = false;
        }

        private void btnBrowseAppDir_Click(object sender, EventArgs e)
        {
            dlgAppExe.FileName = exeSV;
            dlgAppExe.ShowDialog(this);
        }

        private void dlgAppExe_FileOk(object sender, CancelEventArgs e)
        {
            if (!e.Cancel) { UpdateSettingsFromExe(dlgAppExe.FileName); }
            else { CustomUpdate(); }
        }

        private void UpdateSettingsFromExe(string exeStarValor)
        {
            settingsChanged = true;
            settings.SVexe = exeStarValor;
            settings.SVpath = Path.GetDirectoryName(exeStarValor) + @"\";
            settings.BIEpath = settings.SVpath + defaultBIE;
            settings.BIEpathPlugin = settings.BIEpath + defaultBIEplugin;
            settings.BIEpathConfig = settings.BIEpath + defaultBIEconfig;
            logTitle("Application directory updated.");
            loggity(exeStarValor);
            loggity(settings.SVpath);
            loggity(settings.BIEpath);
            loggity(settings.BIEpathPlugin);
            if (LocatedBIE())
            {
                logline();
                foreach (string plugin in GetPluginsFromBEIdir())
                {
                    loggity(plugin);
                }
            }
            CustomUpdate();
        }

        private void btnBepInEx_Click(object sender, EventArgs e)
        {
            logline();
            BepInExDownload BepInExDownloadForm = new BepInExDownload(this);
            BepInExDownloadForm.ShowDialog(this);

            BepInExDownloadForm.Dispose();
            Visible = true;
            CustomUpdate();
        }
        private void btnLaunchSV_Click(object sender, EventArgs e)
        {
            Process processSV = new Process();
            processSV.StartInfo.FileName = settings.SVexe;
            processSV.EnableRaisingEvents = true;
            //Visible = !cbHideMe.Checked;
            loggity("Star Valor started.");
            processSV.Start();
            loggity($"Original PID: {processSV.Id}");
            if (!settings.ranBIE)
            {
                loggity("Since BepInEx is not initialized yet, the Mod Manager will sleep for 5 seconds.");
                Thread.Sleep(5000);
            }
            CustomUpdate();
        }


        private string[] GetPluginsFromBEIdir()
        {
            if (LocatedBIEPlugins()) { return Directory.GetFiles(settings.BIEpathPlugin, "*.dll"); }
            else { return new string[0]; }
        }


        public void logline() => loggity(line, false); 

        public void loggity(string wut, bool addTime = true)
        {
            wut = addTime ? $"[{DateTime.Now}] {wut}{Environment.NewLine}" : $"{wut}{Environment.NewLine}";
            using (StreamWriter sw = File.AppendText(logFile)) { sw.Write(wut); }
            tbLog.AppendText(wut);
        }

        public void logTitle(string title)
        {
            if (title.Length > textWidth - 4) { title = title.Substring(0, textWidth - 4); }
            string top = $"{btl}{new string(bh, textWidth - 2)}{btr}";
            string bottom = $"{bbl}{new string(bh, textWidth - 2)}{bbr}";
            string middle = $"{bv}{new string(' ', textWidth - 2)}{bv}";
            int leftpad = (textWidth - 4 - title.Length) / 2;
            int rightpad = leftpad + (title.Length % 2);
            title = $"{bv} {new string(' ', leftpad)}{title}{new string(' ', rightpad)} {bv}";
            string final = $"{top}{eol}{middle}{eol}{title}{eol}{middle}{eol}{bottom}";
            loggity(final, false);
        }

        public void logSettings()
        {
            loggity("Current settings:");
            logline();
            using (var sw = new StringWriter())
            {
                var serializer = new XmlSerializer(typeof(SettingsSVMM));
                serializer.Serialize(sw, settings);
                loggity(sw.ToString(), false);
            }
            logline();
        }

        public void UpdateColorControls(Control myControl)
        {
            myControl.BackColor = Color.DimGray;
            myControl.ForeColor = Color.LightBlue;
            foreach (Control subC in myControl.Controls)
            {
                UpdateColorControls(subC);
            }
        }

        private void ApplyTheme() 
        {
            foreach (Control c in this.Controls) UpdateColorControls(c);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }
    }
}