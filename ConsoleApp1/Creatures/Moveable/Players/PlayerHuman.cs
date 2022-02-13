using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class PlayerHuman : Player, IAction
    {
        public PlayerHuman(string name, int health, int maxHealth) : base(name, health, maxHealth)
        {
            if (name == "")
            {
                Name = GetName();
            }
        }

        public Weapon WeaponSlot2 { get; set; }

        public new void ShowInventory(Unit obj)
        {
            Console.WriteLine($"Оружие в правой руке - {WeaponSlot1}. Урон - {WeaponSlot1.Damage}");
            Console.WriteLine($"Оружие в левой руке - {WeaponSlot2}. Урон - {WeaponSlot2.Damage}");
            Console.WriteLine($"Броня на теле - {BodySlot}. Прочность - {BodySlot.Durability}");
            Console.WriteLine($"Шлем - {HelmetSlot}. Прочность - {HelmetSlot.Durability}");

            foreach (ILoot items in obj.Inventory)
            {
                Console.WriteLine(items);
            }
        }

        string GetName()
        {
            Random random = new Random();

            string[] names = { "Игорь", "Васян", "Вано", "Кирилл", "Шрам", "Неизвестный" };

            string name = names[random.Next(0, names.Length)];

            return name;
        }

        public override string ToString()
        {
            return $"Вы человек - {Name}\n Здоровье = {Health}\n";
        } 
    }
}
