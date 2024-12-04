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

namespace SchoolBanking
{
    public partial class FmAccounts : Form
    {
        public FmAccounts()
        {
            InitializeComponent();
        }

        private void FmAccounts_Load(object sender, EventArgs e)

        {
            OleDbConnection Conn = new OleDbConnection(Program.ConnString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "SELECT Class FROM Classes";
            OleDbDataAdapter da = new OleDbDataAdapter(Cmd);//Open connection & run query
            DataSet dset = new DataSet();
            da.Fill(dset); //Fill dataset with results from query
            Conn.Close();
            cbClass.DataSource = dset.Tables[0]; //Load data into combobox
            cbClass.DisplayMember = "Class"; //Set the attribute to be displayed
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txStudentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.CreateAccount(txStudentId.Text, txForename.Text,
                lbSurname.Text, cbClass.Text, lbBalance.Text);
            MessageBox.Show("Details saved");
        }

    }
}
