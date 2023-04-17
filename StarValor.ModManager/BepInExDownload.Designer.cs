namespace StarValor.ModManager
{
    partial class BepInExDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BepInExDownload));
            this.barBepInEx = new System.Windows.Forms.ProgressBar();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbProgress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // barBepInEx
            // 
            this.barBepInEx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barBepInEx.Location = new System.Drawing.Point(0, 235);
            this.barBepInEx.Name = "barBepInEx";
            this.barBepInEx.Size = new System.Drawing.Size(584, 23);
            this.barBepInEx.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barBepInEx.TabIndex = 0;
            this.barBepInEx.UseWaitCursor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(500, 209);
            this.btnOK.Margin = new System.Windows.Forms.Padding(0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.UseWaitCursor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(424, 209);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.UseWaitCursor = true;
            // 
            // tbProgress
            // 
            this.tbProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbProgress.Enabled = false;
            this.tbProgress.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProgress.Location = new System.Drawing.Point(0, 0);
            this.tbProgress.Multiline = true;
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.ReadOnly = true;
            this.tbProgress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProgress.Size = new System.Drawing.Size(584, 206);
            this.tbProgress.TabIndex = 4;
            this.tbProgress.TabStop = false;
            this.tbProgress.UseWaitCursor = true;
            // 
            // BepInExDownload
            // 
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(584, 258);
            this.ControlBox = false;
            this.Controls.Add(this.tbProgress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.barBepInEx);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BepInExDownload";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar barBepInEx;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbProgress;
    }
}