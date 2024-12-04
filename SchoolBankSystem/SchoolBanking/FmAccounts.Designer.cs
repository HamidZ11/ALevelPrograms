
namespace SchoolBanking
{
    partial class FmAccounts
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
            this.gbCreate = new System.Windows.Forms.GroupBox();
            this.btsave = new System.Windows.Forms.Button();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbForename = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.txSurname = new System.Windows.Forms.TextBox();
            this.txBalance = new System.Windows.Forms.TextBox();
            this.txForename = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txStudentId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btReturn = new System.Windows.Forms.Button();
            this.gbCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCreate
            // 
            this.gbCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbCreate.Controls.Add(this.btsave);
            this.gbCreate.Controls.Add(this.lbSurname);
            this.gbCreate.Controls.Add(this.lbBalance);
            this.gbCreate.Controls.Add(this.lbClass);
            this.gbCreate.Controls.Add(this.lbForename);
            this.gbCreate.Controls.Add(this.cbClass);
            this.gbCreate.Controls.Add(this.txSurname);
            this.gbCreate.Controls.Add(this.txBalance);
            this.gbCreate.Controls.Add(this.txForename);
            this.gbCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCreate.Location = new System.Drawing.Point(12, 147);
            this.gbCreate.Name = "gbCreate";
            this.gbCreate.Size = new System.Drawing.Size(563, 223);
            this.gbCreate.TabIndex = 0;
            this.gbCreate.TabStop = false;
            this.gbCreate.Text = "Account Details";
            this.gbCreate.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(414, 142);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(133, 75);
            this.btsave.TabIndex = 3;
            this.btsave.Text = "Save";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(310, 36);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(131, 31);
            this.lbSurname.TabIndex = 8;
            this.lbSurname.Text = "Surname:";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(31, 132);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(120, 31);
            this.lbBalance.TabIndex = 7;
            this.lbBalance.Text = "Balance:";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(60, 92);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(91, 31);
            this.lbClass.TabIndex = 6;
            this.lbClass.Text = "Class:";
            // 
            // lbForename
            // 
            this.lbForename.AutoSize = true;
            this.lbForename.Location = new System.Drawing.Point(6, 40);
            this.lbForename.Name = "lbForename";
            this.lbForename.Size = new System.Drawing.Size(145, 31);
            this.lbForename.TabIndex = 5;
            this.lbForename.Text = "Forename:";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(157, 84);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(121, 39);
            this.cbClass.TabIndex = 4;
            // 
            // txSurname
            // 
            this.txSurname.Location = new System.Drawing.Point(447, 33);
            this.txSurname.Name = "txSurname";
            this.txSurname.Size = new System.Drawing.Size(100, 38);
            this.txSurname.TabIndex = 2;
            // 
            // txBalance
            // 
            this.txBalance.Location = new System.Drawing.Point(157, 129);
            this.txBalance.Name = "txBalance";
            this.txBalance.Size = new System.Drawing.Size(100, 38);
            this.txBalance.TabIndex = 1;
            // 
            // txForename
            // 
            this.txForename.Location = new System.Drawing.Point(157, 40);
            this.txForename.Name = "txForename";
            this.txForename.Size = new System.Drawing.Size(100, 38);
            this.txForename.TabIndex = 0;
            this.txForename.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txStudentId
            // 
            this.txStudentId.Location = new System.Drawing.Point(181, 73);
            this.txStudentId.Name = "txStudentId";
            this.txStudentId.Size = new System.Drawing.Size(135, 20);
            this.txStudentId.TabIndex = 0;
            this.txStudentId.TextChanged += new System.EventHandler(this.txStudentId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(200, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 39);
            this.label5.TabIndex = 1;
            this.label5.Text = "Xaverian school bank";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-8, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Enter Student ID:";
            // 
            // btReturn
            // 
            this.btReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturn.Location = new System.Drawing.Point(608, 276);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(115, 71);
            this.btReturn.TabIndex = 9;
            this.btReturn.Text = "Return to Menu";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // FmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txStudentId);
            this.Controls.Add(this.gbCreate);
            this.Name = "FmAccounts";
            this.Text = "FmAccounts";
            this.Load += new System.EventHandler(this.FmAccounts_Load);
            this.gbCreate.ResumeLayout(false);
            this.gbCreate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txStudentId;
        private System.Windows.Forms.TextBox txSurname;
        private System.Windows.Forms.TextBox txBalance;
        private System.Windows.Forms.TextBox txForename;
        private System.Windows.Forms.Label lbForename;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btReturn;
    }
}