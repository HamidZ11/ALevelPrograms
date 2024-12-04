
namespace SchoolBanking
{
    partial class FmStatistics
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
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.gbIdea = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txID = new System.Windows.Forms.TextBox();
            this.rbListAll = new System.Windows.Forms.RadioButton();
            this.rbCurrentWeek = new System.Windows.Forms.RadioButton();
            this.rbTotals = new System.Windows.Forms.RadioButton();
            this.rbParticular = new System.Windows.Forms.RadioButton();
            this.gbSelect.SuspendLayout();
            this.gbIdea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.rbListAll);
            this.gbSelect.Controls.Add(this.rbCurrentWeek);
            this.gbSelect.Controls.Add(this.rbTotals);
            this.gbSelect.Controls.Add(this.rbParticular);
            this.gbSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbSelect.Location = new System.Drawing.Point(12, 39);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(208, 162);
            this.gbSelect.TabIndex = 0;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "Select List";
            // 
            // gbIdea
            // 
            this.gbIdea.Controls.Add(this.txID);
            this.gbIdea.Location = new System.Drawing.Point(453, 72);
            this.gbIdea.Name = "gbIdea";
            this.gbIdea.Size = new System.Drawing.Size(261, 62);
            this.gbIdea.TabIndex = 0;
            this.gbIdea.TabStop = false;
            this.gbIdea.Text = "gbID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xavarian school bank";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txID
            // 
            this.txID.Location = new System.Drawing.Point(155, 36);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(100, 20);
            this.txID.TabIndex = 0;
            // 
            // rbListAll
            // 
            this.rbListAll.AutoSize = true;
            this.rbListAll.Location = new System.Drawing.Point(6, 33);
            this.rbListAll.Name = "rbListAll";
            this.rbListAll.Size = new System.Drawing.Size(140, 24);
            this.rbListAll.TabIndex = 1;
            this.rbListAll.TabStop = true;
            this.rbListAll.Text = "List all accounts";
            this.rbListAll.UseVisualStyleBackColor = true;
            // 
            // rbCurrentWeek
            // 
            this.rbCurrentWeek.AutoSize = true;
            this.rbCurrentWeek.Location = new System.Drawing.Point(6, 56);
            this.rbCurrentWeek.Name = "rbCurrentWeek";
            this.rbCurrentWeek.Size = new System.Drawing.Size(119, 24);
            this.rbCurrentWeek.TabIndex = 2;
            this.rbCurrentWeek.TabStop = true;
            this.rbCurrentWeek.Text = "radioButton2";
            this.rbCurrentWeek.UseVisualStyleBackColor = true;
            // 
            // rbTotals
            // 
            this.rbTotals.AutoSize = true;
            this.rbTotals.Location = new System.Drawing.Point(6, 79);
            this.rbTotals.Name = "rbTotals";
            this.rbTotals.Size = new System.Drawing.Size(119, 24);
            this.rbTotals.TabIndex = 3;
            this.rbTotals.TabStop = true;
            this.rbTotals.Text = "radioButton3";
            this.rbTotals.UseVisualStyleBackColor = true;
            // 
            // rbParticular
            // 
            this.rbParticular.AutoSize = true;
            this.rbParticular.Location = new System.Drawing.Point(6, 102);
            this.rbParticular.Name = "rbParticular";
            this.rbParticular.Size = new System.Drawing.Size(119, 24);
            this.rbParticular.TabIndex = 4;
            this.rbParticular.TabStop = true;
            this.rbParticular.Text = "radioButton4";
            this.rbParticular.UseVisualStyleBackColor = true;
            // 
            // FmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbIdea);
            this.Controls.Add(this.gbSelect);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "FmStatistics";
            this.Text = "FmStatistics";
            this.Load += new System.EventHandler(this.FmStatistics_Load);
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            this.gbIdea.ResumeLayout(false);
            this.gbIdea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.GroupBox gbIdea;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbListAll;
        private System.Windows.Forms.RadioButton rbCurrentWeek;
        private System.Windows.Forms.RadioButton rbTotals;
        private System.Windows.Forms.RadioButton rbParticular;
        private System.Windows.Forms.TextBox txID;
    }
}