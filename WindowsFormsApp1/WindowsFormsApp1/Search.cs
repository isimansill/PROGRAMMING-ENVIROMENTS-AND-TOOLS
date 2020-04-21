using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public partial class Search : Form
    {

        
        public Search()
        {
            InitializeComponent();
        }

       

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<Property> propList = new List<Property>();
            
            string rutaDirectorio = "C:\\Test\\Data\\";

            DirectoryInfo di = new DirectoryInfo(@rutaDirectorio);
            lvArchivos.Items.Clear();
            foreach(var item in di.GetFiles())
            {
                string res = rutaDirectorio + item.Name;
                Property propertyRead = Commons.ReadFromDiskFilePath(res);
                propList.Add(propertyRead);
            }

            var names = from p in propList
                        where (p.Name.Trim().ToUpper().Contains(textName.Text.Trim().ToUpper()) || textName.Text.Trim() == string.Empty) &&
                        (p.Year.ToString().Trim() == textYear.Text.Trim() || textYear.Text.Trim() == string.Empty) &&
                            (p.Price.ToString().Trim() == textPrice.Text.Trim() ||  textPrice.Text.Trim() == string.Empty)
                        select p;


            foreach (var item in names)
            {
                string salida = "Name: " + item.Name + ", Id: " + item.Id + 
                    ", Price: " + item.Price + ", Area: " + item.Area + 
                    ", Address: " + item.Address + ", Year: " + item.Year + 
                    ", Rooms: " + item.Rooms + ", PropertyType: " + item.PropertyType; 
                lvArchivos.Items.Add(salida);
            }


        }

        private void lvArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void itemDoubleClick(object sender, EventArgs e)
        {
            /*DataGridViewRow dg = dataGridMenu.Rows[e.RowIndex];
            string id = dg.Cells["ColumnId"].Value.ToString();
            ReserveFlight reserve = new ReserveFlight(id);
            reserve.Show();*/
            Details d = new Details();
            d.Show();
        }
    }
}
