using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Data;

namespace SchoolBanking
{

    class Database
    {
        public DataSet GetAccounts()
        {
            OleDbConnection Conn = new OleDbConnection(connString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "SELECT Class FROM Classes";
            OleDbDataAdapter da = new OleDbDataAdapter(Cmd);//Open connection & run query
            DataSet dset = new DataSet();
            da.Fill(dset); //Fill dataset with results from query
            Conn.Close();
            return dset;
        }

        private const string connString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = SJBankCS.accdb";

        public void Initialise()
        {
            if (File.Exists("SJBankCS.accdb") == false)//if the database doesn't exist
            {
                ADOX.Catalog cat = new ADOX.Catalog();
                cat.Create(connString); //Use constant defined in Program.cs to create database
                OleDbConnection Conn = new OleDbConnection(connString);
                Conn.Open();                    //Open connection to database
                OleDbCommand Cmd = new OleDbCommand();  //Create a database command object
                Cmd.Connection = Conn;
                Cmd.CommandText = "CREATE TABLE Classes(Class CHAR(3), Teacher VARCHAR(20), PRIMARY KEY (Class))";          //Create Classes Table
                Cmd.ExecuteNonQuery();  //Execute (non-query) SQL command.
                                        //Add some classes to the Classes table
                Cmd.CommandText = "INSERT INTO Classes VALUES('5AC','Ms A. Clarke')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Classes VALUES('5DW','Mr D. Wallis')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Classes VALUES('6KH','Mr K. Hashmi')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Classes VALUES('6TG','Ms T. Green')";
                Cmd.ExecuteNonQuery();
                //Create the Accounts table
                Cmd.CommandText = "CREATE TABLE Accounts(StudentId CHAR(6), "
                        + " Forename VARCHAR(15), Surname VARCHAR(20), Class CHAR(3), "
                        + " Balance MONEY, FOREIGN KEY(Class) REFERENCES Classes(Class), "
                        + " PRIMARY KEY (StudentId))";
                Cmd.ExecuteNonQuery();
                //Create the Transactions table
                Cmd.CommandText = "CREATE TABLE Transactions(StudentId CHAR(6), "
                    + " TransDate DATE, Amount MONEY, TransType CHAR(1), "
                    + " FOREIGN KEY(StudentId) REFERENCES Accounts(StudentId), "
                    + " PRIMARY KEY(StudentId,TransDate))";
                Cmd.ExecuteNonQuery();
                Conn.Close();  //Close connection
            }
        }
    }
}

