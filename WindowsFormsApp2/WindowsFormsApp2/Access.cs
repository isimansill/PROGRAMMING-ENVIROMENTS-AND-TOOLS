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
    public partial class Access : Form
    {
        public Access()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(tbId.Text != "" && tbPassword.Text != "")
            {
                //Comprobar que el id es correcto FALTA
                User user = new User();
                user = Commons.ReadUser(Convert.ToInt32(tbId.Text));
                if(tbPassword.Text == user.Password)
                {
                    if(user.IsAdmin == true)
                    {
                        AdminPanel ap = new AdminPanel();
                        ap.Show();
                        
                    }
                    else
                    {
                        SearchFlight searchFlight = new SearchFlight();
                        searchFlight.Show();
                    }

                    string[] numUsers = Commons.ReadUserFiles();
                    User usuario = new User();
                    foreach(string nu in numUsers)
                    {
                        usuario = Commons.ReadUser(nu);
                        UserList._users.Add(usuario);
                    }

                }
            }
            else
            {
                MessageBox.Show("Test your inputs");
            }
        }
    }
}
