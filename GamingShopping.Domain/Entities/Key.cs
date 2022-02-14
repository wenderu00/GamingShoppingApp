using GamingShopping.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingShopping.Domain.Entities
{
    internal class Key : Product
    {
        public Game Game { get; private set; }
    }
}
