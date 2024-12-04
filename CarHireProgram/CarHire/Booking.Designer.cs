
namespace CarHire
{
    partial class Booking
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbreturning = new System.Windows.Forms.CheckBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.cbCustomerSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.gbAddCustomer = new System.Windows.Forms.GroupBox();
            this.NextcustomerID = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbBookings = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.nbNoOfSeats = new System.Windows.Forms.NumericUpDown();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.gbAddCustomer.SuspendLayout();
            this.gbBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbNoOfSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarHire.Properties.Resources.carsimage;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Classic Car Hire";
            // 
            // chbreturning
            // 
            this.chbreturning.AutoSize = true;
            this.chbreturning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbreturning.Location = new System.Drawing.Point(12, 117);
            this.chbreturning.Name = "chbreturning";
            this.chbreturning.Size = new System.Drawing.Size(180, 24);
            this.chbreturning.TabIndex = 3;
            this.chbreturning.Text = "Returning Customer?";
            this.chbreturning.UseVisualStyleBackColor = true;
            this.chbreturning.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSearch.Location = new System.Drawing.Point(6, 41);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(102, 24);
            this.tbSearch.TabIndex = 4;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btConfirm);
            this.gbSearch.Controls.Add(this.cbCustomerSearch);
            this.gbSearch.Controls.Add(this.label2);
            this.gbSearch.Controls.Add(this.btSearch);
            this.gbSearch.Controls.Add(this.tbSearch);
            this.gbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(431, 2);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(310, 128);
            this.gbSearch.TabIndex = 5;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Enter Postcode:";
            // 
            // btConfirm
            // 
            this.btConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btConfirm.Location = new System.Drawing.Point(195, 78);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(84, 26);
            this.btConfirm.TabIndex = 6;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.UseVisualStyleBackColor = false;
            // 
            // cbCustomerSearch
            // 
            this.cbCustomerSearch.FormattingEnabled = true;
            this.cbCustomerSearch.Location = new System.Drawing.Point(57, 71);
            this.cbCustomerSearch.Name = "cbCustomerSearch";
            this.cbCustomerSearch.Size = new System.Drawing.Size(132, 33);
            this.cbCustomerSearch.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select:";
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSearch.Location = new System.Drawing.Point(111, 41);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(67, 24);
            this.btSearch.TabIndex = 6;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btNext.Location = new System.Drawing.Point(198, 117);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(67, 24);
            this.btNext.TabIndex = 5;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = false;
            // 
            // gbAddCustomer
            // 
            this.gbAddCustomer.Controls.Add(this.NextcustomerID);
            this.gbAddCustomer.Controls.Add(this.button4);
            this.gbAddCustomer.Controls.Add(this.textBox8);
            this.gbAddCustomer.Controls.Add(this.textBox7);
            this.gbAddCustomer.Controls.Add(this.label11);
            this.gbAddCustomer.Controls.Add(this.label10);
            this.gbAddCustomer.Controls.Add(this.label9);
            this.gbAddCustomer.Controls.Add(this.textBox5);
            this.gbAddCustomer.Controls.Add(this.label8);
            this.gbAddCustomer.Controls.Add(this.label7);
            this.gbAddCustomer.Controls.Add(this.textBox4);
            this.gbAddCustomer.Controls.Add(this.label6);
            this.gbAddCustomer.Controls.Add(this.textBox3);
            this.gbAddCustomer.Controls.Add(this.textBox2);
            this.gbAddCustomer.Controls.Add(this.label5);
            this.gbAddCustomer.Controls.Add(this.label4);
            this.gbAddCustomer.Controls.Add(this.label3);
            this.gbAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddCustomer.Location = new System.Drawing.Point(12, 147);
            this.gbAddCustomer.Name = "gbAddCustomer";
            this.gbAddCustomer.Size = new System.Drawing.Size(398, 199);
            this.gbAddCustomer.TabIndex = 6;
            this.gbAddCustomer.TabStop = false;
            this.gbAddCustomer.Text = "Add customer detail:";
            // 
            // NextcustomerID
            // 
            this.NextcustomerID.AutoSize = true;
            this.NextcustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextcustomerID.Location = new System.Drawing.Point(137, 25);
            this.NextcustomerID.Name = "NextcustomerID";
            this.NextcustomerID.Size = new System.Drawing.Size(38, 20);
            this.NextcustomerID.TabIndex = 17;
            this.NextcustomerID.Text = "lbID";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(289, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 30);
            this.button4.TabIndex = 16;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(61, 160);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(73, 20);
            this.textBox8.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(118, 130);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(135, 20);
            this.textBox7.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Phone Number";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(85, 104);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(135, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(134, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "PostCode:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(76, 81);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(255, 47);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 29);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 47);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 29);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Surname:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer Id:";
            // 
            // gbBookings
            // 
            this.gbBookings.Controls.Add(this.button7);
            this.gbBookings.Controls.Add(this.label21);
            this.gbBookings.Controls.Add(this.label20);
            this.gbBookings.Controls.Add(this.button6);
            this.gbBookings.Controls.Add(this.comboBox2);
            this.gbBookings.Controls.Add(this.label19);
            this.gbBookings.Controls.Add(this.button5);
            this.gbBookings.Controls.Add(this.label18);
            this.gbBookings.Controls.Add(this.label17);
            this.gbBookings.Controls.Add(this.dtpEnd);
            this.gbBookings.Controls.Add(this.dtpStart);
            this.gbBookings.Controls.Add(this.label16);
            this.gbBookings.Controls.Add(this.nbNoOfSeats);
            this.gbBookings.Controls.Add(this.radioButton3);
            this.gbBookings.Controls.Add(this.radioButton2);
            this.gbBookings.Controls.Add(this.radioButton1);
            this.gbBookings.Controls.Add(this.label15);
            this.gbBookings.Controls.Add(this.lbID);
            this.gbBookings.Controls.Add(this.label13);
            this.gbBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBookings.Location = new System.Drawing.Point(431, 136);
            this.gbBookings.Name = "gbBookings";
            this.gbBookings.Size = new System.Drawing.Size(357, 285);
            this.gbBookings.TabIndex = 7;
            this.gbBookings.TabStop = false;
            this.gbBookings.Text = "Enter Booking Details:";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(267, 254);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 26);
            this.button7.TabIndex = 35;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(7, 239);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 16);
            this.label21.TabIndex = 34;
            this.label21.Text = "Cost Per Day: £";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(7, 264);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 16);
            this.label20.TabIndex = 33;
            this.label20.Text = "Total Cost: £";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(209, 198);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 26);
            this.button6.TabIndex = 32;
            this.button6.Text = "Check";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(82, 198);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 204);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 16);
            this.label19.TabIndex = 30;
            this.label19.Text = "Select Cars:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(256, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 26);
            this.button5.TabIndex = 29;
            this.button5.Text = "Find Cars";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 16);
            this.label18.TabIndex = 28;
            this.label18.Text = "End Date:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 16);
            this.label17.TabIndex = 27;
            this.label17.Text = "Start Date:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(70, 166);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(180, 26);
            this.dtpEnd.TabIndex = 26;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(73, 136);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(180, 26);
            this.dtpStart.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 16);
            this.label16.TabIndex = 24;
            this.label16.Text = "Number of seats:";
            // 
            // nbNoOfSeats
            // 
            this.nbNoOfSeats.Location = new System.Drawing.Point(133, 100);
            this.nbNoOfSeats.Name = "nbNoOfSeats";
            this.nbNoOfSeats.Size = new System.Drawing.Size(120, 26);
            this.nbNoOfSeats.TabIndex = 23;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(142, 74);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 20);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Electric";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(209, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 20);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Diesel";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(142, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 20);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Petrol";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "Select Engine Type:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(117, 22);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(68, 20);
            this.lbID.TabIndex = 18;
            this.lbID.Text = "lbcustID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Customer Id:";
            // 
            // btReturn
            // 
            this.btReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btReturn.Location = new System.Drawing.Point(676, 422);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(122, 26);
            this.btReturn.TabIndex = 36;
            this.btReturn.Text = "Return To Menu";
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.gbBookings);
            this.Controls.Add(this.gbAddCustomer);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.chbreturning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Booking";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbAddCustomer.ResumeLayout(false);
            this.gbAddCustomer.PerformLayout();
            this.gbBookings.ResumeLayout(false);
            this.gbBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbNoOfSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbreturning;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.ComboBox cbCustomerSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.GroupBox gbAddCustomer;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label NextcustomerID;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbBookings;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nbNoOfSeats;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btReturn;
    }
}