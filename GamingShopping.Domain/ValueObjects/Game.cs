using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingShopping.Domain.ValueObjects
{
    public class Game : ValueObject
    {
        public Game(string title, string description)
        {
            Code = Guid.NewGuid().ToString().Replace("-","").Substring(0,4);
            Title = title;
            Description = description;
            
            AddNotifications(new Contract<bool>()
                .AreEquals(Code,4,"O codigo é inválido")
                .IsGreaterThan(Title,2,"O titulo é muito curto")
                .IsLowerThan(Title,80,"O titulo é muito longo")
                .IsGreaterThan(Description,10,"A descrição é muito curta")
                .IsLowerThan(Description,500,"A descrição é muito longa"));

        }
        public string Code { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

    }
}
