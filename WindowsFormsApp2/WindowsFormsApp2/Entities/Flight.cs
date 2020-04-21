using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Flight
    {
		private int id;
		private string name;
		private string from;
		private string to;
		private int duration;
		private double price;
		private DateTime date;
		List<Seat> seats = new List<Seat>();


		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public string From { get => from; set => from = value; }
		public string To { get => to; set => to = value; }
		public int Duration { get => duration; set => duration = value; }
		public double Price { get => price; set => price = value; }
		public DateTime Date { get => date; set => date = value; }
	}
}

