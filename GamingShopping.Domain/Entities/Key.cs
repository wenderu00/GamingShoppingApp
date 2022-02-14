using GamingShopping.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingShopping.Domain.Entities
{
    public class Key : Product
    {
        public Key(Game game,double price,User seeler): base(price, seeler)
        {
            KeyCode = game.Code + Id.ToString().Replace("-", "");
        }
        public string KeyCode { get; private set; }
    }
}
