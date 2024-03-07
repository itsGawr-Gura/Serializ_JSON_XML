
using System;
using System.Collections.Generic;
using System.IO;

using System.Xml.Serialization;

namespace Practice
{
    internal class Practice
    {
        static void Main(string[] args)
        {
            Flavor colaFlavor = new Flavor { FlavorName = "Cola" };
            Flavor orangeFlavor = new Flavor { FlavorName = "Orange" };
            Flavor bananaFlavor = new Flavor { FlavorName = "Banana" };

            Name cokeName = new Name { Namename = "Coke" };
            Name orangejName = new Name { Namename = "Orange Juice" };
            Name bananamsName = new Name { Namename = "Banana MilkShake" };

            List<Beverage> beverages = new List<Beverage>
        {
            new Soda(cokeName, 1.50m, 10, colaFlavor, 0.75),
            new Juice(orangejName, 2.5m, 5, orangeFlavor, 1.5),
            new MilkShake(bananamsName, 3.00m, 8, bananaFlavor, 1)
        };
            XmlSerializer serializer = new XmlSerializer(typeof(BeverageWrapper));
            using (StreamWriter writer = new StreamWriter("beverages.xml"))
            {
                serializer.Serialize(writer, new BeverageWrapper { Beverages = beverages });
            }

            Console.WriteLine("Objects serialized to XML.");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
