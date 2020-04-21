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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnUsersAdmin_Click(object sender, EventArgs e)
        {
            AddUser ap = new AddUser();
            ap.Show();
        }

        private void btnFlightsAdmin_Click(object sender, EventArgs e)
        {
            AddFlight ap = new AddFlight();
            ap.Show();
        }
    }
}
