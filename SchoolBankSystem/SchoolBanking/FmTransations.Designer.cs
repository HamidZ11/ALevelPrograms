
namespace SchoolBanking
{
    partial class FmTransations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.performanceCounter2 = new System.Diagnostics.PerformanceCounter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbTrans = new System.Windows.Forms.GroupBox();
            this.txID = new System.Windows.Forms.TextBox();
            this.txAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txS = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbselect = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.rbdeposit = new System.Windows.Forms.RadioButton();
            this.rbwithdrawal = new System.Windows.Forms.RadioButton();
            this.btsave = new System.Windows.Forms.Button();
            this.btfind = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbcurrentbalance = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.btreturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbTrans.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btfind);
            this.groupBox1.Controls.Add(this.txID);
            this.groupBox1.Controls.Add(this.txS);
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gbID";
            // 
            // gbTrans
            // 
            this.gbTrans.Controls.Add(this.lbBalance);
            this.gbTrans.Controls.Add(this.lbcurrentbalance);
            this.gbTrans.Controls.Add(this.label6);
            this.gbTrans.Controls.Add(this.btsave);
            this.gbTrans.Controls.Add(this.rbwithdrawal);
            this.gbTrans.Controls.Add(this.rbdeposit);
            this.gbTrans.Controls.Add(this.txAmount);
            this.gbTrans.Controls.Add(this.lbselect);
            this.gbTrans.Controls.Add(this.lbName);
            this.gbTrans.Location = new System.Drawing.Point(12, 225);
            this.gbTrans.Name = "gbTrans";
            this.gbTrans.Size = new System.Drawing.Size(622, 213);
            this.gbTrans.TabIndex = 0;
            this.gbTrans.TabStop = false;
            this.gbTrans.Text = "gbTransactions";
            // 
            // txID
            // 
            this.txID.Location = new System.Drawing.Point(6, 50);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(121, 20);
            this.txID.TabIndex = 1;
            // 
            // txAmount
            // 
            this.txAmount.Location = new System.Drawing.Point(451, 152);
            this.txAmount.Name = "txAmount";
            this.txAmount.Size = new System.Drawing.Size(70, 20);
            this.txAmount.TabIndex = 2;
            this.txAmount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Xaverian School Bank";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txS
            // 
            this.txS.AutoSize = true;
            this.txS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txS.Location = new System.Drawing.Point(6, 23);
            this.txS.Name = "txS";
            this.txS.Size = new System.Drawing.Size(151, 24);
            this.txS.TabIndex = 3;
            this.txS.Text = "Enter Student ID:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(7, 53);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(76, 24);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "lbName";
            // 
            // lbselect
            // 
            this.lbselect.AutoSize = true;
            this.lbselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbselect.Location = new System.Drawing.Point(8, 107);
            this.lbselect.Name = "lbselect";
            this.lbselect.Size = new System.Drawing.Size(251, 25);
            this.lbselect.TabIndex = 5;
            this.lbselect.Text = "Select Transaction Type:";
            this.lbselect.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(584, 110);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(74, 25);
            this.lbDate.TabIndex = 6;
            this.lbDate.Text = "lbDate";
            // 
            // rbdeposit
            // 
            this.rbdeposit.AutoSize = true;
            this.rbdeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdeposit.Location = new System.Drawing.Point(13, 148);
            this.rbdeposit.Name = "rbdeposit";
            this.rbdeposit.Size = new System.Drawing.Size(82, 24);
            this.rbdeposit.TabIndex = 6;
            this.rbdeposit.TabStop = true;
            this.rbdeposit.Text = "Deposit";
            this.rbdeposit.UseVisualStyleBackColor = true;
            this.rbdeposit.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbwithdrawal
            // 
            this.rbwithdrawal.AutoSize = true;
            this.rbwithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbwithdrawal.Location = new System.Drawing.Point(131, 148);
            this.rbwithdrawal.Name = "rbwithdrawal";
            this.rbwithdrawal.Size = new System.Drawing.Size(105, 24);
            this.rbwithdrawal.TabIndex = 7;
            this.rbwithdrawal.TabStop = true;
            this.rbwithdrawal.Text = "Withdrawal";
            this.rbwithdrawal.UseVisualStyleBackColor = true;
            // 
            // btsave
            // 
            this.btsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.Location = new System.Drawing.Point(527, 152);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(75, 33);
            this.btsave.TabIndex = 7;
            this.btsave.Text = "save";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btfind
            // 
            this.btfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfind.Location = new System.Drawing.Point(269, 36);
            this.btfind.Name = "btfind";
            this.btfind.Size = new System.Drawing.Size(89, 44);
            this.btfind.TabIndex = 8;
            this.btfind.Text = "Find";
            this.btfind.UseVisualStyleBackColor = true;
            this.btfind.Click += new System.EventHandler(this.btfind_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Enter amount:";
            // 
            // lbcurrentbalance
            // 
            this.lbcurrentbalance.AutoSize = true;
            this.lbcurrentbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcurrentbalance.Location = new System.Drawing.Point(282, 40);
            this.lbcurrentbalance.Name = "lbcurrentbalance";
            this.lbcurrentbalance.Size = new System.Drawing.Size(173, 25);
            this.lbcurrentbalance.TabIndex = 9;
            this.lbcurrentbalance.Text = "Current Balance:";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.Location = new System.Drawing.Point(461, 41);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(113, 24);
            this.lbBalance.TabIndex = 10;
            this.lbBalance.Text = "£ lb Balance";
            this.lbBalance.Click += new System.EventHandler(this.label3_Click);
            // 
            // btreturn
            // 
            this.btreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreturn.Location = new System.Drawing.Point(675, 355);
            this.btreturn.Name = "btreturn";
            this.btreturn.Size = new System.Drawing.Size(103, 83);
            this.btreturn.TabIndex = 11;
            this.btreturn.Text = "Return to Menu";
            this.btreturn.UseVisualStyleBackColor = true;
            this.btreturn.Click += new System.EventHandler(this.btreturn_Click);
            // 
            // FmTransations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btreturn);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbTrans);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmTransations";
            this.Text = "FmTransations";
            this.Load += new System.EventHandler(this.FmTransations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTrans.ResumeLayout(false);
            this.gbTrans.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Diagnostics.PerformanceCounter performanceCounter2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.GroupBox gbTrans;
        private System.Windows.Forms.TextBox txAmount;
        private System.Windows.Forms.Label txS;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbselect;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.RadioButton rbdeposit;
        private System.Windows.Forms.Button btfind;
        private System.Windows.Forms.RadioButton rbwithdrawal;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbcurrentbalance;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Button btreturn;
    }
}