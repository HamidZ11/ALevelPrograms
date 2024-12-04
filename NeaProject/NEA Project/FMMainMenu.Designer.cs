namespace NEA_Project
{
    partial class FMMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LogAnExpenseBt = new System.Windows.Forms.Button();
            this.MonthlyExpenseBt = new System.Windows.Forms.Button();
            this.BudgetingBt = new System.Windows.Forms.Button();
            this.IncomeBt = new System.Windows.Forms.Button();
            this.ExitBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expense Tracker Main Menu";
            // 
            // LogAnExpenseBt
            // 
            this.LogAnExpenseBt.Location = new System.Drawing.Point(12, 81);
            this.LogAnExpenseBt.Name = "LogAnExpenseBt";
            this.LogAnExpenseBt.Size = new System.Drawing.Size(161, 51);
            this.LogAnExpenseBt.TabIndex = 1;
            this.LogAnExpenseBt.Text = "Log An Expense";
            this.LogAnExpenseBt.UseVisualStyleBackColor = true;
            this.LogAnExpenseBt.Click += new System.EventHandler(this.LogAnExpenseBt_Click);
            // 
            // MonthlyExpenseBt
            // 
            this.MonthlyExpenseBt.Location = new System.Drawing.Point(12, 138);
            this.MonthlyExpenseBt.Name = "MonthlyExpenseBt";
            this.MonthlyExpenseBt.Size = new System.Drawing.Size(161, 52);
            this.MonthlyExpenseBt.TabIndex = 2;
            this.MonthlyExpenseBt.Text = "View Monthly Expenses";
            this.MonthlyExpenseBt.UseVisualStyleBackColor = true;
            this.MonthlyExpenseBt.Click += new System.EventHandler(this.MonthlyExpenseBt_Click);
            // 
            // BudgetingBt
            // 
            this.BudgetingBt.Location = new System.Drawing.Point(12, 196);
            this.BudgetingBt.Name = "BudgetingBt";
            this.BudgetingBt.Size = new System.Drawing.Size(161, 52);
            this.BudgetingBt.TabIndex = 3;
            this.BudgetingBt.Text = "Budgeting";
            this.BudgetingBt.UseVisualStyleBackColor = true;
            this.BudgetingBt.Click += new System.EventHandler(this.BudgetingBt_Click_1);
            // 
            // IncomeBt
            // 
            this.IncomeBt.Location = new System.Drawing.Point(12, 254);
            this.IncomeBt.Name = "IncomeBt";
            this.IncomeBt.Size = new System.Drawing.Size(161, 53);
            this.IncomeBt.TabIndex = 4;
            this.IncomeBt.Text = "Income";
            this.IncomeBt.UseVisualStyleBackColor = true;
            // 
            // ExitBt
            // 
            this.ExitBt.Location = new System.Drawing.Point(581, 280);
            this.ExitBt.Name = "ExitBt";
            this.ExitBt.Size = new System.Drawing.Size(92, 53);
            this.ExitBt.TabIndex = 5;
            this.ExitBt.Text = "Exit";
            this.ExitBt.UseVisualStyleBackColor = true;
            this.ExitBt.Click += new System.EventHandler(this.ExitBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(235, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Monthly expense:";
            // 
            // FMMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExitBt);
            this.Controls.Add(this.IncomeBt);
            this.Controls.Add(this.BudgetingBt);
            this.Controls.Add(this.MonthlyExpenseBt);
            this.Controls.Add(this.LogAnExpenseBt);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FMMainMenu";
            this.Text = "FMMainMenu";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FMMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button LogAnExpenseBt;
        private Button MonthlyExpenseBt;
        private Button BudgetingBt;
        private Button IncomeBt;
        private Button ExitBt;
        private Label label2;
    }
}