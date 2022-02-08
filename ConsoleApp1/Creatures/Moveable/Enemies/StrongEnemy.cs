﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class StrongEnemy : Unit
    {
        public StrongEnemy(string name, int health) : base(name, health)
        {
            if (name == "")
            {
                Name = GetRandomName();
            }
        }

        static string GetRandomName()
        {
            Random random = new Random();

            string[] names = { "Медведь", "Разбойник", "Циклоп" };

            string randomName = names[random.Next(0, names.Length)];

            return randomName;
        }
    }
}
