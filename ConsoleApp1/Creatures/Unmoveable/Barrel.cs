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

        public void Explode(Player obj)
        {
            Random random = new Random();

            GetDamage(random.Next(5, 20));

            Console.WriteLine("А бочка была красная! Порох отнял у вас здоровье");
        }

        public void Cure(int treatment)
        {
            throw new NotImplementedException();
        }

        public void GetDamage(int damage)
        {
            Health -= damage;
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }
    }
}
