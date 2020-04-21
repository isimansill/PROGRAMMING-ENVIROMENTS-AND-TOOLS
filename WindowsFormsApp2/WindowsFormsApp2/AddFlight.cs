using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//FALTA: IMPLEMENTAR SEATS

namespace WindowsFormsApp2
{
    public partial class AddFlight : Form
    {
        public AddFlight()
        {
            InitializeComponent();
        }
        private Flight SaveScreenFlights()
        {
            Flight flight = new Flight();
            flight.Id = Convert.ToInt32(txtId.Text);
            flight.Name = txtName.Text;
            flight.From = txtFrom.Text;
            flight.To = txtTo.Text;
            flight.Date = dTDate.Value;
            flight.Duration = Convert.ToInt32(txtDuration.Text);
            flight.Price = Convert.ToInt32(txtPrice.Text);
            //flight. = .Text; SEATS
            return flight;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Flight flight = SaveScreenFlights();
            Flight flightRead = Commons.ReadFlight(flight.Id);
            if (flightRead != null)
            {
                MessageBox.Show("The flight with ID : " + flightRead.Id.ToString() + " already exist");
            }
            else
            {
                Commons.SaveOnDiskFlight(flight);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "")
            {
                MessageBox.Show("Flight ID is empty");
            }
            else
            {
                if (Commons.DeleteFlightFromDisk(Convert.ToInt32(txtId.Text)))
                {
                    MessageBox.Show("Flight deleted");
                }
                else
                {
                    MessageBox.Show("Flight ID doesn´t exist");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
           
            List<Flight> flList = new List<Flight>();
            Flight flight = new Flight();
            dataGridView1.Rows.Clear();
            string[] files = Commons.ReadFlightFiles();
            foreach (string f in files)
            {
                flight = Commons.ReadFlight(f);
                flList.Add(flight);
            }

            var names = from p in flList
                        where (p.Name.ToString().Trim() == txtName.Text.Trim() || txtName.Text.Trim() == string.Empty) &&
                        (p.From.ToString().Trim() == txtFrom.Text.Trim() || txtFrom.Text.Trim() == string.Empty) &&
                        (p.To.ToString().Trim() == txtTo.Text.Trim() || txtTo.Text.Trim() == string.Empty) &&
                        (p.Duration.ToString().Trim() == txtDuration.Text.Trim() || txtDuration.Text.Trim() == string.Empty) &&
                        (p.Price.ToString().Trim() == txtPrice.Text.Trim() || txtPrice.Text.Trim() == string.Empty) &&
                        (p.Id.ToString().Trim() == txtId.Text.Trim() || txtId.Text.Trim() == string.Empty)

                        select p;

            foreach (var item in names)
            {
                dataGridView1.Rows.Add(item.Id, item.Name, item.From, item.To, item.Date,
                    item.Duration, item.Price);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
