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

        public void Cure(int treatment)
        {
            throw new NotImplementedException();
        }

        public void GetDamage(int damage)
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Name}\nОсталось прочности - {Health}\n";
        }
    }
}
