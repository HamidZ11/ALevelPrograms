using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarHire
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btCar_Click(object sender, EventArgs e)
        {
            Car Carform = new Car();
            Carform.ShowDialog();
        }

        private void btStatistics_Click(object sender, EventArgs e)
        {
            Statistics Statsform = new Statistics();
            Statsform.ShowDialog();
        }

        private void btBooking_Click(object sender, EventArgs e)
        {
            Booking Bookingform = new Booking();
            Bookingform.ShowDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {

        }
    }
}
