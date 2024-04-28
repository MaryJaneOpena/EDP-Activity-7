namespace Books_InfoSystem
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userLoginLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.userLoginBtn = new System.Windows.Forms.Button();
            this.signUp = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLoginPass = new System.Windows.Forms.PictureBox();
            this.hideLoginPass = new System.Windows.Forms.PictureBox();
            this.Users = new System.Windows.Forms.PictureBox();
            this.adminLabel = new System.Windows.Forms.Label();
            this.usersLabel = new System.Windows.Forms.Label();
            this.adminLoginLabel = new System.Windows.Forms.Label();
            this.adminLoginBtn = new System.Windows.Forms.Button();
            this.forgotPassLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLoginPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideLoginPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Users)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(40, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 447);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.AutoSize = true;
            this.userLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLoginLabel.Location = new System.Drawing.Point(601, 84);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(66, 25);
            this.userLoginLabel.TabIndex = 1;
            this.userLoginLabel.Text = "LogIn ";
            this.userLoginLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(520, 161);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(233, 24);
            this.username.TabIndex = 5;
            this.username.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(520, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(520, 229);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(233, 24);
            this.passwordTxt.TabIndex = 5;
            this.passwordTxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // userLoginBtn
            // 
            this.userLoginBtn.BackColor = System.Drawing.Color.Cyan;
            this.userLoginBtn.Location = new System.Drawing.Point(606, 276);
            this.userLoginBtn.Name = "userLoginBtn";
            this.userLoginBtn.Size = new System.Drawing.Size(75, 23);
            this.userLoginBtn.TabIndex = 7;
            this.userLoginBtn.Text = "LOGIN";
            this.userLoginBtn.UseVisualStyleBackColor = false;
            this.userLoginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // signUp
            // 
            this.signUp.BackColor = System.Drawing.Color.Pink;
            this.signUp.Location = new System.Drawing.Point(606, 305);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(75, 23);
            this.signUp.TabIndex = 8;
            this.signUp.Text = "SIGNUP";
            this.signUp.UseVisualStyleBackColor = false;
            this.signUp.Click += new System.EventHandler(this.signUpBtn_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // showLoginPass
            // 
            this.showLoginPass.BackColor = System.Drawing.Color.White;
            this.showLoginPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showLoginPass.BackgroundImage")));
            this.showLoginPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showLoginPass.Location = new System.Drawing.Point(691, 229);
            this.showLoginPass.Name = "showLoginPass";
            this.showLoginPass.Size = new System.Drawing.Size(62, 23);
            this.showLoginPass.TabIndex = 9;
            this.showLoginPass.TabStop = false;
            this.showLoginPass.Click += new System.EventHandler(this.showLoginPass_Click);
            // 
            // hideLoginPass
            // 
            this.hideLoginPass.BackColor = System.Drawing.Color.White;
            this.hideLoginPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hideLoginPass.BackgroundImage")));
            this.hideLoginPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hideLoginPass.Location = new System.Drawing.Point(691, 229);
            this.hideLoginPass.Name = "hideLoginPass";
            this.hideLoginPass.Size = new System.Drawing.Size(62, 23);
            this.hideLoginPass.TabIndex = 9;
            this.hideLoginPass.TabStop = false;
            this.hideLoginPass.Visible = false;
            this.hideLoginPass.Click += new System.EventHandler(this.hideLoginPass_Click);
            // 
            // Users
            // 
            this.Users.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Users.BackgroundImage")));
            this.Users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Users.Location = new System.Drawing.Point(3, 395);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(63, 52);
            this.Users.TabIndex = 24;
            this.Users.TabStop = false;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminLabel.Location = new System.Drawing.Point(69, 399);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(45, 16);
            this.adminLabel.TabIndex = 25;
            this.adminLabel.Text = "Admin";
            this.adminLabel.Visible = false;
            this.adminLabel.Click += new System.EventHandler(this.adminLabel_Click);
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersLabel.Location = new System.Drawing.Point(69, 425);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(43, 16);
            this.usersLabel.TabIndex = 26;
            this.usersLabel.Text = "Users";
            this.usersLabel.Visible = false;
            this.usersLabel.Click += new System.EventHandler(this.usersLabel_Click);
            // 
            // adminLoginLabel
            // 
            this.adminLoginLabel.AutoSize = true;
            this.adminLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginLabel.Location = new System.Drawing.Point(559, 84);
            this.adminLoginLabel.Name = "adminLoginLabel";
            this.adminLoginLabel.Size = new System.Drawing.Size(147, 25);
            this.adminLoginLabel.TabIndex = 27;
            this.adminLoginLabel.Text = "Login as Admin";
            this.adminLoginLabel.Visible = false;
            // 
            // adminLoginBtn
            // 
            this.adminLoginBtn.BackColor = System.Drawing.Color.Cyan;
            this.adminLoginBtn.Location = new System.Drawing.Point(606, 276);
            this.adminLoginBtn.Name = "adminLoginBtn";
            this.adminLoginBtn.Size = new System.Drawing.Size(75, 23);
            this.adminLoginBtn.TabIndex = 28;
            this.adminLoginBtn.Text = "LOGIN";
            this.adminLoginBtn.UseVisualStyleBackColor = false;
            this.adminLoginBtn.Visible = false;
            this.adminLoginBtn.Click += new System.EventHandler(this.adminLoginBtn_Click);
            // 
            // forgotPassLabel
            // 
            this.forgotPassLabel.AutoSize = true;
            this.forgotPassLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPassLabel.Location = new System.Drawing.Point(520, 257);
            this.forgotPassLabel.Name = "forgotPassLabel";
            this.forgotPassLabel.Size = new System.Drawing.Size(109, 16);
            this.forgotPassLabel.TabIndex = 29;
            this.forgotPassLabel.Text = "Forgot Password";
            this.forgotPassLabel.Click += new System.EventHandler(this.forgotPassLabel_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.forgotPassLabel);
            this.Controls.Add(this.userLoginLabel);
            this.Controls.Add(this.adminLoginBtn);
            this.Controls.Add(this.adminLoginLabel);
            this.Controls.Add(this.usersLabel);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.hideLoginPass);
            this.Controls.Add(this.showLoginPass);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.userLoginBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLoginPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideLoginPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userLoginLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button userLoginBtn;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox showLoginPass;
        private System.Windows.Forms.PictureBox hideLoginPass;
        private System.Windows.Forms.PictureBox Users;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Label adminLoginLabel;
        private System.Windows.Forms.Button adminLoginBtn;
        private System.Windows.Forms.Label forgotPassLabel;
    }
}

