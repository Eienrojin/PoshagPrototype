using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype 
{
    internal class Sword : Weapon
    {
        public Sword(string Name, int Damage, int Durability) : base(Name, Damage, Durability)
        {
        }
    }
}
