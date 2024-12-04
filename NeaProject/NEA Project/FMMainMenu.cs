namespace NEA_Project
{
    public partial class FMMainMenu : Form
    {
        public FMMainMenu()
        {
            InitializeComponent();
        }

        private void FMMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void LogAnExpenseBt_Click(object sender, EventArgs e)
        {
            FMLogExpense FMLogExpenseform = new FMLogExpense();
            FMLogExpenseform.ShowDialog();
        }

        private void BudgetingBt_Click(object sender, EventArgs e)
        {
            FMBudgeting FMBudgetingform = new FMBudgeting();
            FMBudgetingform.ShowDialog();
        }

        private void MonthlyExpenseBt_Click(object sender, EventArgs e)
        {

        }

        private void ExitBt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BudgetingBt_Click_1(object sender, EventArgs e)
        {
            FMBudgeting FMBudgetingform = new FMBudgeting();
            FMBudgetingform.ShowDialog();
        }
    }
}