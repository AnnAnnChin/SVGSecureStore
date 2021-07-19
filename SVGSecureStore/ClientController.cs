using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace SVGSecureStore
{
    class ClientController
    {
        Client[] clientList;
        OleDbDataAdapter dbAdapter;
        DataSet clientDS;
        DataTable clientTable;
        DataRowCollection clientRowList;
        
        public ClientController()
        {
            OleDbConnection dbConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=SVGSecureStore.mdb");
            string sqlStatement = "Select * from Client";
            dbConn.Open();

            dbAdapter = new OleDbDataAdapter(sqlStatement, dbConn);                 //Establish new connection to the database.
            OleDbCommandBuilder dbCommand = new OleDbCommandBuilder(dbAdapter);     //Initialise the set of SQL commands.
            clientDS = new DataSet();
            dbAdapter.Fill(clientDS);           //Fill DataSet fetched from the database.
            
            clientTable = clientDS.Tables[0];   //Get the client table from the DataSet.
            clientRowList = clientTable.Rows;   //Get the list of client rows from the client table.
            clientList = GetClientList();       //Initialise the current list of clients.
        }

        public Client[] GetClientList()     //Get current list of clients
        {
            DataRow row;
            clientList = new Client[clientRowList.Count];

            for (int i = 0; i < clientRowList.Count; ++i)
            {
                row = clientRowList[i];
                clientList[i] = new Client();

                clientList[i].SetNRIC((string)row["NRIC"]);
                clientList[i].SetClientName((string)row["Client_Name"]);
                clientList[i].SetAddress((string)row["Address"]);
                clientList[i].SetEmail((string)row["Email"]);
                clientList[i].SetMobileNum((Int32)row["Mobile_No"]);
                clientList[i].SetSalary((Int32)row["Salary"]);
            }

            return clientList;
        }

        public Client SearchClient(string nric, string name)    //Search client based on NRIC and name.
        {
            Client searchResult = null;

            for (int i = 0; i < clientList.Length; i++)
            {
                if (clientList[i].GetNRIC().Equals(nric) || clientList[i].GetClientName().Equals(name))  //Try to find a match in NRIC or name.
                {
                    searchResult = clientList[i];
                    break;
                }
            }

            return searchResult;
        }

        public void InsertClient(Client cInsert)
        {
            DataRow insertNewRow = clientTable.NewRow();    //Create new row for new client information.

            insertNewRow["NRIC"] = cInsert.GetNRIC(); 
            insertNewRow["Client_Name"] = cInsert.GetClientName();
            insertNewRow["Address"] = cInsert.GetAddress();
            insertNewRow["Email"] = cInsert.GetEmail();
            insertNewRow["Mobile_No"] = cInsert.GetMobileNum();
            insertNewRow["Salary"] = cInsert.GetSalary();

            clientTable.Rows.Add(insertNewRow);                 //Insert new row into the client database.
            dbAdapter.Update(clientDS, clientTable.TableName);  //Commit the updated client table into the database.
        }

        public void UpdateClient(Client cUpdate)
        {
            clientRowList = clientTable.Rows;   //Obtain the updated client row list from the client table.
            DataRow updateRow;

            for (int i = 0; i < clientList.Length; i++)
            {
                updateRow = clientRowList[i];

                if (cUpdate.GetNRIC() == (string)updateRow["NRIC"])    //Check for the row that needs to be updated.
                {
                    updateRow["Client_Name"] = cUpdate.GetClientName();
                    updateRow["Address"] = cUpdate.GetAddress();
                    updateRow["Email"] = cUpdate.GetEmail();
                    updateRow["Mobile_No"] = cUpdate.GetMobileNum();
                    updateRow["Salary"] = cUpdate.GetSalary();

                    dbAdapter.Update(clientDS, clientTable.TableName);  //Commit the updated client table into the database.
                    break;
                }
            }
        }

        public void DeleteClient(Client cDelete)    //
        {
            DataRow deleteRow;

            for (int i = 0; i < clientList.Length; i++)
            {
                deleteRow = clientDS.Tables[0].Rows[i];

                if (cDelete.GetNRIC() == (string)deleteRow["NRIC"])     //Check for the row that needs to be deleted.
                {
                    clientRowList[i].Delete();                          //Delete the row.
                    dbAdapter.Update(clientDS, clientTable.TableName);  //Commit the updated client table into the database.
                }
            }
        }
    }
}
