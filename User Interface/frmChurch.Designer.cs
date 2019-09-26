namespace SunshineMinistriesContact.User_Interface
{
    partial class frmChurch
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
            this.btnReadChurch = new System.Windows.Forms.Button();
            this.btnRefreshChurch = new System.Windows.Forms.Button();
            this.btnDeleteChurch = new System.Windows.Forms.Button();
            this.btnUpdateChurch = new System.Windows.Forms.Button();
            this.btnCreateChurch = new System.Windows.Forms.Button();
            this.btnSortChurch = new System.Windows.Forms.Button();
            this.cboSortChurch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchChurch = new System.Windows.Forms.Button();
            this.dgvChurch = new System.Windows.Forms.DataGridView();
            this.cboFilterChurch = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChurch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadChurch
            // 
            this.btnReadChurch.Location = new System.Drawing.Point(884, 610);
            this.btnReadChurch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReadChurch.Name = "btnReadChurch";
            this.btnReadChurch.Size = new System.Drawing.Size(137, 50);
            this.btnReadChurch.TabIndex = 24;
            this.btnReadChurch.Text = "View Contact";
            this.btnReadChurch.UseVisualStyleBackColor = true;
            this.btnReadChurch.Click += new System.EventHandler(this.BtnReadChurch_Click);
            // 
            // btnRefreshChurch
            // 
            this.btnRefreshChurch.Location = new System.Drawing.Point(41, 610);
            this.btnRefreshChurch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshChurch.Name = "btnRefreshChurch";
            this.btnRefreshChurch.Size = new System.Drawing.Size(137, 50);
            this.btnRefreshChurch.TabIndex = 23;
            this.btnRefreshChurch.Text = "Refresh";
            this.btnRefreshChurch.UseVisualStyleBackColor = true;
            this.btnRefreshChurch.Click += new System.EventHandler(this.BtnRefreshChurch_Click);
            // 
            // btnDeleteChurch
            // 
            this.btnDeleteChurch.Location = new System.Drawing.Point(1392, 610);
            this.btnDeleteChurch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteChurch.Name = "btnDeleteChurch";
            this.btnDeleteChurch.Size = new System.Drawing.Size(137, 50);
            this.btnDeleteChurch.TabIndex = 22;
            this.btnDeleteChurch.Text = "Delete";
            this.btnDeleteChurch.UseVisualStyleBackColor = true;
            this.btnDeleteChurch.Click += new System.EventHandler(this.BtnDeleteChurch_Click);
            // 
            // btnUpdateChurch
            // 
            this.btnUpdateChurch.Location = new System.Drawing.Point(1145, 610);
            this.btnUpdateChurch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateChurch.Name = "btnUpdateChurch";
            this.btnUpdateChurch.Size = new System.Drawing.Size(137, 50);
            this.btnUpdateChurch.TabIndex = 21;
            this.btnUpdateChurch.Text = "Update Selected";
            this.btnUpdateChurch.UseVisualStyleBackColor = true;
            this.btnUpdateChurch.Click += new System.EventHandler(this.BtnUpdateChurch_Click);
            // 
            // btnCreateChurch
            // 
            this.btnCreateChurch.Location = new System.Drawing.Point(624, 610);
            this.btnCreateChurch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateChurch.Name = "btnCreateChurch";
            this.btnCreateChurch.Size = new System.Drawing.Size(137, 50);
            this.btnCreateChurch.TabIndex = 20;
            this.btnCreateChurch.Text = "Create New";
            this.btnCreateChurch.UseVisualStyleBackColor = true;
            this.btnCreateChurch.Click += new System.EventHandler(this.BtnCreateChurch_Click);
            // 
            // btnSortChurch
            // 
            this.btnSortChurch.Location = new System.Drawing.Point(273, 25);
            this.btnSortChurch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSortChurch.Name = "btnSortChurch";
            this.btnSortChurch.Size = new System.Drawing.Size(52, 28);
            this.btnSortChurch.TabIndex = 19;
            this.btnSortChurch.Text = "Go";
            this.btnSortChurch.UseVisualStyleBackColor = true;
            this.btnSortChurch.Click += new System.EventHandler(this.BtnSortChurch_Click);
            // 
            // cboSortChurch
            // 
            this.cboSortChurch.FormattingEnabled = true;
            this.cboSortChurch.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Organization"});
            this.cboSortChurch.Location = new System.Drawing.Point(104, 27);
            this.cboSortChurch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSortChurch.Name = "cboSortChurch";
            this.cboSortChurch.Size = new System.Drawing.Size(160, 24);
            this.cboSortChurch.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sort By:";
            // 
            // btnSearchChurch
            // 
            this.btnSearchChurch.Location = new System.Drawing.Point(980, 25);
            this.btnSearchChurch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchChurch.Name = "btnSearchChurch";
            this.btnSearchChurch.Size = new System.Drawing.Size(100, 28);
            this.btnSearchChurch.TabIndex = 16;
            this.btnSearchChurch.Text = "Search:";
            this.btnSearchChurch.UseVisualStyleBackColor = true;
            this.btnSearchChurch.Click += new System.EventHandler(this.BtnSearchChurch_Click);
            // 
            // dgvChurch
            // 
            this.dgvChurch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChurch.Location = new System.Drawing.Point(483, 71);
            this.dgvChurch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvChurch.Name = "dgvChurch";
            this.dgvChurch.Size = new System.Drawing.Size(1047, 511);
            this.dgvChurch.TabIndex = 15;
            // 
            // cboFilterChurch
            // 
            this.cboFilterChurch.FormattingEnabled = true;
            this.cboFilterChurch.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Email",
            "Phone",
            "Street Address",
            "Zip Code",
            "Organization"});
            this.cboFilterChurch.Location = new System.Drawing.Point(1368, 25);
            this.cboFilterChurch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFilterChurch.Name = "cboFilterChurch";
            this.cboFilterChurch.Size = new System.Drawing.Size(160, 24);
            this.cboFilterChurch.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1088, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 22);
            this.textBox1.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(19, 70);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(428, 500);
            this.listBox1.TabIndex = 25;
            // 
            // frmChurch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 690);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnReadChurch);
            this.Controls.Add(this.btnRefreshChurch);
            this.Controls.Add(this.btnDeleteChurch);
            this.Controls.Add(this.btnUpdateChurch);
            this.Controls.Add(this.btnCreateChurch);
            this.Controls.Add(this.btnSortChurch);
            this.Controls.Add(this.cboSortChurch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchChurch);
            this.Controls.Add(this.dgvChurch);
            this.Controls.Add(this.cboFilterChurch);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChurch";
            this.Text = "Church List";
            this.Load += new System.EventHandler(this.FrmChurch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChurch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadChurch;
        private System.Windows.Forms.Button btnRefreshChurch;
        private System.Windows.Forms.Button btnDeleteChurch;
        private System.Windows.Forms.Button btnUpdateChurch;
        private System.Windows.Forms.Button btnCreateChurch;
        private System.Windows.Forms.Button btnSortChurch;
        private System.Windows.Forms.ComboBox cboSortChurch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchChurch;
        private System.Windows.Forms.DataGridView dgvChurch;
        private System.Windows.Forms.ComboBox cboFilterChurch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}