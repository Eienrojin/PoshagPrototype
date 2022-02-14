using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class Enemies : Unit
    {
        public Enemies(string name, int health, int maxHealth) : base(name, health, maxHealth)
        {
            if (name == "")
            {
                GetRandomName();
            }
        }

        public Weapon WeaponSlot1 { get; set; }

        public void Destroy(Player player, Enemies enemy)
        {
            Console.WriteLine("Существо погибло!");

            GetEnemyItems(player, enemy);
        }

        private void GetEnemyItems(Player player, Enemies enemy)
        {
            int answer = -1;

            while (true)
            {
                Console.WriteLine("Хотите взять все его вещи?" +
                 $"\n{enemy.WeaponSlot1}" +
                 $"\n1. Да" +
                 $"\n2. Нет");

                try
                {
                    answer = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Warning.ShowWarning(0);
                    Console.Clear();
                }

                if (answer == 1)
                {
                    player.Inventory.Add(WeaponSlot1);

                    break;
                }
                if (answer == 2)
                {
                    break;
                }
                else
                {
                    Warning.ShowWarning(0);
                }
            }
        }

        static string GetRandomName()
        {
            Random random = new Random();

            string[] names = { "Волк", "Лис", "Молодой бандит" };

            string randomName = names[random.Next(0, names.Length)];

            return randomName;
        }
    }
}
