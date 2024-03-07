using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace Practice1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Flavor colaFlavor = new Flavor { FlavorName = "Cola" };
            Flavor orangeFlavor = new Flavor { FlavorName = "Orange" };
            Flavor bananaFlavor = new Flavor { FlavorName = "Banana" };

            Name cokeName = new Name { Namename = "Coke" };
            Name orangejName = new Name { Namename = "Orange Juice" };
            Name bananamsName = new Name { Namename = "Banana MilkShake" };
            var beverages = new List<Beverage>
        {
            new Soda(cokeName, 1.50m, 10, 0.75, colaFlavor),
            new Juice(orangejName, 2.5m, 5, 1.5, orangeFlavor),
            new MilkShake(bananamsName, 3.00m, 8, 1, bananaFlavor)
        };

            string json = JsonConvert.SerializeObject(beverages, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("beverages.json", json);

            Console.WriteLine("Objects serialized to JSON.");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
