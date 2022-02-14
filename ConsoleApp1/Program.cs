//Реализовано:
//Бой одного игрока с врагом определенного типа
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class Program
    {
        static int countOfDamage = 0;

        static void Main(string[] args)
        {
            int choicePlayer;

            MainMenu.ShowMenu();
            choicePlayer = MainMenu.ChoicePlayer();

            Console.WriteLine("Выбора нет, автор не смог прописать");

            PlayerHuman player = new PlayerHuman("", 30, 30);
            GetStartInventory(player);

            Fight(player);
        }

        static void GetStartInventory(PlayerOrk obj)
        {
            Chestplate startChestplate = new Chestplate("Балахон", 10, 14, false);
            Helmet startHelmet = new Helmet("Повязка на голову", 4, 5);
            Hammer startHammer = new Hammer("Рабочий молоток", 10, 20, 25);

            obj.Inventory = new List<Loot>();

            obj.WeaponSlot1 = startHammer;
            obj.BodySlot = startChestplate;
            obj.HelmetSlot = startHelmet;
        }

        /// <summary>
        /// Выдает начальное снаряжение выбранному игроку
        /// </summary>
        static void GetStartInventory(PlayerHuman obj)
        {
            Sword startSword = new Sword("Меч", "Стальной", 7, 25, 30);
            Sword startSword2 = new Sword("Меч", "Старый ржавый", 5, 10, 10);
            Chestplate startChestplate = new Chestplate("Балахон", 10, 14, false);
            Helmet startHelmet = new Helmet("Повязка на голову", 4, 5);

            obj.Inventory = new List<Loot>();

            obj.WeaponSlot1 = startSword;
            obj.WeaponSlot2 = startSword2;
            obj.BodySlot = startChestplate;
            obj.HelmetSlot = startHelmet;
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
            Random random = new Random();

            SystemException systemException = new SystemException("Нет такого типа врагов");

            switch (typeOfEnemy)
            {
                case 0:
                    for (int i = 0; i < count; i++)
                    {
                        arr[i] = new WeakEnemy("", 25, 25);
                        arr[i].Inventory = new List<Loot>();

                        //Добавление молота в инвентарь, меча в первый слот
                        (arr[i] as Enemies).WeaponSlot1 = new Sword("Меч", "Железный", random.Next(6, 15), random.Next(20, 30), 30);

                    }
                    break;
                case 1:
                    for (int i = 0; i < count; i++)
                    {
                        arr[i] = new MediumEnemy("", 50, 50);

                        //Добавление меча в первый слот
                        (arr[i] as Enemies).WeaponSlot1 = new Sword("Меч", "", random.Next(6, 15), random.Next(20, 30), 30);
                    }
                    break;
                case 2:
                    for (int i = 0; i < count; i++)
                    {
                        arr[i] = new StrongEnemy("", 100, 100);

                        //Добавление молота в первый слот
                        (arr[i] as Enemies).WeaponSlot1 = new Hammer("Меч", random.Next(12, 20), random.Next(20, 30), 30); ;
                    }
                    break;
                default:
                    Console.WriteLine(systemException);
                    break;
            }
        }

        //Метод, в котором описывается процесс битвы
        static void Fight(PlayerHuman player)
        {
            int countOfEnemies = 5;
            int numOfEnemy = countOfEnemies - 1;

            Unit[] enemies = new Unit[countOfEnemies];
            Random random = new Random();

            //Заполнение массива врагами рандомного типа
            FillUnitArray(enemies, countOfEnemies, random.Next(0, 2));

            while (numOfEnemy != -1)
            {
                int answer = -1;

                Console.WriteLine(player);
                Console.WriteLine(enemies[numOfEnemy]);
                Console.WriteLine("Сделайте выбор\n" +
                    "1. Ударить\n" +
                    "2. Открыть инвентарь\n" +
                    "3. ТЕСТ Вывести все обьекты\n" +
                    "4. Выйти из игры");

                try
                {
                    answer = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Warning.ShowWarning(0);
                    Console.Clear();
                }

                switch (answer)
                {
                    case 1:
                        if (player.WeaponSlot1.Durability > 0)
                        {
                            countOfDamage += player.WeaponSlot1.Damage;
                            enemies[numOfEnemy].GetDamage(player.WeaponSlot1.Damage);
                        }
                        else
                        {
                            Console.WriteLine("Оружие в правой руке сломалось! Замените его");
                        }

                        if (player.WeaponSlot2.Durability > 0)
                        {
                            countOfDamage += player.WeaponSlot2.Damage;
                            countOfDamage += enemies[numOfEnemy].GetDamage((player).WeaponSlot2.Damage);
                        }
                        else
                        {
                            Console.WriteLine("Оружие в правой руке сломалось! Замените его");
                        }

                        break;
                    case 2:
                        player.ShowInventory(player);
                        break;
                    case 3:
                        TestPrintAllObjects();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }

                player.GetDamage((enemies[numOfEnemy] as Enemies).WeaponSlot1.Damage);

                if (enemies[numOfEnemy].Health <= 0)
                {
                    (enemies[numOfEnemy] as Enemies).Destroy(player, enemies[numOfEnemy] as Enemies);
                    numOfEnemy--;
                }

                player.Destroy(countOfDamage, enemies[numOfEnemy] as Enemies);

                Console.Clear();
            }

            Console.WriteLine("Враги побеждены");
        }

        //Вывод всех обьектов, которые могут быть в игре. Нужно только для тестов
        static void TestPrintAllObjects()
        {
            Unit[] weakEnemy = new WeakEnemy[3];
            Unit[] mediumEnemy = new MediumEnemy[3];
            Unit[] strongEnemy = new StrongEnemy[3];

            FillUnitArray(weakEnemy, 3, 0);
            FillUnitArray(mediumEnemy, 3, 1);
            FillUnitArray(strongEnemy, 3, 2);

            for (int i = 0; i < weakEnemy.Length; i++)
            {
                Console.WriteLine(weakEnemy + "\n");
                Console.WriteLine(mediumEnemy.ToString() + "\n");
                Console.WriteLine(strongEnemy + "\n");
            }

            Barrel barrel = new Barrel("Бочка", 32, 34);
            Chest chest = new Chest("Сундук", 21, 25);
            Crate crate = new Crate("Ящик", 21, 25);

            Chestplate chestplate = new Chestplate("Железная кираса", 20, 500, true);
            Helmet helmet = new Helmet("Железный шлем", 4, 30);

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