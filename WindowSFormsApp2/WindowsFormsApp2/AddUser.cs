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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private User SaveScreenUsers()
        {
            User user = new User();
            user.Id = Convert.ToInt32(txtId.Text);
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            user.Name = txtName.Text;
            user.Email = txtEmail.Text;
            user.Phone = txtPhone.Text;
            user.Address = txtAddress.Text;
            user.IsAdmin = cbIsAdmin.Checked;
            return user;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = SaveScreenUsers();
            
            User userRead = Commons.ReadUser(user.Id);
            if (userRead != null)
            {
                MessageBox.Show("The user with ID : " + userRead.Id.ToString() + " already exist");
            }
            else
            {
                Commons.SaveOnDiskUser(user);
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
          
            List<User> usList = new List<User>();
            dataGridMenu.Rows.Clear();
            User user = new User();
            string[] files = Commons.ReadUserFiles();
            foreach (string f in files)
            {
                user = Commons.ReadUser(f);
                usList.Add(user);
            }

            var names = from p in usList
                        where (p.Username.Trim().ToUpper().Contains(txtUsername.Text.Trim().ToUpper()) || txtUsername.Text.Trim() == string.Empty) &&
                        (p.Name.ToString().Trim() == txtName.Text.Trim() || txtName.Text.Trim() == string.Empty) &&
                        (p.Email.ToString().Trim() == txtEmail.Text.Trim() || txtEmail.Text.Trim() == string.Empty) &&
                        (p.Phone.ToString().Trim() == txtPhone.Text.Trim() || txtPhone.Text.Trim() == string.Empty) &&
                        (p.Id.ToString().Trim() == txtId.Text.Trim() || txtId.Text.Trim() == string.Empty) &&
                        (p.Password.ToString().Trim() == txtPassword.Text.Trim() || txtPassword.Text.Trim() == string.Empty) &&
                        (p.Address.ToString().Trim() == txtAddress.Text.Trim() || txtAddress.Text.Trim() == string.Empty)
                        
                        select p;

            foreach (var item in names)
            {
                dataGridMenu.Rows.Add(item.Id, item.Username, item.Password, item.Name, item.Email, item.Phone, item.Address);
            }

            txtId.Clear();
            txtName.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtUsername.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtFlight.Clear();

        }

        private void dataGridMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridMen_cellcontentdoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dg = dataGridMenu.Rows[e.RowIndex];
            string name = dg.Cells["ColumnName"].Value.ToString();
            string from = dg.Cells["ColumnFrom"].Value.ToString();
            string to = dg.Cells["ColumnTo"].Value.ToString();
            ReserveFlight reserve = new ReserveFlight(name, from, to);
            reserve.Show();
        }

        private void datagrid2click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
