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
    public partial class ClientMainForm : Form
    {
        int count;

        public int seconds; // Seconds.  
        public int minutes; // Minutes.  
        public int hours;   // Hours.  
        public bool paused;
        public String setTimeHours = "00";
        public String setTimeMinutes = "15";
        public String setTimeSeconds = "00";

        Client[] clientList;
        Client client;
        ClientController cControl = new ClientController();
        ClientForm clientForm = new ClientForm();

        User[] userList;
        User currLoginUser;
        UserController uControl = new UserController();
        UserForm userForm = new UserForm();

        public ClientMainForm()
        {
            InitializeComponent();
            clientList = cControl.GetClientList();
            userList = uControl.GetUserList();
            count = -1;
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            ClientController cControl1 = new ClientController();    //Reestablish connection to get up-to-date Client list.
            clientList = cControl1.GetClientList(); 
            
            count--;
            
            if (count == -1 || count == -2)
            {
                count = clientList.Length - 1;
            }

            client = clientList[count];
            GetClientInfo(client);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ClientController cControl1 = new ClientController();    //Reestablish connection to get up-to-date Client list.
            clientList = cControl1.GetClientList(); 
            
            count++;
            
            if (count == clientList.Length)
            {
                count = 0;
            }

            client = clientList[count];
            GetClientInfo(client);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchNRIC = textNRICSearch.Text;
            string searchName = textNameSearch.Text;

            client = cControl.SearchClient(searchNRIC, searchName);

            if (client == null)
            {
                MessageBox.Show("No record found.");
                return;
            }

            else
            {
                GetClientInfo(client);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            clientForm.SetManageOption("", "Add");
            clientForm.ReInitialise();
            clientForm.ShowDialog();
            clientList = cControl.GetClientList();
        }
        
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            clientForm.SetManageOption(client.GetNRIC(), "Update");
            clientForm.ReInitialise();
            clientForm.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            clientForm.SetManageOption(client.GetNRIC(), "Delete");
            clientForm.ReInitialise();
            clientForm.ShowDialog();
        }

        private void buttonUpdateAcc_Click(object sender, EventArgs e)
        {
            userForm.SetManageOption(currLoginUser.GetUserID(), "UpdateAcc");
            userForm.ReInitialise();
            userForm.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
            clientList = cControl.GetClientList();
        }

        private void userForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
            userList = uControl.GetUserList();
        }

        private void ClientMainForm_Load(object sender, EventArgs e)
        {

        }

        private void GetClientInfo(Client currClient)   //Load the Client information into the textboxes.
        {
            textNRIC.Text = currClient.GetNRIC();
            textName.Text = currClient.GetClientName();
            textAddress.Text = currClient.GetAddress();
            textEmail.Text = currClient.GetEmail();
            textMobileNum.Text = currClient.GetMobileNum().ToString();
            textSalary.Text = currClient.GetSalary().ToString();
        }

        public void SetCurrLoginUser(string id)     //Get the login user from loginForm and set it in this form.
        {
            for (int i = 0; i < userList.Length; i++)
            {
                if (userList[i].GetUserID().Equals(id))
                {
                    currLoginUser = userList[i];
                }
            }

            labelLoginUser.Text = "You are logged in as " + currLoginUser.GetUserName() + ".";
        }

        public void SetControls(bool visible)   //Set the controls to be visible or not.
        {
            buttonAdd.Visible = visible;
            buttonDelete.Visible = visible;
        }

        public void startTimer()    //Activate timer.
        {
            timer2.Enabled = true;
            try
            {
                hours = System.Convert.ToInt32(setTimeHours);
                minutes = System.Convert.ToInt32(setTimeMinutes);
                seconds = System.Convert.ToInt32(setTimeSeconds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if ((minutes == 0) && (hours == 0) && (seconds == 0))
            {
                timer2.Enabled = false;
                this.Close();
            }

            else
            {
                if (seconds < 1)    // Else continue counting.  
                {
                    seconds = 59;
                    if (minutes == 0)
                    {
                        minutes = 59;
                        if (hours != 0)
                            hours -= 1;
                    }
                    else
                    {
                        minutes -= 1;
                    }
                }

                else
                {
                    seconds -= 1;
                    // Display the current values of hours, minutes and seconds in the corresponding fields.  
                    labelHour.Text = hours.ToString();
                    labelMinutes.Text = minutes.ToString();
                    labelSeconds.Text = seconds.ToString();
                }
            }
        }
    }
}
