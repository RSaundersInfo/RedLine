namespace RedLine
{
    partial class RedLine
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedLine));
            this.ProgramTimer = new System.Windows.Forms.Timer(this.components);
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DropStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgramTimer
            // 
            this.ProgramTimer.Interval = 50;
            this.ProgramTimer.Tick += new System.EventHandler(this.ProgramTimer_Tick);
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "RedLine";
            this.TrayIcon.Visible = true;
            // 
            // TrayMenu
            // 
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DropStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.TrayMenuExit});
            this.TrayMenu.Name = "TrayMenu";
            this.TrayMenu.ShowCheckMargin = true;
            this.TrayMenu.ShowImageMargin = false;
            this.TrayMenu.Size = new System.Drawing.Size(181, 98);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.ShortcutKeyDisplayString = "Alt+S";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SettingsToolStripMenuItem.Text = "&Settings";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // TrayMenuExit
            // 
            this.TrayMenuExit.Name = "TrayMenuExit";
            this.TrayMenuExit.Size = new System.Drawing.Size(180, 22);
            this.TrayMenuExit.Text = "Exit";
            this.TrayMenuExit.Click += new System.EventHandler(this.TrayMenuExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // DropStripMenuItem
            // 
            this.DropStripMenuItem.Name = "DropStripMenuItem";
            this.DropStripMenuItem.ShortcutKeyDisplayString = "Alt+D";
            this.DropStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DropStripMenuItem.Text = "&Drop Line";
            this.DropStripMenuItem.Click += new System.EventHandler(this.DropStripMenuItem_Click);
            // 
            // RedLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 48);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RedLine";
            this.Opacity = 0.6D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RedLine_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RedLine_MouseDown);
            this.TrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer ProgramTimer;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem TrayMenuExit;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DropStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

