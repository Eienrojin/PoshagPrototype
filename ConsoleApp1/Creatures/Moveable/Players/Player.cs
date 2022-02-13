using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class Player : Unit, IAction
    {
        public Player(string name, int health, int maxHealth) : base(name, health, maxHealth)
        {
        }

        public Weapon WeaponSlot1 { get; set; }
        public Chestplate BodySlot { get; set; }
        public Helmet HelmetSlot { get; set; }
        private int CountOfDamage { get; set; }

        public void Destroy(Unit obj)
        {
            if (Health <= 0)
                GameOver.ShowGameOver();

            ShowStatistic(obj);
        }

        //ПОМЕНЯТЬ
        /*Реализовать вывод всего нанесенного игроком урона в течение игры
         а так же характеристики последнего врага*/
        void ShowStatistic(Unit obj)
        {
            Console.WriteLine($"Всего нанесено урона: {CountOfDamage}");

            Console.WriteLine($"Характеристики текущего врага: {obj}");
        }

        public void AskLowHP()
        {
            int answer;

            //Тестовая реализация сообщения о скорой смерти и предложения вылечиться
            if (Health < Health * 0.3)
            {
                Console.WriteLine("Осталось мало здоровья! Хотите принять лекарство?" +
                    "\n1. - Да" +
                    "\n2. - Нет");

                answer = int.Parse(Console.ReadLine());

                if (answer == 1)
                {
                    //Логика лечения
                }
                else if (answer == 2)
                {
                    Console.WriteLine("Чтож, тогда удачи");
                }
                else
                {
                    Warning.ShowWarning(0);
                }

                Console.Clear();
            }
        }

        public int GetDamage(int damage)
        {
            Health -= damage;
            return Health;
        }

        public void ShowInventory(Unit obj)
        {
            Console.WriteLine($"Оружие в правой руке - {WeaponSlot1}. Урон - {WeaponSlot1.Damage}");
            Console.WriteLine($"Броня на теле - {BodySlot}. Прочность - {BodySlot.Durability}");
            Console.WriteLine($"Шлем - {HelmetSlot}. Прочность - {HelmetSlot.Durability}");

            foreach (ILoot items in obj.Inventory)
            {
                Console.WriteLine(items);
            }
        }

        public override string ToString()
        {
            return $"Вы - {Name}\n Здоровье = {Health}\n";
        }
    }
}
