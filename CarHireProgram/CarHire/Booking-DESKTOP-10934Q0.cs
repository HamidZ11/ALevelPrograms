using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CarHire
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        string engineType = " ";

        private void Booking_Load(object sender, EventArgs e)
        {
            gbAddCustomer.Hide();
            gbSearch.Hide();
            gbBookings.Hide();
            dtpStart.MinDate = DateTime.Today.AddDays(1);
            dtpStart.MaxDate = DateTime.Today.AddYears(1);
            nbNoOfSeats.Minimum = 2;
            nbNoOfSeats.Maximum = 8;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void NextcustomerID_Click(object sender, EventArgs e)
        {

        }

        private string NextcustomerID_Click_1(object sender, EventArgs e)
        {
            int NextID;
            OleDbConnection conn = new OleDbConnection(Program.ConStr);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "SELECT MAX(CustomerID) As MaxID FROM Customer";
            if (cmd.ExecuteScalar() != DBNull.Value) //If a value is returned
            {
                NextID = Convert.ToInt32(cmd.ExecuteScalar()) + 1; //Set NextID to value returened + 1
            }
            else
                NextID = 1; //If no value is returned then the table was empty
            conn.Close();
            //Now add on leading zeroes
            string ID = "0000" + NextID.ToString();
            ID = ID.Substring(ID.Length - 4); //reduce to 4 digits
            return ID;
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (chbreturning.Checked)
            {
                gbSearch.Show();
                gbAddCustomer.Hide();
                cbCustomerSearch.Enabled = false;
                btConfirm.Enabled = false;
            }
            else
            {
                lbID.Text = NextcustomerID();
                gbAddCustomer.Show();
                gbSearch.Hide();
            }
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "");
            {
                OleDbConnection conn = new OleDbConnection(Program.ConStr);
                OleDbConnection cmd = new OleDbCommand();
                cmd.Connection = conn;
                conn.Open();
                //query to find customers with the same postcode
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
