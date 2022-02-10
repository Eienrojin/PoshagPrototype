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
        public string Name { get; set; }

        protected Weapon(string Name, int Damage, int Durability)
        {
            this.Name = Name;
            this.Damage = Damage;
            this.Durability = Durability;

            if (this.Name == "")
            {
                this.Name = GetWeaponName();
            }
        }

        public void Cure(int treatment)
        {
            throw new System.NotImplementedException();
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