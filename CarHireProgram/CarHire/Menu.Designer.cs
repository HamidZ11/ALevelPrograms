
namespace CarHire
{
    partial class Menu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btCar = new System.Windows.Forms.Button();
            this.btStatistics = new System.Windows.Forms.Button();
            this.btBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarHire.Properties.Resources.carsimage;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car Hire Service";
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(679, 334);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(82, 57);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btCar
            // 
            this.btCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCar.Location = new System.Drawing.Point(336, 137);
            this.btCar.Name = "btCar";
            this.btCar.Size = new System.Drawing.Size(172, 66);
            this.btCar.TabIndex = 3;
            this.btCar.Text = "Cars";
            this.btCar.UseVisualStyleBackColor = true;
            this.btCar.Click += new System.EventHandler(this.btCar_Click);
            // 
            // btStatistics
            // 
            this.btStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStatistics.Location = new System.Drawing.Point(336, 209);
            this.btStatistics.Name = "btStatistics";
            this.btStatistics.Size = new System.Drawing.Size(172, 67);
            this.btStatistics.TabIndex = 4;
            this.btStatistics.Text = "Statistics";
            this.btStatistics.UseVisualStyleBackColor = true;
            this.btStatistics.Click += new System.EventHandler(this.btStatistics_Click);
            // 
            // btBooking
            // 
            this.btBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBooking.Location = new System.Drawing.Point(336, 282);
            this.btBooking.Name = "btBooking";
            this.btBooking.Size = new System.Drawing.Size(172, 65);
            this.btBooking.TabIndex = 5;
            this.btBooking.Text = "Booking";
            this.btBooking.UseVisualStyleBackColor = true;
            this.btBooking.Click += new System.EventHandler(this.btBooking_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBooking);
            this.Controls.Add(this.btStatistics);
            this.Controls.Add(this.btCar);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btCar;
        private System.Windows.Forms.Button btStatistics;
        private System.Windows.Forms.Button btBooking;
    }
}

