using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice1
{
    public class Soda : Beverage
    {
        public Soda() { }

        public Soda(Name name, decimal price, int quantity, double volume, Flavor flavor)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Volume = volume;
            Flavor = flavor;
        }
    }

    public class Juice : Beverage
    {
        public Juice() { }

        public Juice(Name name, decimal price, int quantity, double volume, Flavor flavor)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Volume = volume;
            Flavor = flavor;
        }
    }

    public class MilkShake : Beverage
    {
        public MilkShake() { }

        public MilkShake(Name name, decimal price, int quantity, double volume, Flavor flavor)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Volume = volume;
            Flavor = flavor;
        }


    }

}
