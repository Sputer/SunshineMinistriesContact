namespace SunshineMinistriesContact
{
    partial class frmMainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.churchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.administrativeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1776, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOffToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.logOffToolStripMenuItem.Text = "Log Off";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.churchesToolStripMenuItem,
            this.organizationsToolStripMenuItem,
            this.individualsToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.searchToolStripMenuItem.Text = "View";
            // 
            // churchesToolStripMenuItem
            // 
            this.churchesToolStripMenuItem.Name = "churchesToolStripMenuItem";
            this.churchesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.churchesToolStripMenuItem.Text = "Churches";
            this.churchesToolStripMenuItem.Click += new System.EventHandler(this.ChurchesToolStripMenuItem_Click);
            // 
            // organizationsToolStripMenuItem
            // 
            this.organizationsToolStripMenuItem.Name = "organizationsToolStripMenuItem";
            this.organizationsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.organizationsToolStripMenuItem.Text = "Organizations";
            this.organizationsToolStripMenuItem.Click += new System.EventHandler(this.OrganizationsToolStripMenuItem_Click);
            // 
            // individualsToolStripMenuItem
            // 
            this.individualsToolStripMenuItem.Name = "individualsToolStripMenuItem";
            this.individualsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.individualsToolStripMenuItem.Text = "Individuals";
            this.individualsToolStripMenuItem.Click += new System.EventHandler(this.IndividualsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createReportToolStripMenuItem,
            this.browseReportsToolStripMenuItem,
            this.newTemplateToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // createReportToolStripMenuItem
            // 
            this.createReportToolStripMenuItem.Name = "createReportToolStripMenuItem";
            this.createReportToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.createReportToolStripMenuItem.Text = "Create Report";
            // 
            // browseReportsToolStripMenuItem
            // 
            this.browseReportsToolStripMenuItem.Name = "browseReportsToolStripMenuItem";
            this.browseReportsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.browseReportsToolStripMenuItem.Text = "Browse History";
            // 
            // administrativeToolStripMenuItem
            // 
            this.administrativeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUsersToolStripMenuItem,
            this.manageUserToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.administrativeToolStripMenuItem.Name = "administrativeToolStripMenuItem";
            this.administrativeToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.administrativeToolStripMenuItem.Text = "Administrative";
            // 
            // createUsersToolStripMenuItem
            // 
            this.createUsersToolStripMenuItem.Name = "createUsersToolStripMenuItem";
            this.createUsersToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.createUsersToolStripMenuItem.Text = "Create User";
            this.createUsersToolStripMenuItem.Click += new System.EventHandler(this.CreateUsersToolStripMenuItem_Click);
            // 
            // manageUserToolStripMenuItem
            // 
            this.manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            this.manageUserToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.manageUserToolStripMenuItem.Text = "User List";
            this.manageUserToolStripMenuItem.Click += new System.EventHandler(this.ManageUserToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // newTemplateToolStripMenuItem
            // 
            this.newTemplateToolStripMenuItem.Name = "newTemplateToolStripMenuItem";
            this.newTemplateToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.newTemplateToolStripMenuItem.Text = "New Template";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 1061);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunshine Ministries";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem churchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}