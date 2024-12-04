
namespace SpeedyPizzas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFamily = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.btAddtoorder = new System.Windows.Forms.Button();
            this.btTotal = new System.Windows.Forms.Button();
            this.btNeworder = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.tbOrder = new System.Windows.Forms.TextBox();
            this.labelOrder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Speedy Pizzas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Margherita",
            "Vegetarian",
            "Pepperoni ",
            "Meat Feast"});
            this.cbType.Location = new System.Drawing.Point(141, 84);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(154, 28);
            this.cbType.TabIndex = 2;
            this.cbType.Text = "Select Pizza Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFamily);
            this.groupBox1.Controls.Add(this.rbLarge);
            this.groupBox1.Controls.Add(this.rbMedium);
            this.groupBox1.Controls.Add(this.rbSmall);
            this.groupBox1.Location = new System.Drawing.Point(320, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 175);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Pizza Type";
            // 
            // rbFamily
            // 
            this.rbFamily.AutoSize = true;
            this.rbFamily.Location = new System.Drawing.Point(0, 130);
            this.rbFamily.Name = "rbFamily";
            this.rbFamily.Size = new System.Drawing.Size(60, 19);
            this.rbFamily.TabIndex = 7;
            this.rbFamily.TabStop = true;
            this.rbFamily.Text = "Family";
            this.rbFamily.UseVisualStyleBackColor = true;
            this.rbFamily.CheckedChanged += new System.EventHandler(this.rbFamily_Click);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(0, 94);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(54, 19);
            this.rbLarge.TabIndex = 6;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_Click);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(0, 60);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(70, 19);
            this.rbMedium.TabIndex = 5;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_Click);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(0, 22);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(54, 19);
            this.rbSmall.TabIndex = 4;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_Click);
            // 
            // btAddtoorder
            // 
            this.btAddtoorder.Location = new System.Drawing.Point(395, 263);
            this.btAddtoorder.Name = "btAddtoorder";
            this.btAddtoorder.Size = new System.Drawing.Size(100, 23);
            this.btAddtoorder.TabIndex = 8;
            this.btAddtoorder.Text = "Add to Order";
            this.btAddtoorder.UseVisualStyleBackColor = true;
            // 
            // btTotal
            // 
            this.btTotal.Location = new System.Drawing.Point(395, 302);
            this.btTotal.Name = "btTotal";
            this.btTotal.Size = new System.Drawing.Size(100, 23);
            this.btTotal.TabIndex = 9;
            this.btTotal.Text = "Total";
            this.btTotal.UseVisualStyleBackColor = true;
            this.btTotal.Click += new System.EventHandler(this.btTotal_Click);
            // 
            // btNeworder
            // 
            this.btNeworder.Location = new System.Drawing.Point(395, 340);
            this.btNeworder.Name = "btNeworder";
            this.btNeworder.Size = new System.Drawing.Size(100, 23);
            this.btNeworder.TabIndex = 10;
            this.btNeworder.Text = "New Order";
            this.btNeworder.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(588, 340);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 23);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbOrder
            // 
            this.tbOrder.Location = new System.Drawing.Point(574, 89);
            this.tbOrder.Multiline = true;
            this.tbOrder.Name = "tbOrder";
            this.tbOrder.ReadOnly = true;
            this.tbOrder.Size = new System.Drawing.Size(214, 236);
            this.tbOrder.TabIndex = 12;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(574, 71);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(37, 15);
            this.labelOrder.TabIndex = 13;
            this.labelOrder.Text = "Order";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.tbOrder);
            this.Controls.Add(this.btAddtoorder);
            this.Controls.Add(this.btTotal);
            this.Controls.Add(this.btNeworder);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFamily;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Button btAddtoorder;
        private System.Windows.Forms.Button btTotal;
        private System.Windows.Forms.Button btNeworder;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbOrder;
        private System.Windows.Forms.Label labelOrder;
    }
}
