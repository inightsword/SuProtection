namespace SuPassword
{
    partial class Enter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginBtn = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.TypePassword = new System.Windows.Forms.Label();
            this.OpenSUPT = new System.Windows.Forms.PictureBox();
            this.GitHubLink = new System.Windows.Forms.PictureBox();
            this.KeyPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OpenSUPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHubLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyPic)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(70)))), ((int)(((byte)(125)))));
            this.LoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginBtn.Location = new System.Drawing.Point(251, 345);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(175, 34);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Enter >";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(70)))), ((int)(((byte)(125)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Password.Location = new System.Drawing.Point(152, 297);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(390, 30);
            this.Password.TabIndex = 1;
            this.Password.UseSystemPasswordChar = true;
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            // 
            // TypePassword
            // 
            this.TypePassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TypePassword.AutoSize = true;
            this.TypePassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypePassword.ForeColor = System.Drawing.SystemColors.Control;
            this.TypePassword.Location = new System.Drawing.Point(149, 267);
            this.TypePassword.Name = "TypePassword";
            this.TypePassword.Size = new System.Drawing.Size(138, 18);
            this.TypePassword.TabIndex = 2;
            this.TypePassword.Text = "Type your password :";
            // 
            // OpenSUPT
            // 
            this.OpenSUPT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenSUPT.Image = global::SuPassword.Properties.Resources.supt;
            this.OpenSUPT.Location = new System.Drawing.Point(3, 505);
            this.OpenSUPT.Name = "OpenSUPT";
            this.OpenSUPT.Size = new System.Drawing.Size(58, 65);
            this.OpenSUPT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenSUPT.TabIndex = 7;
            this.OpenSUPT.TabStop = false;
            this.OpenSUPT.Click += new System.EventHandler(this.OpenSUPT_Click);
            this.OpenSUPT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OpenSUPT_MouseClick);
            // 
            // GitHubLink
            // 
            this.GitHubLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GitHubLink.Image = global::SuPassword.Properties.Resources.pngegg;
            this.GitHubLink.Location = new System.Drawing.Point(639, 537);
            this.GitHubLink.Name = "GitHubLink";
            this.GitHubLink.Size = new System.Drawing.Size(24, 23);
            this.GitHubLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GitHubLink.TabIndex = 4;
            this.GitHubLink.TabStop = false;
            this.GitHubLink.Click += new System.EventHandler(this.GitHubLink_Click);
            // 
            // KeyPic
            // 
            this.KeyPic.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.KeyPic.Image = global::SuPassword.Properties.Resources.key;
            this.KeyPic.Location = new System.Drawing.Point(116, 54);
            this.KeyPic.Name = "KeyPic";
            this.KeyPic.Size = new System.Drawing.Size(452, 210);
            this.KeyPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KeyPic.TabIndex = 3;
            this.KeyPic.TabStop = false;
            // 
            // Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.OpenSUPT);
            this.Controls.Add(this.GitHubLink);
            this.Controls.Add(this.KeyPic);
            this.Controls.Add(this.TypePassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LoginBtn);
            this.Name = "Enter";
            this.Size = new System.Drawing.Size(677, 573);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.OpenSUPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHubLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label TypePassword;
        private System.Windows.Forms.PictureBox KeyPic;
        private System.Windows.Forms.PictureBox GitHubLink;
        private System.Windows.Forms.PictureBox OpenSUPT;
    }
}
