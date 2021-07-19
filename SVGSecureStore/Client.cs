using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SVGSecureStore
{
    class Client
    {
        string nric;
        string clientName;
        string address;
        string email;
        int mobileNum;
        int salary;

        public Client()
        {
        }

        public string GetNRIC()
        {
            return nric;
        }

        public void SetNRIC(string nric)
        {
            this.nric = nric;
        }
        
        public string GetClientName()
        {
            return clientName;
        }

        public void SetClientName(string name)
        {
            clientName = name;
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public int GetMobileNum()
        {
            return mobileNum;
        }

        public void SetMobileNum(int num)
        {
            mobileNum = num;
        }

        public int GetSalary()
        {
            return salary;
        }

        public void SetSalary(int salary)
        {
            this.salary = salary;
        }
    }
}
