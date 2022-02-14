using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingShopping.Domain.Entities
{
    public class Product :Entity
    {
        public Product(double price, User seeler)
        {
            Price = price;
            Seeler = seeler;
        }
        public double Price { get; private set; }
        public User Seeler { get; private set; }
       
        
    }
}
