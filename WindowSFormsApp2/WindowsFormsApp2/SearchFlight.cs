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
    public partial class SearchFlight : Form
    {

        public SearchFlight()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Flight> flList = new List<Flight>();
            dataGridMenu.Rows.Clear();
            Flight flight = new Flight();
            string[] files = Commons.ReadFlightFiles();
            foreach (string f in files)
            {
                flight = Commons.ReadFlight(f);
                flList.Add(flight);
            }

            var names = from p in flList
                        where (p.From.Trim().ToUpper().Contains(textFrom.Text.Trim().ToUpper()) || textFrom.Text.Trim() == string.Empty) &&
                        (p.To.ToString().Trim() == textTo.Text.Trim() || textTo.Text.Trim() == string.Empty)
                        select p;
            foreach (var item in names)
            {
                dataGridMenu.Rows.Add(item.Id, item.Name, item.From, item.To, item.Date,
                    item.Duration, item.Price);
            }

        }



        private void dataGridMenu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dg = dataGridMenu.Rows[e.RowIndex];
            string id = dg.Cells["ColumnId"].Value.ToString();
            string name = dg.Cells["ColumnName"].Value.ToString();
            string from = dg.Cells["ColumnFrom"].Value.ToString();
            string to = dg.Cells["ColumnTo"].Value.ToString();
            ReserveFlight reserve = new ReserveFlight(name, from, to);
            reserve.Show();
        }

        private void dataGridMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }  
}
