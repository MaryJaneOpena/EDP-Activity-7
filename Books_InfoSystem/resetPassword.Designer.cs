namespace Books_InfoSystem
{
    partial class resetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resetPassword));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resetPassLabel = new System.Windows.Forms.Label();
            this.hideLoginPass = new System.Windows.Forms.PictureBox();
            this.showLoginPass = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideLoginPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLoginPass)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 448);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // resetPassLabel
            // 
            this.resetPassLabel.AutoSize = true;
            this.resetPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPassLabel.Location = new System.Drawing.Point(513, 91);
            this.resetPassLabel.Name = "resetPassLabel";
            this.resetPassLabel.Size = new System.Drawing.Size(185, 25);
            this.resetPassLabel.TabIndex = 28;
            this.resetPassLabel.Text = "Password Recovery";
            // 
            // hideLoginPass
            // 
            this.hideLoginPass.BackColor = System.Drawing.Color.White;
            this.hideLoginPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hideLoginPass.BackgroundImage")));
            this.hideLoginPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hideLoginPass.Location = new System.Drawing.Point(648, 237);
            this.hideLoginPass.Name = "hideLoginPass";
            this.hideLoginPass.Size = new System.Drawing.Size(62, 23);
            this.hideLoginPass.TabIndex = 34;
            this.hideLoginPass.TabStop = false;
            this.hideLoginPass.Visible = false;
            // 
            // showLoginPass
            // 
            this.showLoginPass.BackColor = System.Drawing.Color.White;
            this.showLoginPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showLoginPass.BackgroundImage")));
            this.showLoginPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showLoginPass.Location = new System.Drawing.Point(648, 237);
            this.showLoginPass.Name = "showLoginPass";
            this.showLoginPass.Size = new System.Drawing.Size(62, 23);
            this.showLoginPass.TabIndex = 35;
            this.showLoginPass.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(477, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Password:";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(477, 237);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(233, 24);
            this.passwordTxtBox.TabIndex = 31;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.Location = new System.Drawing.Point(477, 169);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(233, 24);
            this.usernameTxtBox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Username:";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Cyan;
            this.saveButton.Location = new System.Drawing.Point(545, 292);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 38;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Pink;
            this.cancelButton.Location = new System.Drawing.Point(635, 292);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 37;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // resetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.hideLoginPass);
            this.Controls.Add(this.showLoginPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resetPassLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "resetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideLoginPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLoginPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label resetPassLabel;
        private System.Windows.Forms.PictureBox hideLoginPass;
        private System.Windows.Forms.PictureBox showLoginPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}