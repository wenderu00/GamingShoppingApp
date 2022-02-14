
using Flunt.Validations;
using GamingShopping.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingShopping.Domain.Entities
{
    public class User : Entity
    {
        public User(Name name, string email)
        {
            Name = name;
            Email = email;
            AddNotifications(new Contract<bool>()
                .IsEmail(Email,"User.Email","O e-mail é inválido"));
        }
        
        public Name Name { get; private set; }
        public string Email { get; private set; }


    }
}
