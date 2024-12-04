using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace CarHire
{
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            nbNoOfSeats.Minimum = 2;
            nbNoOfSeats.Maximum = 8;
        }

        string engineType = "";
        private void rbPetrol_Click(object sender, EventArgs e)
        {
            engineType = "P";
        }

        private void rbDiesel_Click(object sender, EventArgs e)
        {
            engineType = "D";
        }

        private void rbElectric_Click(object sender, EventArgs e)
        {
            engineType = "E";
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //check values have been entered in text boxes
            if (tbRegNumber.Text != "" && tbCarMake.Text != "" && tbCostPerDay.Text != "" )
            {
                if (engineType == "")
                    MessageBox.Show("Please select engine type,");
                else
                {
                    //more validation is needed
                    //need to check if reg number is already in the table before saving- can't duplicate it
                    //additional validation checks should be done for numeric data - range check, type change
                    OleDbConnection conn = new OleDbConnection(Program.ConStr);
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn; 
                    conn.Open();
                    cmd.CommandText = "INSERT INTO CAR VALUES('" + tbRegNumber.Text + "','" + tbCarMake.Text + ",";
                    cmd.CommandText = "'" + tbCarModel.Text + "','" + nbNoOfSeats.Text + "," + engineType + "' ," + tbCostPerDay.Text + ")";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Details Saved");
                    //should now clear the text boxes including the radio buttons
                }
            }
            else
            {
                MessageBox.Show("Please enter all values");
            }
        }
    }
}
