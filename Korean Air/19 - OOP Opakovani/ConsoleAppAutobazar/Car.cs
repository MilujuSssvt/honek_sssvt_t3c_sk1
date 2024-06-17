using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppAutobazar
{
    public class Car
    {
        public Car(string model, string brand, decimal price, bool isAvailable)
        {
            Model = model;
            Brand = brand;
            Price = price;
            IsAvailable = isAvailable;
        }

        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

 
    }
}
