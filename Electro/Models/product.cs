using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electro.Models
{
    public class Feature
    {
        public int ID;
        public string Title;
        }
        public class product
    {
        public string ProductName;
        public int ProductID;
        public string Color;
        public string brand;
        public double price;
        public string size;
        public List<Feature> Features;

        public product()
        {
            var product1 = new Laptop();
            product1.Features = new List<Feature>()
            {
                new Feature(){ID =1, Title="Dual Ram"},
                new Feature(){ID =1, Title="FHD"}
            };
            var product2 = new Mobile();
            product2.Features = new List<Feature>()
            {
                new Feature(){ID = 2, Title="dual sim"},
                new Feature(){ID =2, Title="dual cam"}

            };
            var product3 = new Camera();
            product3.Features = new List<Feature>()
            {
                new Feature(){ID =3, Title="dual battery"},
                new Feature(){ID =3, Title="professional"},
            };
            var product4 = new Accessories();
            product4.Features = new List<Feature>()
            {
                new Feature(){ID =4, Title="flip cover"},
                new Feature(){ID =4, Title="screen protector"},
                new Feature(){ID =4, Title="headphones"},
                new Feature(){ID =4, Title="camera stand"},
                new Feature(){ID =4, Title="wired mouse"},
                new Feature(){ID =4, Title="wired keyboard"},
                new Feature(){ID =4, Title="wireless speakers"},
                new Feature(){ID =4, Title="mobile battery"},
                new Feature(){ID =4, Title="laptop battery"},
                new Feature(){ID =4, Title="camera battery"},
                new Feature(){ID =4, Title="camera lence"},
            };
        }

    }

}
