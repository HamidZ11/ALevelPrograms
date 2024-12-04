using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Project
{
    public partial class FMLogExpense : Form
    {
        public FMLogExpense()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get input values
            DateTime expenseDate = dateTimePickerExpenseDate.Value;
            string category = comboBoxCategory.SelectedItem.ToString();
            double amount = Convert.ToDouble(textBoxAmount.Text);
            string description = textBoxDescription.Text;

            // Save expense data (you need to implement this part)
            // For example, you could use a database or a file to store the data

            // Provide feedback to the user
            MessageBox.Show("Expense saved successfully.", "Expense Logged", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input fields for the next entry
            ClearInputFields();
        }
        private void ClearInputFields()
        {
            comboBoxCategory.SelectedIndex = -1;
            textBoxAmount.Clear();
            textBoxDescription.Clear();
        }

        private void FMLogExpense_Load(object sender, EventArgs e)
        {

        }
    }
}
