using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class PlayerOrk : Player, IAction
    {
        public PlayerOrk(string name, int health, int maxHealth) : base(name, health, maxHealth)
        {
            if (name == "")
            {
                Name = GetName();
            }
        }

        int GetFistDamage()
        {
            Random random = new Random();

            return random.Next(1, 14);
        }

        private string GetName()
        {
            Random random = new Random();

            string[] names = { "Вархаммер", "Олег", "Кто-То-У-Стены-Стоит", "Грозный", "Шрам", "Неизвестный" };

            string name = names[random.Next(0, names.Length)];

            return name;
        }

        public override string ToString()
        {
            return $"Вы орк - {Name}\n Здоровье = {Health}\n";
        }
    }
}
