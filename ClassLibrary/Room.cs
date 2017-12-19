using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Room
{
    public class Room
    {
        public string name { get; set; }
        public int Nroom { get; set; }
        public double Smax { get; set; }
        public double Scook { get; set; }
        public double Price { get; set; }
        public Room(string name, int Nroom, double Smax, double Scook, double Price)
        {
            this.name = name;
            this.Nroom = Nroom;
            this.Smax = Smax;
            this.Scook = Scook;
            this.Price = Price;
        }
    }
}
