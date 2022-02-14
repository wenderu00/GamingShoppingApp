using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingShopping.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string givenName,string familyName)
        {
            GivenName = givenName;
            FamilyName = familyName;
            AddNotifications(new Contract<bool>()
                .IsGreaterThan(GivenName, 2,"Name.GivenName","O primeiro nome é muito curto.")
                .IsLowerThan(GivenName, 40, "Name.GivenName","O primeiro nome é muito longo.")
                .IsGreaterThan(GivenName, 2, "Name.FamilyName", "O sobrenome é muito curto."));
        }
        public string GivenName { get; private set; }
        public string FamilyName { get; private set; }

        public override string ToString()
        {
            return GivenName+" "+FamilyName;
        }
    }
}
