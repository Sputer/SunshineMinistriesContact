namespace SunshineMinistriesContact.User_Interface
{
    partial class frmOrganization
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
            this.btnReadOrg = new System.Windows.Forms.Button();
            this.btnRefreshOrg = new System.Windows.Forms.Button();
            this.btnDeleteOrg = new System.Windows.Forms.Button();
            this.btnUpdateOrg = new System.Windows.Forms.Button();
            this.btnCreateOrg = new System.Windows.Forms.Button();
            this.btnSortOrg = new System.Windows.Forms.Button();
            this.cboSortOrg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchOrg = new System.Windows.Forms.Button();
            this.dgvOrganization = new System.Windows.Forms.DataGridView();
            this.cboFilterOrg = new System.Windows.Forms.ComboBox();
            this.txtSearchOrg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganization)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadOrg
            // 
            this.btnReadOrg.Location = new System.Drawing.Point(662, 500);
            this.btnReadOrg.Name = "btnReadOrg";
            this.btnReadOrg.Size = new System.Drawing.Size(103, 41);
            this.btnReadOrg.TabIndex = 24;
            this.btnReadOrg.Text = "View Contact";
            this.btnReadOrg.UseVisualStyleBackColor = true;
            this.btnReadOrg.Click += new System.EventHandler(this.BtnReadOrg_Click);
            // 
            // btnRefreshOrg
            // 
            this.btnRefreshOrg.Location = new System.Drawing.Point(30, 500);
            this.btnRefreshOrg.Name = "btnRefreshOrg";
            this.btnRefreshOrg.Size = new System.Drawing.Size(103, 41);
            this.btnRefreshOrg.TabIndex = 23;
            this.btnRefreshOrg.Text = "Refresh";
            this.btnRefreshOrg.UseVisualStyleBackColor = true;
            this.btnRefreshOrg.Click += new System.EventHandler(this.BtnRefreshOrg_Click);
            // 
            // btnDeleteOrg
            // 
            this.btnDeleteOrg.Location = new System.Drawing.Point(1043, 500);
            this.btnDeleteOrg.Name = "btnDeleteOrg";
            this.btnDeleteOrg.Size = new System.Drawing.Size(103, 41);
            this.btnDeleteOrg.TabIndex = 22;
            this.btnDeleteOrg.Text = "Delete";
            this.btnDeleteOrg.UseVisualStyleBackColor = true;
            this.btnDeleteOrg.Click += new System.EventHandler(this.BtnDeleteOrg_Click);
            // 
            // btnUpdateOrg
            // 
            this.btnUpdateOrg.Location = new System.Drawing.Point(858, 500);
            this.btnUpdateOrg.Name = "btnUpdateOrg";
            this.btnUpdateOrg.Size = new System.Drawing.Size(103, 41);
            this.btnUpdateOrg.TabIndex = 21;
            this.btnUpdateOrg.Text = "Update Selected";
            this.btnUpdateOrg.UseVisualStyleBackColor = true;
            this.btnUpdateOrg.Click += new System.EventHandler(this.BtnUpdateOrg_Click);
            // 
            // btnCreateOrg
            // 
            this.btnCreateOrg.Location = new System.Drawing.Point(467, 500);
            this.btnCreateOrg.Name = "btnCreateOrg";
            this.btnCreateOrg.Size = new System.Drawing.Size(103, 41);
            this.btnCreateOrg.TabIndex = 20;
            this.btnCreateOrg.Text = "Create New";
            this.btnCreateOrg.UseVisualStyleBackColor = true;
            this.btnCreateOrg.Click += new System.EventHandler(this.BtnCreateOrg_Click);
            // 
            // btnSortOrg
            // 
            this.btnSortOrg.Location = new System.Drawing.Point(204, 16);
            this.btnSortOrg.Name = "btnSortOrg";
            this.btnSortOrg.Size = new System.Drawing.Size(39, 23);
            this.btnSortOrg.TabIndex = 19;
            this.btnSortOrg.Text = "Go";
            this.btnSortOrg.UseVisualStyleBackColor = true;
            this.btnSortOrg.Click += new System.EventHandler(this.BtnSortOrg_Click);
            // 
            // cboSortOrg
            // 
            this.cboSortOrg.FormattingEnabled = true;
            this.cboSortOrg.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Organization"});
            this.cboSortOrg.Location = new System.Drawing.Point(77, 18);
            this.cboSortOrg.Name = "cboSortOrg";
            this.cboSortOrg.Size = new System.Drawing.Size(121, 21);
            this.cboSortOrg.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sort By:";
            // 
            // btnSearchOrg
            // 
            this.btnSearchOrg.Location = new System.Drawing.Point(734, 16);
            this.btnSearchOrg.Name = "btnSearchOrg";
            this.btnSearchOrg.Size = new System.Drawing.Size(75, 23);
            this.btnSearchOrg.TabIndex = 16;
            this.btnSearchOrg.Text = "Search:";
            this.btnSearchOrg.UseVisualStyleBackColor = true;
            this.btnSearchOrg.Click += new System.EventHandler(this.BtnSearchOrg_Click);
            // 
            // dgvOrganization
            // 
            this.dgvOrganization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganization.Location = new System.Drawing.Point(30, 58);
            this.dgvOrganization.Name = "dgvOrganization";
            this.dgvOrganization.Size = new System.Drawing.Size(1116, 425);
            this.dgvOrganization.TabIndex = 15;
            // 
            // cboFilterOrg
            // 
            this.cboFilterOrg.FormattingEnabled = true;
            this.cboFilterOrg.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Email",
            "Phone",
            "Street Address",
            "Zip Code",
            "Organization"});
            this.cboFilterOrg.Location = new System.Drawing.Point(1025, 16);
            this.cboFilterOrg.Name = "cboFilterOrg";
            this.cboFilterOrg.Size = new System.Drawing.Size(121, 21);
            this.cboFilterOrg.TabIndex = 14;
            // 
            // txtSearchOrg
            // 
            this.txtSearchOrg.Location = new System.Drawing.Point(815, 17);
            this.txtSearchOrg.Name = "txtSearchOrg";
            this.txtSearchOrg.Size = new System.Drawing.Size(204, 20);
            this.txtSearchOrg.TabIndex = 13;
            // 
            // frmOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.btnReadOrg);
            this.Controls.Add(this.btnRefreshOrg);
            this.Controls.Add(this.btnDeleteOrg);
            this.Controls.Add(this.btnUpdateOrg);
            this.Controls.Add(this.btnCreateOrg);
            this.Controls.Add(this.btnSortOrg);
            this.Controls.Add(this.cboSortOrg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchOrg);
            this.Controls.Add(this.dgvOrganization);
            this.Controls.Add(this.cboFilterOrg);
            this.Controls.Add(this.txtSearchOrg);
            this.Name = "frmOrganization";
            this.Text = "frmOrganization";
            this.Load += new System.EventHandler(this.FrmOrganization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganization)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadOrg;
        private System.Windows.Forms.Button btnRefreshOrg;
        private System.Windows.Forms.Button btnDeleteOrg;
        private System.Windows.Forms.Button btnUpdateOrg;
        private System.Windows.Forms.Button btnCreateOrg;
        private System.Windows.Forms.Button btnSortOrg;
        private System.Windows.Forms.ComboBox cboSortOrg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchOrg;
        private System.Windows.Forms.DataGridView dgvOrganization;
        private System.Windows.Forms.ComboBox cboFilterOrg;
        private System.Windows.Forms.TextBox txtSearchOrg;
    }
}