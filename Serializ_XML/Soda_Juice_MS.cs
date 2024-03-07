namespace Practice
{
    public class Soda : Beverage
    {
        public Soda() { }

        public Soda(Name name, decimal price, int quantity, Flavor flavor, double volume) : base(name, price, quantity, volume, flavor)
        {

        }


    }

    public class Juice : Beverage
    {
        public Juice() { }

        public Juice(Name name, decimal price, int quantity, Flavor flavor, double volume) : base(name, price, quantity, volume, flavor)
        {

        }

    }

    public class MilkShake : Beverage
    {
        public MilkShake() { }

        public MilkShake(Name name, decimal price, int quantity, Flavor flavor, double volume) : base(name, price, quantity, volume, flavor)
        {

        }


    }
}
