using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Entities;

namespace WindowsFormsApp2
{
    class User
    {
        private int id;
        private string username;
        private string password;
        private string name;
        private string email;
        private string phone;
        private string address;
        private bool isAdmin;
        //public UserFlight Flight;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
    }
}
