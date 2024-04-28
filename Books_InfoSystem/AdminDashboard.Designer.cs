namespace Books_InfoSystem
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acc_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Users = new System.Windows.Forms.PictureBox();
            this.usersList = new System.Windows.Forms.Label();
            this.formAccount = new System.Windows.Forms.Panel();
            this.typeTxtBx = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.editAccLabel = new System.Windows.Forms.Label();
            this.SaveEditAccBtn = new System.Windows.Forms.Button();
            this.addAccLabel = new System.Windows.Forms.Label();
            this.cancelPass = new System.Windows.Forms.Button();
            this.saveAddAccBtn = new System.Windows.Forms.Button();
            this.contactTxtBx = new System.Windows.Forms.TextBox();
            this.contactLbl = new System.Windows.Forms.Label();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.passLbl = new System.Windows.Forms.Label();
            this.passTxtBx = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.usernameTxtBx = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users)).BeginInit();
            this.formAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.password,
            this.name,
            this.contacts,
            this.acc_type,
            this.status});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(175, 110);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(555, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.Width = 125;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // contacts
            // 
            this.contacts.HeaderText = "Contacts";
            this.contacts.MinimumWidth = 6;
            this.contacts.Name = "contacts";
            this.contacts.Width = 125;
            // 
            // acc_type
            // 
            this.acc_type.HeaderText = "Type of Account";
            this.acc_type.MinimumWidth = 6;
            this.acc_type.Name = "acc_type";
            this.acc_type.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 125;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(175, 400);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click_1);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(276, 400);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(385, 400);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Books Information System";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 39);
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 39);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(100, 35);
            this.profileToolStripMenuItem.Text = "Logout";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // Users
            // 
            this.Users.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Users.BackgroundImage")));
            this.Users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Users.Location = new System.Drawing.Point(12, 92);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(63, 52);
            this.Users.TabIndex = 23;
            this.Users.TabStop = false;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // usersList
            // 
            this.usersList.AutoSize = true;
            this.usersList.Location = new System.Drawing.Point(81, 110);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(43, 16);
            this.usersList.TabIndex = 24;
            this.usersList.Text = "Users";
            this.usersList.Click += new System.EventHandler(this.usersList_Click);
            // 
            // formAccount
            // 
            this.formAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.formAccount.Controls.Add(this.typeTxtBx);
            this.formAccount.Controls.Add(this.typeLabel);
            this.formAccount.Controls.Add(this.editAccLabel);
            this.formAccount.Controls.Add(this.SaveEditAccBtn);
            this.formAccount.Controls.Add(this.addAccLabel);
            this.formAccount.Controls.Add(this.cancelPass);
            this.formAccount.Controls.Add(this.saveAddAccBtn);
            this.formAccount.Controls.Add(this.contactTxtBx);
            this.formAccount.Controls.Add(this.contactLbl);
            this.formAccount.Controls.Add(this.nameTxtBx);
            this.formAccount.Controls.Add(this.passLbl);
            this.formAccount.Controls.Add(this.passTxtBx);
            this.formAccount.Controls.Add(this.nameLbl);
            this.formAccount.Controls.Add(this.usernameTxtBx);
            this.formAccount.Controls.Add(this.usernameLbl);
            this.formAccount.Location = new System.Drawing.Point(219, 146);
            this.formAccount.Name = "formAccount";
            this.formAccount.Size = new System.Drawing.Size(462, 234);
            this.formAccount.TabIndex = 25;
            this.formAccount.Visible = false;
            // 
            // typeTxtBx
            // 
            this.typeTxtBx.Location = new System.Drawing.Point(127, 154);
            this.typeTxtBx.Name = "typeTxtBx";
            this.typeTxtBx.Size = new System.Drawing.Size(249, 22);
            this.typeTxtBx.TabIndex = 30;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(48, 160);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(42, 16);
            this.typeLabel.TabIndex = 29;
            this.typeLabel.Text = "Type:";
            // 
            // editAccLabel
            // 
            this.editAccLabel.AutoSize = true;
            this.editAccLabel.Location = new System.Drawing.Point(206, 20);
            this.editAccLabel.Name = "editAccLabel";
            this.editAccLabel.Size = new System.Drawing.Size(81, 16);
            this.editAccLabel.TabIndex = 28;
            this.editAccLabel.Text = "Edit Account";
            // 
            // SaveEditAccBtn
            // 
            this.SaveEditAccBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SaveEditAccBtn.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveEditAccBtn.Location = new System.Drawing.Point(127, 189);
            this.SaveEditAccBtn.Name = "SaveEditAccBtn";
            this.SaveEditAccBtn.Size = new System.Drawing.Size(75, 33);
            this.SaveEditAccBtn.TabIndex = 27;
            this.SaveEditAccBtn.Text = "Save";
            this.SaveEditAccBtn.UseVisualStyleBackColor = false;
            this.SaveEditAccBtn.Click += new System.EventHandler(this.SaveEditAccBtn_Click);
            // 
            // addAccLabel
            // 
            this.addAccLabel.AutoSize = true;
            this.addAccLabel.Location = new System.Drawing.Point(187, 20);
            this.addAccLabel.Name = "addAccLabel";
            this.addAccLabel.Size = new System.Drawing.Size(113, 16);
            this.addAccLabel.TabIndex = 11;
            this.addAccLabel.Text = "Add New Account";
            // 
            // cancelPass
            // 
            this.cancelPass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelPass.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelPass.Location = new System.Drawing.Point(225, 189);
            this.cancelPass.Name = "cancelPass";
            this.cancelPass.Size = new System.Drawing.Size(75, 33);
            this.cancelPass.TabIndex = 10;
            this.cancelPass.Text = "Cancel";
            this.cancelPass.UseVisualStyleBackColor = false;
            this.cancelPass.Click += new System.EventHandler(this.cancelPass_Click);
            // 
            // saveAddAccBtn
            // 
            this.saveAddAccBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.saveAddAccBtn.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAddAccBtn.Location = new System.Drawing.Point(127, 189);
            this.saveAddAccBtn.Name = "saveAddAccBtn";
            this.saveAddAccBtn.Size = new System.Drawing.Size(75, 33);
            this.saveAddAccBtn.TabIndex = 9;
            this.saveAddAccBtn.Text = "Save";
            this.saveAddAccBtn.UseVisualStyleBackColor = false;
            this.saveAddAccBtn.Click += new System.EventHandler(this.savePassBtn_Click);
            // 
            // contactTxtBx
            // 
            this.contactTxtBx.Location = new System.Drawing.Point(125, 126);
            this.contactTxtBx.Name = "contactTxtBx";
            this.contactTxtBx.Size = new System.Drawing.Size(249, 22);
            this.contactTxtBx.TabIndex = 1;
            // 
            // contactLbl
            // 
            this.contactLbl.AutoSize = true;
            this.contactLbl.Location = new System.Drawing.Point(46, 132);
            this.contactLbl.Name = "contactLbl";
            this.contactLbl.Size = new System.Drawing.Size(55, 16);
            this.contactLbl.TabIndex = 0;
            this.contactLbl.Text = "Contact:";
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(125, 98);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(249, 22);
            this.nameTxtBx.TabIndex = 1;
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(46, 76);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(70, 16);
            this.passLbl.TabIndex = 0;
            this.passLbl.Text = "Password:";
            // 
            // passTxtBx
            // 
            this.passTxtBx.Location = new System.Drawing.Point(125, 70);
            this.passTxtBx.Name = "passTxtBx";
            this.passTxtBx.Size = new System.Drawing.Size(249, 22);
            this.passTxtBx.TabIndex = 1;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(46, 104);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(47, 16);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name:";
            // 
            // usernameTxtBx
            // 
            this.usernameTxtBx.Location = new System.Drawing.Point(125, 42);
            this.usernameTxtBx.Name = "usernameTxtBx";
            this.usernameTxtBx.Size = new System.Drawing.Size(249, 22);
            this.usernameTxtBx.TabIndex = 1;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(46, 48);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(73, 16);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Username:";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(489, 400);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 26;
            this.refreshBtn.Text = "Reresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(309, 65);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(304, 22);
            this.SearchBox.TabIndex = 29;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Search";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.formAccount);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users)).EndInit();
            this.formAccount.ResumeLayout(false);
            this.formAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn contacts;
        private System.Windows.Forms.PictureBox Users;
        private System.Windows.Forms.Label usersList;
        private System.Windows.Forms.Panel formAccount;
        private System.Windows.Forms.TextBox usernameTxtBx;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox contactTxtBx;
        private System.Windows.Forms.Label contactLbl;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.TextBox passTxtBx;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button cancelPass;
        private System.Windows.Forms.Button saveAddAccBtn;
        private System.Windows.Forms.Label addAccLabel;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button SaveEditAccBtn;
        private System.Windows.Forms.Label editAccLabel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox typeTxtBx;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn acc_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}