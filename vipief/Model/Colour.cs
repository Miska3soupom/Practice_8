using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vipief.Model
{
    public class Colour
    {
        public Colour(string name, int kolichstvo, float price)
        {
            Name = name;
            Kolichstvo = kolichstvo;
            Price = price;
        }

        public Colour() { }

        public string Name { get; set; }
        public int Kolichstvo { get; set; }
        public float Price { get; set; }
    }
}
