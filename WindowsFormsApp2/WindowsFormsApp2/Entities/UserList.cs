using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    static class  UserList
    {
        public static List<User> _users = new List<User>();

       
        public static int numUsers()
        {
            int num_us = _users.Count();
            return num_us;
        }

    }
    
}
