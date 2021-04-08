using System;

namespace Fluid.Benchmarks
{
    public class Product
    {
        public Product(string name, float price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }

        public string Name { get; set; }

        public float Price { get; set; }

        public string Description { get; set; }

        // some extra properties that template isn't using

        public string Color { get; set; }

        public int Width { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
