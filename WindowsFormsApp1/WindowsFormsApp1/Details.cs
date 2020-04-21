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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        Image File;

        private Property SaveScreenInEntity()
        {
            Property property = new Property();
            property.Id = Convert.ToInt32(txtId.Text);
            property.Name = txtName.Text;
            property.Price = Convert.ToInt32(textPrice.Text);
            property.Area = textArea.Text;
            property.Address = textAddress.Text;
            property.Year = Convert.ToInt32(textYear.Text);
            property.Rooms = Convert.ToInt32(textRooms.Text);
            //property.Price = Convert.ToInt32(txtPrice); RESERVADO PARA PICTURES
            property.PropertyType = Convert.ToInt32(cbPropertyType.SelectedValue);

            return property;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtId.Text=="" || txtName.Text=="" || textPrice.Text == "" || textArea.Text == "" || 
                textAddress.Text == "" || textYear.Text == "" || textRooms.Text == "")
            {

                MessageBox.Show("Check your inputs please");
            }
            else{ 
                Property property = SaveScreenInEntity();
                Property propertyRead = Commons.ReadFromDisk(property.Id);
                if (propertyRead != null)
                {
                    MessageBox.Show("The property with ID : " + propertyRead.Id.ToString() + " already exist");
                }
                else
                {
                    Commons.SaveOnDiskAsJson(property);
                }

            }


        }

        private void Details_Load(object sender, EventArgs e)
        {
            Dictionary<string,string> comboSource = new Dictionary<string, string>();
            comboSource.Add("1", "Appartment");
            comboSource.Add("2", "House");
            comboSource.Add("3", "Ground");

            cbPropertyType.DataSource = new BindingSource(comboSource, null);
            cbPropertyType.DisplayMember = "Value";
            cbPropertyType.ValueMember = "Key";

            //if (variable != null) alta
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbPropertyType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Property property = new Property();
            property.Id = Convert.ToInt32(txtId.Text);
            if (property.Id.GetType() != Type.GetType("System.Int32"))
            {
                MessageBox.Show("Error: ID type not valid");
            }
            else
            {
                Commons.DeleteFromDisk(property.Id);
                MessageBox.Show("Input Delete");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (txtId.Text == "" || txtName.Text == "" || textPrice.Text == "" || textArea.Text == "" ||
                textAddress.Text == "" || textYear.Text == "" || textRooms.Text == "")
            {
                MessageBox.Show("Check your inputs please");
            }
            else
            {
                Property property = SaveScreenInEntity();
                Property propertyRead = Commons.ReadFromDisk(property.Id);
                if (propertyRead != null)
                {
                    Commons.DeleteFromDisk(property.Id);
                    Commons.SaveOnDiskAsJson(property);
                    MessageBox.Show("Input Changed");
                    
                }
                else
                {
                    Commons.SaveOnDiskAsJson(property);
                }

            }
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if(f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                lblPicture.Text = f.FileName;
                pictureBox.Image = File;

            }
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            Commons.SavePic(File, Convert.ToInt32(txtId.Text));
            pictureBox.Image = null;
            lblPicture.Text = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            var ruta = lblPicture.Text;
            lblPicture.Text = null;
            File.Dispose();
            System.IO.File.Delete(ruta);
        }
    }
}
