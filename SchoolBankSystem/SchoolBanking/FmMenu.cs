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

namespace SchoolBanking
{
    public partial class FmMenu : Form
    {
        private void FmMenu_Load(object sender, EventArgs e)

        {
            Database database = new Database();
            database.Initialise();

        }


        private void BtAccounts_Click(object sender, EventArgs e)
        {
            FmAccounts Accounts = new FmAccounts();
            Accounts.ShowDialog();
        }

        private void BtTrans_Click(object sender, EventArgs e)
        {
            FmTransations Transactions = new FmTransations();
            Transactions.ShowDialog();
        }

        private void BtStats_Click(object sender, EventArgs e)
        {
            FmStatistics Statistics = new FmStatistics();
            Statistics.ShowDialog();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
