using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingShopping.Domain.Entities
{
    internal class Product :Entity
    {
        public string Code { get; private set; }
        public double Price { get; private set; }
        public User Seeler { get; private set; }
       
        
    }
}
