
namespace CarHire
{
    partial class Car
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
            this.gbCarHire = new System.Windows.Forms.GroupBox();
            this.nbNoOfSeats = new System.Windows.Forms.NumericUpDown();
            this.tbCostPerDay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbElectric = new System.Windows.Forms.RadioButton();
            this.rbDiesel = new System.Windows.Forms.RadioButton();
            this.rbPetrol = new System.Windows.Forms.RadioButton();
            this.tbCarModel = new System.Windows.Forms.TextBox();
            this.tbCarMake = new System.Windows.Forms.TextBox();
            this.tbRegNumber = new System.Windows.Forms.TextBox();
            this.NoOfSeatsLabel = new System.Windows.Forms.Label();
            this.EngineLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.MakeLabel = new System.Windows.Forms.Label();
            this.RegLabel = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.gbCarHire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbNoOfSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Hire Service";
            // 
            // gbCarHire
            // 
            this.gbCarHire.Controls.Add(this.nbNoOfSeats);
            this.gbCarHire.Controls.Add(this.tbCostPerDay);
            this.gbCarHire.Controls.Add(this.label2);
            this.gbCarHire.Controls.Add(this.rbElectric);
            this.gbCarHire.Controls.Add(this.rbDiesel);
            this.gbCarHire.Controls.Add(this.rbPetrol);
            this.gbCarHire.Controls.Add(this.tbCarModel);
            this.gbCarHire.Controls.Add(this.tbCarMake);
            this.gbCarHire.Controls.Add(this.tbRegNumber);
            this.gbCarHire.Controls.Add(this.NoOfSeatsLabel);
            this.gbCarHire.Controls.Add(this.EngineLabel);
            this.gbCarHire.Controls.Add(this.ModelLabel);
            this.gbCarHire.Controls.Add(this.MakeLabel);
            this.gbCarHire.Controls.Add(this.RegLabel);
            this.gbCarHire.Controls.Add(this.btSave);
            this.gbCarHire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCarHire.Location = new System.Drawing.Point(23, 111);
            this.gbCarHire.Name = "gbCarHire";
            this.gbCarHire.Size = new System.Drawing.Size(454, 327);
            this.gbCarHire.TabIndex = 1;
            this.gbCarHire.TabStop = false;
            this.gbCarHire.Text = "Enter Car Details";
            // 
            // nbNoOfSeats
            // 
            this.nbNoOfSeats.Location = new System.Drawing.Point(147, 190);
            this.nbNoOfSeats.Name = "nbNoOfSeats";
            this.nbNoOfSeats.Size = new System.Drawing.Size(120, 24);
            this.nbNoOfSeats.TabIndex = 15;
            // 
            // tbCostPerDay
            // 
            this.tbCostPerDay.Location = new System.Drawing.Point(114, 220);
            this.tbCostPerDay.Name = "tbCostPerDay";
            this.tbCostPerDay.Size = new System.Drawing.Size(100, 24);
            this.tbCostPerDay.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cost per day:";
            // 
            // rbElectric
            // 
            this.rbElectric.AutoSize = true;
            this.rbElectric.Location = new System.Drawing.Point(295, 154);
            this.rbElectric.Name = "rbElectric";
            this.rbElectric.Size = new System.Drawing.Size(75, 22);
            this.rbElectric.TabIndex = 11;
            this.rbElectric.TabStop = true;
            this.rbElectric.Text = "Electric";
            this.rbElectric.UseVisualStyleBackColor = true;
            this.rbElectric.CheckedChanged += new System.EventHandler(this.rbElectric_Click);
            // 
            // rbDiesel
            // 
            this.rbDiesel.AutoSize = true;
            this.rbDiesel.Location = new System.Drawing.Point(229, 154);
            this.rbDiesel.Name = "rbDiesel";
            this.rbDiesel.Size = new System.Drawing.Size(67, 22);
            this.rbDiesel.TabIndex = 10;
            this.rbDiesel.TabStop = true;
            this.rbDiesel.Text = "Diesel";
            this.rbDiesel.UseVisualStyleBackColor = true;
            this.rbDiesel.CheckedChanged += new System.EventHandler(this.rbDiesel_Click);
            // 
            // rbPetrol
            // 
            this.rbPetrol.AutoSize = true;
            this.rbPetrol.Location = new System.Drawing.Point(158, 154);
            this.rbPetrol.Name = "rbPetrol";
            this.rbPetrol.Size = new System.Drawing.Size(65, 22);
            this.rbPetrol.TabIndex = 9;
            this.rbPetrol.TabStop = true;
            this.rbPetrol.Text = "Petrol";
            this.rbPetrol.UseVisualStyleBackColor = true;
            this.rbPetrol.CheckedChanged += new System.EventHandler(this.rbPetrol_Click);
            // 
            // tbCarModel
            // 
            this.tbCarModel.Location = new System.Drawing.Point(114, 120);
            this.tbCarModel.Name = "tbCarModel";
            this.tbCarModel.Size = new System.Drawing.Size(100, 24);
            this.tbCarModel.TabIndex = 8;
            // 
            // tbCarMake
            // 
            this.tbCarMake.Location = new System.Drawing.Point(114, 87);
            this.tbCarMake.Name = "tbCarMake";
            this.tbCarMake.Size = new System.Drawing.Size(100, 24);
            this.tbCarMake.TabIndex = 7;
            // 
            // tbRegNumber
            // 
            this.tbRegNumber.Location = new System.Drawing.Point(207, 54);
            this.tbRegNumber.Name = "tbRegNumber";
            this.tbRegNumber.Size = new System.Drawing.Size(100, 24);
            this.tbRegNumber.TabIndex = 6;
            // 
            // NoOfSeatsLabel
            // 
            this.NoOfSeatsLabel.AutoSize = true;
            this.NoOfSeatsLabel.Location = new System.Drawing.Point(18, 192);
            this.NoOfSeatsLabel.Name = "NoOfSeatsLabel";
            this.NoOfSeatsLabel.Size = new System.Drawing.Size(123, 18);
            this.NoOfSeatsLabel.TabIndex = 5;
            this.NoOfSeatsLabel.Text = "Number Of Seats";
            // 
            // EngineLabel
            // 
            this.EngineLabel.AutoSize = true;
            this.EngineLabel.Location = new System.Drawing.Point(18, 156);
            this.EngineLabel.Name = "EngineLabel";
            this.EngineLabel.Size = new System.Drawing.Size(134, 18);
            this.EngineLabel.TabIndex = 4;
            this.EngineLabel.Text = "Select Engine Type";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(18, 126);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(97, 18);
            this.ModelLabel.TabIndex = 3;
            this.ModelLabel.Text = "Model Of Car";
            // 
            // MakeLabel
            // 
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Location = new System.Drawing.Point(18, 93);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(90, 18);
            this.MakeLabel.TabIndex = 2;
            this.MakeLabel.Text = "Make of Car";
            // 
            // RegLabel
            // 
            this.RegLabel.AutoSize = true;
            this.RegLabel.Location = new System.Drawing.Point(18, 57);
            this.RegLabel.Name = "RegLabel";
            this.RegLabel.Size = new System.Drawing.Size(183, 18);
            this.RegLabel.TabIndex = 1;
            this.RegLabel.Text = "Enter Registration Number";
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(359, 281);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 40);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(713, 400);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 38);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.gbCarHire);
            this.Controls.Add(this.label1);
            this.Name = "Car";
            this.Text = "Form2";
            this.gbCarHire.ResumeLayout(false);
            this.gbCarHire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbNoOfSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCarHire;
        private System.Windows.Forms.Label EngineLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label MakeLabel;
        private System.Windows.Forms.Label RegLabel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label NoOfSeatsLabel;
        private System.Windows.Forms.TextBox tbCostPerDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbElectric;
        private System.Windows.Forms.RadioButton rbDiesel;
        private System.Windows.Forms.RadioButton rbPetrol;
        private System.Windows.Forms.TextBox tbCarModel;
        private System.Windows.Forms.TextBox tbCarMake;
        private System.Windows.Forms.TextBox tbRegNumber;
        private System.Windows.Forms.NumericUpDown nbNoOfSeats;
    }
}