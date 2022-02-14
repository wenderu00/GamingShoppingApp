using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingShopping.Domain.ValueObjects
{
    internal class Game : ValueObject
    {
        public Game(string title, string description)
        {
            Code = Guid.NewGuid().ToString().Replace("-","").Substring(0,4);
            Title = title;
            Description = description;

        }
        public string Code { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

    }
}
