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
        /// <summary>
        /// Имя персонажа
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Количество здоровья
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// Инвентарь персонажа
        /// </summary>
        public List<ILoot> Inventory { get; set; }

        public Unit(string name, int health)
        {
            Name = name;
            Health = health;

            if (name == "")
            {
                Name = "Враг класса unit";
            }
        }

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
            Health += treatment;
        }

        public override string ToString()
        {
            return $"Юнит - {Name}\nЗдоровье = {Health}\n";
        }
    }
}