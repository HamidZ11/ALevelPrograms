using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolBanking
{
    public partial class FmTransations : Form
    {
        public FmTransations()
        {
            InitializeComponent();
        }

        private void FmTransations_Load(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btreturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btfind_Click(object sender, EventArgs e)

        {

            OleDbConnection Conn = new OleDbConnection(Program.connString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "SELECT * FROM Accounts WHERE StudentId ='" + txID.Text + "'";
            OleDbDataReader reader = Cmd.ExecuteReader();//Runs the query & allows results to be read.
            if (reader.HasRows) //if a record is found display details
            {
                reader.Read();//Read the first record found
                lbName.Text = reader["Forename"] + " " + reader["Surname"];
                lbBalance.Text = String.Format("{0:N2}", reader["Balance"]);
                gbTrans.Show();
            }
            else
            {
                MessageBox.Show("Student ID not found - please check");
            }
            reader.Close();//Close the reader
            Conn.Close(); //Close the connection
        }
    }
}
