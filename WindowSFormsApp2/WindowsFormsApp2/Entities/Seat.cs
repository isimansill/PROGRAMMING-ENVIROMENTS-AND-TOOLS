using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Seat
    {
        private int id;
        private bool isTaken;

        public int Id { get => id; set => id = value; }
        public bool IsTaken { get => isTaken; set => isTaken = value; }
    }
}
