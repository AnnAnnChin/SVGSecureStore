namespace SVGSecureStore
{
    partial class ClientMainForm
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
            this.labelLoginUser = new System.Windows.Forms.Label();
            this.textNRIC = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNRIC = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelMobile = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textMobileNum = new System.Windows.Forms.TextBox();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.labelNRICSearch = new System.Windows.Forms.Label();
            this.labelNameSearch = new System.Windows.Forms.Label();
            this.textNRICSearch = new System.Windows.Forms.TextBox();
            this.textNameSearch = new System.Windows.Forms.TextBox();
            this.buttonUpdateAcc = new System.Windows.Forms.Button();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelLoginUser
            // 
            this.labelLoginUser.AutoSize = true;
            this.labelLoginUser.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginUser.Location = new System.Drawing.Point(80, 30);
            this.labelLoginUser.Name = "labelLoginUser";
            this.labelLoginUser.Size = new System.Drawing.Size(131, 13);
            this.labelLoginUser.TabIndex = 0;
            this.labelLoginUser.Text = "You are logged in as XXX.";
            // 
            // textNRIC
            // 
            this.textNRIC.Location = new System.Drawing.Point(190, 97);
            this.textNRIC.Name = "textNRIC";
            this.textNRIC.ReadOnly = true;
            this.textNRIC.Size = new System.Drawing.Size(150, 20);
            this.textNRIC.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Location = new System.Drawing.Point(80, 130);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Client Name";
            // 
            // labelNRIC
            // 
            this.labelNRIC.AutoSize = true;
            this.labelNRIC.BackColor = System.Drawing.Color.Transparent;
            this.labelNRIC.Location = new System.Drawing.Point(80, 100);
            this.labelNRIC.Name = "labelNRIC";
            this.labelNRIC.Size = new System.Drawing.Size(73, 13);
            this.labelNRIC.TabIndex = 5;
            this.labelNRIC.Text = "NRIC Number";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.BackColor = System.Drawing.Color.Transparent;
            this.labelSalary.Location = new System.Drawing.Point(80, 250);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(104, 13);
            this.labelSalary.TabIndex = 6;
            this.labelSalary.Text = "Annual Salary (SGD)";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Location = new System.Drawing.Point(80, 160);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(76, 13);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "Home Address";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Location = new System.Drawing.Point(80, 190);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(73, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email Address";
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.BackColor = System.Drawing.Color.Transparent;
            this.labelMobile.Location = new System.Drawing.Point(80, 220);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(78, 13);
            this.labelMobile.TabIndex = 9;
            this.labelMobile.Text = "Mobile Number";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(190, 127);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(250, 20);
            this.textName.TabIndex = 10;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(190, 157);
            this.textAddress.Name = "textAddress";
            this.textAddress.ReadOnly = true;
            this.textAddress.Size = new System.Drawing.Size(250, 20);
            this.textAddress.TabIndex = 11;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(190, 187);
            this.textEmail.Name = "textEmail";
            this.textEmail.ReadOnly = true;
            this.textEmail.Size = new System.Drawing.Size(250, 20);
            this.textEmail.TabIndex = 12;
            // 
            // textMobileNum
            // 
            this.textMobileNum.Location = new System.Drawing.Point(190, 217);
            this.textMobileNum.Name = "textMobileNum";
            this.textMobileNum.ReadOnly = true;
            this.textMobileNum.Size = new System.Drawing.Size(150, 20);
            this.textMobileNum.TabIndex = 13;
            // 
            // textSalary
            // 
            this.textSalary.Location = new System.Drawing.Point(190, 247);
            this.textSalary.Name = "textSalary";
            this.textSalary.ReadOnly = true;
            this.textSalary.Size = new System.Drawing.Size(150, 20);
            this.textSalary.TabIndex = 14;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(525, 399);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(160, 25);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "Search Client Information";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(365, 280);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 25);
            this.buttonNext.TabIndex = 16;
            this.buttonNext.Text = "Next >";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(80, 280);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 25);
            this.buttonPrevious.TabIndex = 17;
            this.buttonPrevious.Text = "< Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // labelNRICSearch
            // 
            this.labelNRICSearch.AutoSize = true;
            this.labelNRICSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelNRICSearch.Location = new System.Drawing.Point(80, 375);
            this.labelNRICSearch.Name = "labelNRICSearch";
            this.labelNRICSearch.Size = new System.Drawing.Size(73, 13);
            this.labelNRICSearch.TabIndex = 19;
            this.labelNRICSearch.Text = "NRIC Number";
            // 
            // labelNameSearch
            // 
            this.labelNameSearch.AutoSize = true;
            this.labelNameSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelNameSearch.Location = new System.Drawing.Point(80, 405);
            this.labelNameSearch.Name = "labelNameSearch";
            this.labelNameSearch.Size = new System.Drawing.Size(64, 13);
            this.labelNameSearch.TabIndex = 20;
            this.labelNameSearch.Text = "Client Name";
            // 
            // textNRICSearch
            // 
            this.textNRICSearch.Location = new System.Drawing.Point(190, 372);
            this.textNRICSearch.Name = "textNRICSearch";
            this.textNRICSearch.Size = new System.Drawing.Size(150, 20);
            this.textNRICSearch.TabIndex = 22;
            // 
            // textNameSearch
            // 
            this.textNameSearch.Location = new System.Drawing.Point(190, 402);
            this.textNameSearch.Name = "textNameSearch";
            this.textNameSearch.Size = new System.Drawing.Size(250, 20);
            this.textNameSearch.TabIndex = 23;
            // 
            // buttonUpdateAcc
            // 
            this.buttonUpdateAcc.Location = new System.Drawing.Point(450, 24);
            this.buttonUpdateAcc.Name = "buttonUpdateAcc";
            this.buttonUpdateAcc.Size = new System.Drawing.Size(160, 25);
            this.buttonUpdateAcc.TabIndex = 24;
            this.buttonUpdateAcc.Text = "Update Your Information";
            this.buttonUpdateAcc.UseVisualStyleBackColor = true;
            this.buttonUpdateAcc.Click += new System.EventHandler(this.buttonUpdateAcc_Click);
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.Location = new System.Drawing.Point(12, 550);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(391, 13);
            this.labelCopyright.TabIndex = 25;
            this.labelCopyright.Text = "SVG Golf Country Club. Interface created by Chin Ann and is Copyright Protected.";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(525, 180);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(160, 25);
            this.buttonUpdate.TabIndex = 26;
            this.buttonUpdate.Text = "Update Client Information";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(650, 24);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 25);
            this.buttonLogout.TabIndex = 27;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(525, 140);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 25);
            this.buttonAdd.TabIndex = 28;
            this.buttonAdd.Text = "Add Client Information";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(525, 220);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(160, 25);
            this.buttonDelete.TabIndex = 29;
            this.buttonDelete.Text = "Delete Client Information";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(321, 9);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(19, 13);
            this.labelHour.TabIndex = 40;
            this.labelHour.Text = "00";
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(362, 9);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(19, 13);
            this.labelMinutes.TabIndex = 41;
            this.labelMinutes.Text = "15";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(401, 9);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(19, 13);
            this.labelSeconds.TabIndex = 42;
            this.labelSeconds.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = ":";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ClientMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.buttonUpdateAcc);
            this.Controls.Add(this.textNameSearch);
            this.Controls.Add(this.textNRICSearch);
            this.Controls.Add(this.labelNameSearch);
            this.Controls.Add(this.labelNRICSearch);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textSalary);
            this.Controls.Add(this.textMobileNum);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelMobile);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelNRIC);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textNRIC);
            this.Controls.Add(this.labelLoginUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ClientMainForm";
            this.Text = "SVGSecureStore - Home";
            this.Load += new System.EventHandler(this.ClientMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNRIC;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNRIC;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textMobileNum;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Label labelNRICSearch;
        private System.Windows.Forms.Label labelNameSearch;
        private System.Windows.Forms.TextBox textNRICSearch;
        private System.Windows.Forms.TextBox textNameSearch;
        private System.Windows.Forms.Button buttonUpdateAcc;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelLoginUser;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
    }
}