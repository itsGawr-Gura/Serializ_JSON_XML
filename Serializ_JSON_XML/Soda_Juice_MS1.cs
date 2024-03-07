using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Flavor
    {
        public string FlavorName { get; set; }
    }

    public class Name
    {
        public string Namename { get; set; }
    }

    public abstract class Beverage
    {
        public Name Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public double Volume { get; set; }
        public Flavor Flavor { get; set; }
    }
}
