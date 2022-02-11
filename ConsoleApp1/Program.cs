//Реализовано:
//Классы врагов

//Сделать
//Боёвку
//Инвентарь
//Использование предметов
//Проверку ответов пользователя

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu.ShowMenu();

            Player player = new Player("Тестовый игрок", 500, 500);

            GetStartInventory(player);
            player.ShowInventory(player);

            Console.ReadKey();
        }

        static void Fight()
        {
            int countOfEnemies = 5;
            Unit[] enemies = new Unit[countOfEnemies];

            FillUnitArray(enemies, countOfEnemies, 0);

            while (countOfEnemies != 0)
            { 
                Console.WriteLine("Сделайте выбор\n" +
                    "1. Ударить\n" +
                    "2. Принять лекарство\n" +
                    "3. ТЕСТ Вывести все обьекты\n" +
                    "4. Выйти из игры"); //прописать нормальный текст

                int answer = int.Parse(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        enemies[0].GetDamage(15);
                        break;
                    case 2:
                        //Прописать логику принятия лекарства
                        break;
                    case 3:
                        TestPrintAllObjects();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static void GetStartInventory(Player obj)
        {
            Sword startSword = new Sword("Меч", "Деревянный", 7, 8, 8);
            Sword startSword2 = new Sword("Меч", "Деревянный", 5, 10, 10);
            Chestplate startChestplate = new Chestplate("Балахон", 10, 14, false);
            Helmet startHelmet = new Helmet("Повязка на голову", 4, 5);
            Hammer startHammer = new Hammer("Рабочий молоток", 10, 20, 25);

            obj.Inventory = new List<ILoot>();

            obj.WeaponSlot1 = startSword;
            obj.WeaponSlot2 = startSword2;
            obj.BodySlot = startChestplate;
            obj.HelmetSlot = startHelmet;
            obj.Inventory.Add(startHammer);

            /*Sword sword4 = (Sword)player.Inventory[0].UseItem();*/

            obj.ShowInventory(obj);
        }

        /// <summary>
        /// Метод заполняющий массив с врагами. На выбор дается 3 типа врагов.
        /// </summary>
        /// <param name="typeOfEnemy">Тип врагов:
        /// <br> 0 - слабые </br>
        /// <br> 1 - средние </br>
        /// <br> 2 - сильные </br></param>
        static void FillUnitArray(Unit[] arr, int count, int typeOfEnemy)
        {
            SystemException systemException = new SystemException("Нет такого типа врагов");

            switch (typeOfEnemy)
            {
                case 0:
                    for (int i = 0; i < count; i++)
                    {
                        arr[i] = new WeakEnemy("", 25, 25);
                    }
                    break;
                case 1:
                    for (int i = 0; i < count; i++)
                    {
                        arr[i] = new MediumEnemy("", 50, 50);
                    }
                    break;
                case 2:
                    for (int i = 0; i < count; i++)
                    {
                        arr[i] = new StrongEnemy("", 100, 100);
                    }
                    break;
                default:
                    Console.WriteLine(systemException);
                    break;
            }
        }

        static void TestPrintAllObjects()
        {
            Random random = new Random();

            Unit[] weakEnemy = new WeakEnemy[3];
            Unit[] mediumEnemy = new MediumEnemy[3];
            Unit[] strongEnemy = new StrongEnemy[3];
            Player[] players = new Player[2];

            FillUnitArray(weakEnemy, 3, 0);
            FillUnitArray(mediumEnemy, 3, 1);
            FillUnitArray(strongEnemy, 3, 2);

            for(int i = 0; i < weakEnemy.Length;i++)
            {
                Console.WriteLine(weakEnemy + "\n");
            }
            for (int i = 0; i < mediumEnemy.Length; i++)
            {
                Console.WriteLine(mediumEnemy.ToString() + "\n");
            }
            for (int i = 0; i < strongEnemy.Length; i++)
            {
                Console.WriteLine(strongEnemy + "\n");
            }

            Barrel barrel = new Barrel("Бочка", 32, 34);
            Chest chest = new Chest("Сундук", 21, 25);
            Crate crate = new Crate("Ящик", 21, 25);

            Chestplate chestplate = new Chestplate("Железная кираса", 20, 500, true);
            Helmet helmet = new Helmet("Железный шлем", 4,30);

            Hammer hammer = new Hammer("Молот", 3, 5, 10);
            Sword sword = new Sword("Меч", "Железный", 5, 50, 150);

            Console.WriteLine(barrel);
            Console.WriteLine(chest);
            Console.WriteLine(crate);

            Console.WriteLine(chestplate);
            Console.WriteLine(helmet);

            Console.WriteLine(hammer);
            Console.WriteLine(sword);

            Console.ReadKey();
        }
    }
}
