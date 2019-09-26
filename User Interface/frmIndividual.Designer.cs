namespace SunshineMinistriesContact.User_Interface
{
    partial class frmIndividual
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboIndFilter = new System.Windows.Forms.ComboBox();
            this.dgvIndividuals = new System.Windows.Forms.DataGridView();
            this.btnSearchInd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSortInd = new System.Windows.Forms.ComboBox();
            this.btnSortInd = new System.Windows.Forms.Button();
            this.btnCreateInd = new System.Windows.Forms.Button();
            this.btnUpdateInd = new System.Windows.Forms.Button();
            this.btnDeleteInd = new System.Windows.Forms.Button();
            this.btnRefreshInd = new System.Windows.Forms.Button();
            this.btnReadInd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividuals)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(811, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 1;
            // 
            // cboIndFilter
            // 
            this.cboIndFilter.FormattingEnabled = true;
            this.cboIndFilter.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Email",
            "Phone",
            "Street Address",
            "Zip Code",
            "Organization"});
            this.cboIndFilter.Location = new System.Drawing.Point(1021, 19);
            this.cboIndFilter.Name = "cboIndFilter";
            this.cboIndFilter.Size = new System.Drawing.Size(121, 21);
            this.cboIndFilter.TabIndex = 2;
            // 
            // dgvIndividuals
            // 
            this.dgvIndividuals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndividuals.Location = new System.Drawing.Point(26, 51);
            this.dgvIndividuals.Name = "dgvIndividuals";
            this.dgvIndividuals.Size = new System.Drawing.Size(1116, 433);
            this.dgvIndividuals.TabIndex = 3;
            // 
            // btnSearchInd
            // 
            this.btnSearchInd.Location = new System.Drawing.Point(730, 19);
            this.btnSearchInd.Name = "btnSearchInd";
            this.btnSearchInd.Size = new System.Drawing.Size(75, 23);
            this.btnSearchInd.TabIndex = 4;
            this.btnSearchInd.Text = "Search:";
            this.btnSearchInd.UseVisualStyleBackColor = true;
            this.btnSearchInd.Click += new System.EventHandler(this.BtnSearchInd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sort By:";
            // 
            // cboSortInd
            // 
            this.cboSortInd.FormattingEnabled = true;
            this.cboSortInd.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Organization"});
            this.cboSortInd.Location = new System.Drawing.Point(73, 21);
            this.cboSortInd.Name = "cboSortInd";
            this.cboSortInd.Size = new System.Drawing.Size(121, 21);
            this.cboSortInd.TabIndex = 6;
            // 
            // btnSortInd
            // 
            this.btnSortInd.Location = new System.Drawing.Point(200, 19);
            this.btnSortInd.Name = "btnSortInd";
            this.btnSortInd.Size = new System.Drawing.Size(39, 23);
            this.btnSortInd.TabIndex = 7;
            this.btnSortInd.Text = "Go";
            this.btnSortInd.UseVisualStyleBackColor = true;
            this.btnSortInd.Click += new System.EventHandler(this.BtnSortInd_Click);
            // 
            // btnCreateInd
            // 
            this.btnCreateInd.Location = new System.Drawing.Point(463, 503);
            this.btnCreateInd.Name = "btnCreateInd";
            this.btnCreateInd.Size = new System.Drawing.Size(103, 41);
            this.btnCreateInd.TabIndex = 8;
            this.btnCreateInd.Text = "Create New";
            this.btnCreateInd.UseVisualStyleBackColor = true;
            this.btnCreateInd.Click += new System.EventHandler(this.BtnCreateInd_Click);
            // 
            // btnUpdateInd
            // 
            this.btnUpdateInd.Location = new System.Drawing.Point(854, 503);
            this.btnUpdateInd.Name = "btnUpdateInd";
            this.btnUpdateInd.Size = new System.Drawing.Size(103, 41);
            this.btnUpdateInd.TabIndex = 9;
            this.btnUpdateInd.Text = "Update Selected";
            this.btnUpdateInd.UseVisualStyleBackColor = true;
            this.btnUpdateInd.Click += new System.EventHandler(this.BtnUpdateInd_Click);
            // 
            // btnDeleteInd
            // 
            this.btnDeleteInd.Location = new System.Drawing.Point(1039, 503);
            this.btnDeleteInd.Name = "btnDeleteInd";
            this.btnDeleteInd.Size = new System.Drawing.Size(103, 41);
            this.btnDeleteInd.TabIndex = 10;
            this.btnDeleteInd.Text = "Delete";
            this.btnDeleteInd.UseVisualStyleBackColor = true;
            this.btnDeleteInd.Click += new System.EventHandler(this.BtnDeleteInd_Click);
            // 
            // btnRefreshInd
            // 
            this.btnRefreshInd.Location = new System.Drawing.Point(26, 503);
            this.btnRefreshInd.Name = "btnRefreshInd";
            this.btnRefreshInd.Size = new System.Drawing.Size(103, 41);
            this.btnRefreshInd.TabIndex = 11;
            this.btnRefreshInd.Text = "Refresh";
            this.btnRefreshInd.UseVisualStyleBackColor = true;
            // 
            // btnReadInd
            // 
            this.btnReadInd.Location = new System.Drawing.Point(658, 503);
            this.btnReadInd.Name = "btnReadInd";
            this.btnReadInd.Size = new System.Drawing.Size(103, 41);
            this.btnReadInd.TabIndex = 12;
            this.btnReadInd.Text = "View Contact";
            this.btnReadInd.UseVisualStyleBackColor = true;
            this.btnReadInd.Click += new System.EventHandler(this.BtnReadInd_Click);
            // 
            // frmIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.btnReadInd);
            this.Controls.Add(this.btnRefreshInd);
            this.Controls.Add(this.btnDeleteInd);
            this.Controls.Add(this.btnUpdateInd);
            this.Controls.Add(this.btnCreateInd);
            this.Controls.Add(this.btnSortInd);
            this.Controls.Add(this.cboSortInd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchInd);
            this.Controls.Add(this.dgvIndividuals);
            this.Controls.Add(this.cboIndFilter);
            this.Controls.Add(this.textBox1);
            this.Name = "frmIndividual";
            this.Text = "Manage Individuals";
            this.Load += new System.EventHandler(this.FrmIndividual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividuals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboIndFilter;
        private System.Windows.Forms.DataGridView dgvIndividuals;
        private System.Windows.Forms.Button btnSearchInd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSortInd;
        private System.Windows.Forms.Button btnSortInd;
        private System.Windows.Forms.Button btnCreateInd;
        private System.Windows.Forms.Button btnUpdateInd;
        private System.Windows.Forms.Button btnDeleteInd;
        private System.Windows.Forms.Button btnRefreshInd;
        private System.Windows.Forms.Button btnReadInd;
    }
}