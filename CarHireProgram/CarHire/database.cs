using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;

namespace CarHire
{
    class database
    {
        private const string connString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = CarDB.accdb";
        public void FmMenuLoad(object sender, EventArgs e)
        {
            if (File.Exists("CarDB.accdb") == false)
            {
                ADOX.Catalog cat = new ADOX.Catalog();
                dynamic dynamic = cat.Create(connString); //Use constant defined in Program.cs to create database
                OleDbConnection Conn = new OleDbConnection(connString);
                Conn.Open();                    //Open connection to database
                OleDbCommand Cmd = new OleDbCommand();  //Create a database command object
                Cmd.Connection = Conn;
                Cmd.CommandText = "CREATE TABLE Car(Registration VARCHAR(8), Make VARCHAR(20), Model VARCHAR(30),";
                Cmd.CommandText += "NoSeats INTEGER, EngineType CHAR(1), DayCost MONEY, PRIMARY KEY(Registration)";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "CREATE TABLE Customer(CustomerID VARCHAR(16), Firstame VARCHAR(20), Surname VARCHAR(20)";
                Cmd.CommandText += "Address VARCHAR(50), Postcode VARCHAR(8), TelephoneNo VARCHAR(10), Email VARCHAR(30)";
                Cmd.CommandText += "PRIMARY KEY (CustomerID))";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "CREATE TABLE Bookings(Registration VARCHAR(8), CustomerID VARCHAR(16), StardDate Date";
                Cmd.CommandText += "EndDate DATE, TotalCost MONEY";
                Cmd.CommandText += "FOREIGN KEY(Registration) REFERENCES Car(Registration),";
                Cmd.CommandText += "FOREIGN KEY(CustomerID) REFERENCES Car(Customer),";
                Cmd.CommandText += "PRIMARY KEY (Registration, CustomerID))";
                Cmd.ExecuteNonQuery();
                Conn.Close();  //Close connection
            }
        }
    }
}
