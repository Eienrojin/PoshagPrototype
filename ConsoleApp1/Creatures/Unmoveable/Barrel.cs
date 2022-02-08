using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class Barrel : Unmoveable
    {
        public Barrel(string name, int health) : base(name, health)
        {
        }

        public void Explode()
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
    }
}
