using System.Collections.Generic;
using System.Xml.Serialization;
namespace Practice
{
    public class Flavor
    {
        public string FlavorName { get; set; }
    }

    public class Name
    {
        public string Namename { get; set; }
    }

    public class BeverageWrapper
    {
        public List<Beverage> Beverages { get; set; }
    }
    [XmlInclude(typeof(Soda))]
    [XmlInclude(typeof(Juice))]
    [XmlInclude(typeof(MilkShake))]
    public abstract class Beverage
    {
        protected Name name;
        protected decimal price;
        protected int quantity;
        protected double volume;
        protected Flavor flavor;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public double Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public Beverage() { }

        public Beverage(Name name, decimal price, int quantity, double volume, Flavor flavor)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.volume = volume;
            this.flavor = flavor;
        }


    }

}





