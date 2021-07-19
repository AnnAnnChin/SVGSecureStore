namespace SVGSecureStore
{
    partial class LoginForm
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.labelLoginInfo = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Location = new System.Drawing.Point(75, 130);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(43, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "User ID";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Location = new System.Drawing.Point(75, 160);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(134, 127);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(250, 20);
            this.textID.TabIndex = 2;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(134, 157);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(250, 20);
            this.textPassword.TabIndex = 3;
            // 
            // labelLoginInfo
            // 
            this.labelLoginInfo.AutoSize = true;
            this.labelLoginInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginInfo.Location = new System.Drawing.Point(75, 80);
            this.labelLoginInfo.Name = "labelLoginInfo";
            this.labelLoginInfo.Size = new System.Drawing.Size(298, 13);
            this.labelLoginInfo.TabIndex = 4;
            this.labelLoginInfo.Text = "Enter your login information here, then click the Log In Button.";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(309, 185);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 25);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.Location = new System.Drawing.Point(12, 334);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(420, 13);
            this.labelCopyright.TabIndex = 6;
            this.labelCopyright.Text = "SVG Golf Country Club. Login Interface created by Chin Ann and is Copyright Prote" +
                "cted.";
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.BackColor = System.Drawing.Color.Transparent;
            this.labelRegister.Location = new System.Drawing.Point(75, 250);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(122, 13);
            this.labelRegister.TabIndex = 7;
            this.labelRegister.Text = "Don\'t have an account?";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(203, 247);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(100, 25);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Register one";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(506, 356);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelLoginInfo);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "SVGSecureStore - Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label labelLoginInfo;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Button buttonRegister;
    }
}

