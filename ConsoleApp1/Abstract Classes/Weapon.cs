using System;
using System.Collections.Generic;

namespace PoshagPrototype
{
    /// <summary>
    /// Абстрактный класс Оружие
    /// </summary>
    internal abstract class Weapon : Loot, IAction
    {
        public int Damage { get; set; }
        public int Durability { get; set; }
        public int MaxDurability { get; set; }
        public string Name { get; set; }

        protected Weapon(string name, int damage, int durability, int maxDurability)
        {
            Damage = damage;
            Durability = durability;
            MaxDurability = maxDurability;

            if(Durability > MaxDurability)
            {
                Durability = MaxDurability;
            }

            if (Name == "")
            {
                Name = GetWeaponName();
            }
            else
            {
                Name = name;
            }
        }

        public void Cure(int treatment)
        {
            Durability += treatment;

            if(Durability > MaxDurability)
            {
                Durability = MaxDurability;

                Console.WriteLine("Оружие как новое!");
            }

            Console.WriteLine("Вы заточили оружие");
        }

        public int GetDamage(int damage)
        {
            Durability -= damage;
            return Durability;
        }

        public void Destroy()
        {
            throw new System.NotImplementedException();
        }

        static string GetWeaponName()
        {
            Random random = new Random();

            string[] names = { "Заточка", "Ржавый гвоздь", "Кривой меч", "Острый кактус", "Красивый болт", "Новый дрын" };

            string name = names[random.Next(0, names.Length)];

            return name;
        }

        public override string ToString()
        {
            return $"{Name}\n Урон - {Damage}\n Состояние - {Durability}\n";
        }
    }
}