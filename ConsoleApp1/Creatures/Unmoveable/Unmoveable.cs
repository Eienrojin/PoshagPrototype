using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class Unmoveable : Unit
    {
        public Unmoveable(string Name, int Health) : base(Name, Health)
        {
        }

        public override string ToString()
        {
            return $"{Name}\nОсталось прочности - {Health}\n";
        }
    }
}
