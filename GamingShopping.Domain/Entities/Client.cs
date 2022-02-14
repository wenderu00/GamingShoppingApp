using GamingShopping.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingShopping.Domain.Entities
{
    public class Client : User
    {
        public Client(Name name, string email) : base(name, email)
        {
            
        }
        
    }
}
