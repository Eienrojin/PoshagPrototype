using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal abstract class Unmoveable : Unit
    {
        public Unmoveable(string name, int health, int maxHealth) : base(name, health, maxHealth)
        {
            
        }

        public override string ToString()
        {
            return $"{Name}\nОсталось прочности - {Health}\n";
        }
    }
}
