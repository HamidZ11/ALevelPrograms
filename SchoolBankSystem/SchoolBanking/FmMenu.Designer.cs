
namespace SchoolBanking
{
    partial class FmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtAccounts = new System.Windows.Forms.Button();
            this.BtTrans = new System.Windows.Forms.Button();
            this.BtStats = new System.Windows.Forms.Button();
            this.BtExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xaverian\'s School Bank";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolBanking.Properties.Resources.xav_college;
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtAccounts
            // 
            this.BtAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAccounts.Location = new System.Drawing.Point(221, 75);
            this.BtAccounts.Name = "BtAccounts";
            this.BtAccounts.Size = new System.Drawing.Size(210, 59);
            this.BtAccounts.TabIndex = 2;
            this.BtAccounts.Text = "Accounts";
            this.BtAccounts.UseVisualStyleBackColor = false;
            this.BtAccounts.Click += new System.EventHandler(this.BtAccounts_Click);
            // 
            // BtTrans
            // 
            this.BtTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtTrans.Location = new System.Drawing.Point(221, 140);
            this.BtTrans.Name = "BtTrans";
            this.BtTrans.Size = new System.Drawing.Size(210, 59);
            this.BtTrans.TabIndex = 3;
            this.BtTrans.Text = "Transactions";
            this.BtTrans.UseVisualStyleBackColor = false;
            this.BtTrans.Click += new System.EventHandler(this.BtTrans_Click);
            // 
            // BtStats
            // 
            this.BtStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtStats.Location = new System.Drawing.Point(221, 205);
            this.BtStats.Name = "BtStats";
            this.BtStats.Size = new System.Drawing.Size(210, 59);
            this.BtStats.TabIndex = 4;
            this.BtStats.Text = "Statistics";
            this.BtStats.UseVisualStyleBackColor = false;
            this.BtStats.Click += new System.EventHandler(this.BtStats_Click);
            // 
            // BtExit
            // 
            this.BtExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtExit.Location = new System.Drawing.Point(208, 299);
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(238, 59);
            this.BtExit.TabIndex = 5;
            this.BtExit.Text = "Exit";
            this.BtExit.UseVisualStyleBackColor = false;
            this.BtExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // FmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtExit);
            this.Controls.Add(this.BtStats);
            this.Controls.Add(this.BtTrans);
            this.Controls.Add(this.BtAccounts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FmMenu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtAccounts;
        private System.Windows.Forms.Button BtTrans;
        private System.Windows.Forms.Button BtStats;
        private System.Windows.Forms.Button BtExit;
    }
}

