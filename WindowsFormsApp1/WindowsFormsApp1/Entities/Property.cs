using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public enum PropertyTypes
    {
        Appartment = 1,
        House = 2,
        Ground = 3
    }
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public int Year { get; set; }
        public int Rooms { get; set; }

        public List<Picture> Pictures { get; set; }
        public int PropertyType { get; set; }
        public Property()
        {
            Pictures = new List<Picture>();
        }
    }
}
