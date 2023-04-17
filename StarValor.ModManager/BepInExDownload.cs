using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Compression;


namespace StarValor.ModManager
{
    public partial class BepInExDownload : Form
    {
        private static readonly string DLpath = $@"{Path.GetTempPath()}StarValor.ModManager\";
        private static readonly string UnpackPath = $@"{DLpath}unpack\";
        private static readonly string DLfile = $@"{DLpath}BepInEx.zip";
        public static string DLorigin = "https://github.com/BepInEx/BepInEx/releases/download/v5.4.21/BepInEx_x86_5.4.21.0.zip";
        private MainForm ParentWindow;

        public BepInExDownload(MainForm mainForm)
        {
            ParentWindow = mainForm;
            InitializeComponent();
            loggity(DLpath);
            btnOK.Enabled = false;
            ParentWindow.Visible = false;
            DoStuff();
        }

        private void DoStuff()
        {
            loggity("Starting progress...");
            if (Directory.Exists(DLpath))
            {
                DeleteExisting();
            }
            Directory.CreateDirectory(UnpackPath);
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
                loggity("Starting download.");
                loggity($"Source URI: {DLorigin}");
                wc.DownloadFileAsync(new Uri(DLorigin), DLfile);
            }
        }

        private void DeleteExisting()
        {
            loggity("Deleting existing temporary files.");
            Directory.Delete(DLpath, true);
        }

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            UseWaitCursor = false;
            if (e.Error != null)
            {
                loggity(e.Error.ToString());
                loggity(e.Error.Message);
                DeleteExisting();
                //this.ParentWindow.bepInExResult = e.Error.Message;
                DialogResult = DialogResult.Cancel;
                Close();
            }
            else
            {
                bool result = Unpack();
                btnCancel.Enabled = !result;
                btnOK.Enabled = result;
                ParentWindow.settingsChanged = true;
                if (result) { btnOK.Focus(); } else { btnCancel.Focus(); }
            }
        }

        private bool Unpack()
        {
            loggity("Unpacking to temp directory.");
            ZipFile.ExtractToDirectory(DLfile, UnpackPath);
            int cnt = 0;
            string[] allFiles = Directory.GetFiles(UnpackPath, "*.*", SearchOption.AllDirectories);
            int max = allFiles.Length;
            string currPath;
            foreach (var file in allFiles)
            {
                cnt++;
                loggity($@"Copying files: {cnt}/{max}");
                currPath = Path.GetDirectoryName(file.Replace(UnpackPath, ParentWindow.settings.SVpath));
                if (!Directory.Exists(currPath)) { Directory.CreateDirectory(currPath); }
                File.Copy(file, file.Replace(UnpackPath, ParentWindow.settings.SVpath), true);
            }
            DeleteExisting();
            return true;
        }

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage % 25 == 0) 
            {
                //  for some reason the 100% gets called twice.
                if (tbProgress.Lines.Length > 1 && !tbProgress.Lines[tbProgress.Lines.Length - 2].Contains($@"{e.ProgressPercentage}%"))
                {
                    loggity($"Download at {e.ProgressPercentage}%");
                }
            }
            barBepInEx.Value = e.ProgressPercentage;
        }

        public void loggity(string wut)
        {
            tbProgress.AppendText($"[{DateTime.Now}] {wut}{Environment.NewLine}");
            ParentWindow.loggity(wut);
        }
    }
}
