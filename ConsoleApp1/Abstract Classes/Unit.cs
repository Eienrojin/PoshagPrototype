using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    /// <summary>
    /// Абстрактынй класс описывающий бойцов
    /// </summary>
    internal abstract class Unit : IAction
    {
        public Unit(string name, int health, int maxHealth)
        {
            Name = name;

            if (health > maxHealth)
            {
                Health = maxHealth;
            }

            if (name == "")
            {
                Name = "Враг класса unit";
            }
        }

        /// <summary>
        /// Имя персонажа
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Количество здоровья
        /// </summary>
        public int Health { get; set; }
        /// <summary>
        /// Максимальное кол-во здоровья
        /// </summary>
        public int MaxHealth { get; set; }

        /// <summary>
        /// Инвентарь персонажа
        /// </summary>
        public List<ILoot> Inventory { get; set; }

        public void Destroy() 
        {
            Console.WriteLine("Персонаж погиб!");
        }

        public int GetDamage(int damage)
        {
            Health -= damage;
            return Health;
        }

        public void Cure(int treatment)
        {
            if (Health >= MaxHealth)
            {
                Console.WriteLine("У вас полное здоровье!");
            }
            else
            {
                Health += treatment;
            }
        }

        public override string ToString()
        {
            return $"Юнит - {Name}\nЗдоровье = {Health}\n";
        }
    }
}