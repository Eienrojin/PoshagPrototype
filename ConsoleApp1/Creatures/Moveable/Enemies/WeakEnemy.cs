using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class WeakEnemy : Unit
    {
        public WeakEnemy(string name, int health) : base(name, health)
        {
            if (name == "")
            {
                Name = GetRandomName();
            }

            string GetRandomName()
            {
                Random random = new Random();

                string[] names = { "Крыса", "Таракан", "Микропёс" };

                string randomName = names[random.Next(0, names.Length)];

                return randomName;
            }
        }
    }
}
