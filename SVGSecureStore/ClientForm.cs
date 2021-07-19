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
    public partial class ClientForm : Form
    {
        string authenString;
        string option;  //Specify Operation intended (ADD, UPDATE OR DELETE)

        Client[] clientList;
        Client client;

        MiscController mControl = new MiscController();
        ClientController cControl = new ClientController();

        public ClientForm()
        {
            InitializeComponent();
            clientList = cControl.GetClientList();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (option.Equals("Add"))
            {
                Client cInsert = new Client();
                
                bool check1 = SetClientInfo(cInsert);
                if (check1 == false)
                {
                    MessageBox.Show("ERROR: Invalid Mobile Number and/or Salary.");
                    return;
                }

                bool check2 = CheckRequiredInput(cInsert);
                if (check2 == false)
                {
                    MessageBox.Show("ERROR: NRIC and/or Name required.");
                    return;
                }

                for (int i = 0; i < clientList.Length; i++)
                {
                    if (cInsert.GetNRIC().Equals(clientList[i].GetNRIC()))
                    {
                        MessageBox.Show("ERROR: A client with the same NRIC already exists.");
                        return;
                    }
                }

                bool check3 = Authentication();
                if (check3 == false)
                {
                    MessageBox.Show("ERROR: Invalid or wrong authentication number. Please try again.");
                    return;
                }

                try 
                {
                    cControl.InsertClient(cInsert);
                    clientList = cControl.GetClientList();

                    MessageBox.Show("SUCCESS: New client information has been added.");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("ERROR: Error in inserting new contact. Please try again later.");
                    return;
                }
            }

            else if (option.Equals("Update"))
            {
                bool check1 = SetClientInfo(client);
                if (check1 == false)
                {
                    MessageBox.Show("ERROR: Invalid Mobile Number and/or Salary.");
                    return;
                }

                bool check2 = CheckRequiredInput(client);
                if (check2 == false)
                {
                    MessageBox.Show("ERROR: NRIC and/or Name required.");
                    return;
                }

                bool check3 = Authentication();
                if (check3 == false)
                {
                    MessageBox.Show("ERROR: Invalid or wrong authentication number. Please try again.");
                    return;
                }

                try
                {
                    cControl.UpdateClient(client);
                    MessageBox.Show("SUCCESS: Client information has been updated.");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("ERROR: Error in updating new client. Please try again later.");
                    return;
                }
            }

            else if (option.Equals("Delete"))
            {
                bool check3 = Authentication();
                if (check3 == false)
                {
                    MessageBox.Show("ERROR: Invalid or wrong authentication number. Please try again.");
                    return;
                }

                try
                {
                    cControl.DeleteClient(client);
                    MessageBox.Show("SUCCESS: Client information has been deleted.");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("ERROR: Error in deleting new client. Please try again later.");
                    return;
                }
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        public void SetManageOption(string nric, string option)   //Set the operation (Insert, Update, Delete) and the Client to operate on.
        {
            for (int i = 0; i < clientList.Length; i++)
            {
                if (clientList[i].GetNRIC() == nric)     //Check for a match in Client NRIC.
                {
                    client = clientList[i];
                }
            }
            
            this.option = option;
        }

        public void ReInitialise()      //Set the restriction of controls depending on relevant operations and user role.
        {
            this.Text = "SVGSecureStore - "+option+" Client";
            authenString = mControl.GetRandomString();
            labelAuthen.Text = "Enter the 8 characters as shown: " + authenString;

            if (option.Equals("Add"))
            {
                SetReadOnly(false);
                TextBoxClear();
            }

            else if (option.Equals("Update"))
            {
                SetReadOnly(false);
                TextBoxClear();
                GetClientInfo();
            }

            else if (option.Equals("Delete"))
            {
                SetReadOnly(true);
                TextBoxClear();
                GetClientInfo();
            }
        }

        private void TextBoxClear()     //Clear the contents of textboxes.
        {
            textNRIC.Clear();
            textName.Clear();
            textAddress.Clear();
            textEmail.Clear();
            textMobileNum.Clear();
            textSalary.Clear();
            textAuthen.Clear();
        }

        private void SetReadOnly(bool readOnly)     //Set textboxes as read-only (Not allowed for user modifying)
        {
            textNRIC.ReadOnly = readOnly;
            textName.ReadOnly = readOnly;
            textAddress.ReadOnly = readOnly;
            textEmail.ReadOnly = readOnly;
            textMobileNum.ReadOnly = readOnly;
            textSalary.ReadOnly = readOnly;
        }

        private void GetClientInfo()      //Load a User's information on textbox displays.
        {
            textNRIC.Text = client.GetNRIC();
            textName.Text = client.GetClientName();
            textAddress.Text = client.GetAddress();
            textEmail.Text = client.GetEmail();
            textMobileNum.Text = client.GetMobileNum().ToString();
            textSalary.Text = client.GetSalary().ToString();
        }

        private bool SetClientInfo(Client clientManaged)      //Attempt to set Client's information based on what is entered into textboxes.
        {
            bool check1 = true;

            clientManaged.SetNRIC(textNRIC.Text);
            clientManaged.SetClientName(textName.Text);
            clientManaged.SetAddress(textAddress.Text);
            clientManaged.SetEmail(textEmail.Text);

            try
            {
                clientManaged.SetMobileNum(Int32.Parse(textMobileNum.Text));
                clientManaged.SetSalary(Int32.Parse(textSalary.Text));
            }
            catch
            {
                check1 = false;
            }

            return check1;
        }

        private bool CheckRequiredInput(Client clientInput)     //Check if the required inputs are filled in.
        {
            bool check2 = true;

            if (clientInput.GetNRIC().Equals("") || clientInput.GetClientName().Equals("")) //Check for blank input in required fields.
            {
                check2 = false;
            }

            return check2;
        }

        private bool Authentication()   //Check if the authentication string is entered correctly.
        {
            bool check3 = true;
            
            if (textAuthen.Text.Equals(authenString.ToString()) == false)   //If authentication fails, authentication string will be regenerated.
            {
                authenString = mControl.GetRandomString();
                labelAuthen.Text = "Enter the 8 characters as shown: " + authenString;
                check3 = false;
            }

            return check3;
        }
    }
}
