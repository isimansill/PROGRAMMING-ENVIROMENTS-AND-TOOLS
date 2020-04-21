using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ReserveFlight : Form
    {
        public ReserveFlight()
        {
            InitializeComponent();
        }
        public ReserveFlight(string name, string from, string to)
        {
            InitializeComponent();
            flight.Text = name;
            labelfrom.Text = from;
            labelto.Text = to;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have bought the tickets");
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
