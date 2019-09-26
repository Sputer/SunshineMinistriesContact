namespace SunshineMinistriesContact.User_Interface
{
    partial class frmUserList
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
            this.lbUserList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUserList
            // 
            this.lbUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserList.FormattingEnabled = true;
            this.lbUserList.ItemHeight = 18;
            this.lbUserList.Location = new System.Drawing.Point(159, 42);
            this.lbUserList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbUserList.Name = "lbUserList";
            this.lbUserList.Size = new System.Drawing.Size(835, 346);
            this.lbUserList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(35, 42);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(116, 28);
            this.btnCreateUser.TabIndex = 2;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.BtnCreateUser_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(35, 92);
            this.btnManage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(116, 28);
            this.btnManage.TabIndex = 3;
            this.btnManage.Text = "Manage User";
            this.btnManage.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(35, 143);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 28);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete User";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 426);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUserList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUserList";
            this.Text = "frmAdminPane";
            this.Load += new System.EventHandler(this.FrmUserList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUserList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnDelete;
    }
}