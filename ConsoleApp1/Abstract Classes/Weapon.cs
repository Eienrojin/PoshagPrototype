using System;

namespace PoshagPrototype
{
    /// <summary>
    /// Абстрактный класс Оружие
    /// </summary>
    internal abstract class Weapon : IAction
    {
        public int Damage { get; set; }
        public int Durability { get; set; }
        public string Name { get; set; } = "Оружие";

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

        public void GetDamage(int damage)
        {
            throw new System.NotImplementedException();
        }

        public void Destroy()
        {
            throw new System.NotImplementedException();
        }

        static string GetWeaponName()
        {
            Random random = new Random();

            string[] names = { "Железный", "Ржавый", "Кривой", "Острый", "Красивый", "Новый" };

            string name = names[random.Next(0, names.Length)];

            return name;
        }

        public override string ToString()
        {
            return $"{Name}\n Урон - {Damage}\n Состояние - {Durability}\n";
        }
    }
}