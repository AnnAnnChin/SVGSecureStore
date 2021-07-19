using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SVGSecureStore
{
    public partial class LoginForm : Form
    {
        UserController uControl = new UserController();
        MiscController mControl = new MiscController();

        ResetPasswordForm resetPass = new ResetPasswordForm();
        UserForm userForm = new UserForm();
        UserMainForm uMainForm = new UserMainForm();
        ClientMainForm cMainForm = new ClientMainForm();

        int retry = 5;
        DateTime currDate;
        TimeSpan period = new TimeSpan(0, 0, 0, 0);

        public LoginForm()
        {
            InitializeComponent();
            resetPass.FormClosed += new FormClosedEventHandler(resetPass_FormClosed);
            userForm.FormClosed += new FormClosedEventHandler(userForm_FormClosed);
            cMainForm.FormClosed += new FormClosedEventHandler(cMainForm_FormClosed);
            uMainForm.FormClosed += new FormClosedEventHandler(uMainForm_FormClosed);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (uControl.Login(textID.Text, mControl.hashPassword(textPassword.Text)) == true)
            {
                retry = 5;
                this.Hide();
                textID.Clear();
                textPassword.Clear(); 
                
                //if (uControl.GetCurrLoginUser().GetPassExp().Date.Subtract(currDate) > period)
                //{
                //}
                
                uMainForm.startTimer();
                cMainForm.startTimer();
                
                if (uControl.GetCurrLoginUser().GetRole().Equals("Administrator"))
                {
                    uMainForm.SetCurrLoginUser(uControl.GetCurrLoginUser().GetUserID());
                    uMainForm.ShowDialog();
                }

                else if (uControl.GetCurrLoginUser().GetRole().Equals("Supervisor"))
                {
                    cMainForm.SetCurrLoginUser(uControl.GetCurrLoginUser().GetUserID());
                    cMainForm.SetControls(true);
                    cMainForm.ShowDialog();
                }

                else if (uControl.GetCurrLoginUser().GetRole().Equals("Support Officer"))
                {
                    cMainForm.SetCurrLoginUser(uControl.GetCurrLoginUser().GetUserID());
                    cMainForm.SetControls(false);
                    cMainForm.ShowDialog();
                }

                else if (uControl.GetCurrLoginUser().GetRole().Equals("Forgot Password"))
                {
                    resetPass.SetUser(uControl.GetCurrLoginUser().GetUserID());
                    resetPass.ReInitialise();
                    resetPass.ShowDialog();
                }
            }

            else
            {
                textID.Clear();
                textPassword.Clear();
                
                retry--;
                if (retry == 0)
                {
                    textID.ReadOnly = true;
                    textPassword.ReadOnly = true;
                    buttonLogin.Visible = false;
                    MessageBox.Show("You have reached the max number of retries. The system will be now locked.");
                    return;
                }

                MessageBox.Show("Either your username or password is wrong, or that your account might be locked or not activated. "+retry+" retries left.");
                return;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            userForm.SetManageOption("", "Add");
            userForm.ReInitialise();
            userForm.ShowDialog();
        }

        private void resetPass_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
            uControl.GetUserList();
        }

        private void userForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
            uControl.GetUserList();
        }

        private void cMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void uMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
