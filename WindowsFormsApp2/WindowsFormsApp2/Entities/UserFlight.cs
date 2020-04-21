using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Entities
{
    class UserFlight
    {
        private int flightId;
        private string seat;

        public int FlightId { get => flightId; set => flightId = value; }
        public string Seat { get => seat; set => seat = value; }
    }
}
