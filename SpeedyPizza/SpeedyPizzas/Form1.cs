using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedyPizzas
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }

        public const double MARGHERITAPRICE = 4.00;

        public const double VEGETARIANPRICE = 4.60;

        public const double PEPPERONIPRICE = 4.60;

        public const double MEATFEASTPRICE = 5.00;

        public const double SMALLWEIGHTING = 1.00;

        public const double MEDIUMWEIGHTING = 1.25;

        public const double LARGEWEIGHTING = 1.50;

        public const double FAMILYWEIGHTING = 2.00;

        public static string PizzaType = "";

        public static string PizzaSize = "";

        public static double Weighting, BasicPrice, Total;

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)

        {
            PizzaType = cbType.Text;
            switch (cbType.SelectedIndex)
            {
                case 0:
                    BasicPrice = MARGHERITAPRICE;
                    break;
                //Likewise for the other pizza types
        }

        }

        private void rbSmall_Click(object sender, EventArgs e)
        {
            if (rbSmall.Checked)
            {
                PizzaSize = "Small";
                Weighting = SMALLWEIGHTING;
            }
        }

        private void rbMedium_Click(object sender, EventArgs e)
        {
            if (rbMedium.Checked)
            {
                PizzaSize = "Medium";
                Weighting = MEDIUMWEIGHTING;
            }
        }

        private void rbLarge_Click(object sender, EventArgs e)
        {
            if (rbLarge.Checked)
            {
                PizzaSize = "Large";
                Weighting = LARGEWEIGHTING;
            }
        }

        private void rbFamily_Click(object sender, EventArgs e)

        {
            if (rbFamily.Checked)
            {
                PizzaSize = "Family";
                Weighting = FAMILYWEIGHTING;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btNewOrder_Click(object sender, EventArgs e)
        {
            tbOrder.Clear();
            Total = 0;
        }

        private void btAddOrder_Click(object sender, EventArgs e)
        {
            double price = 0;
            price = BasicPrice * Weighting;
            tbOrder.AppendText(PizzaSize + " " + PizzaType + " £" + price.ToString("0.00") + Environment.NewLine);
            Total = Total + price;
            // & reset selections!! See improvements.
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            tbOrder.AppendText("====================" + Environment.NewLine);
            tbOrder.AppendText(" Total = £ " + Total.ToString("0.00"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
