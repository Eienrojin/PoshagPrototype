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
            int countOfDamage = 0;
            int choicePlayer;
            int answer = -1;

            ShowMenu(answer);
            choicePlayer = ChoicePlayer(answer);


        }

        /// <summary>
        /// Выдает начальное снаряжение выбранному игроку
        /// </summary>
        static void GetStartInventory(PlayerOrk obj)
        {
            Chestplate startChestplate = new Chestplate("Балахон", 10, 14, false);
            Helmet startHelmet = new Helmet("Повязка на голову", 4, 5);
            Hammer startHammer = new Hammer("Рабочий молоток", 10, 20, 25);

            obj.Inventory = new List<ILoot>();

            obj.WeaponSlot1 = startHammer;
            obj.BodySlot = startChestplate;
            obj.HelmetSlot = startHelmet;
        }

        static void GetStartInventory(PlayerHuman obj)
        {
            Sword startSword = new Sword("Меч", "Стальной", 7, 25, 30);
            Sword startSword2 = new Sword("Меч", "Старый ржавый", 5, 10, 10);
            Chestplate startChestplate = new Chestplate("Балахон", 10, 14, false);
            Helmet startHelmet = new Helmet("Повязка на голову", 4, 5);

            obj.Inventory = new List<ILoot>();

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

        static void Fight(Player player)
        {
            Random random = new Random();
            int countOfEnemies = 5;
            int numOfEnemy = countOfEnemies - 1;
            Unit[] enemies = new Unit[countOfEnemies];

            FillUnitArray(enemies, countOfEnemies, random.Next(0, 2));

            while (numOfEnemy != -1)
            {
                Console.WriteLine(player);
                Console.WriteLine("Сделайте выбор\n" +
                    "1. Ударить\n" +
                    "2. Открыть инвентарь\n" +
                    "3. ТЕСТ Вывести все обьекты\n" +
                    "4. Выйти из игры");

                int answer = int.Parse(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        if (player is PlayerOrk)
                            enemies[numOfEnemy].GetDamage(player.WeaponSlot1.Damage);

                        if (((PlayerHuman)player).WeaponSlot2 != null)
                        {
                            enemies[numOfEnemy].GetDamage(((PlayerHuman)player).WeaponSlot2.Damage);
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



                if (enemies[numOfEnemy].Health <= 0)
                {
                    enemies[numOfEnemy].Destroy();
                    numOfEnemy--;
                }
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

        //Раздел с меню. Не перенес в отдельный класс, потому что были беды с созданием выбранного игрока
        static void ShowLogo()
        {
            string _logo = @" ▄▄▄·      .▄▄ ·  ▄ .▄ ▄▄▄·  ▄▄ • 
▐█ ▄█▪     ▐█ ▀. ██▪▐█▐█ ▀█ ▐█ ▀ ▪
 ██▀· ▄█▀▄ ▄▀▀▀█▄██▀▐█▄█▀▀█ ▄█ ▀█▄
▐█▪·•▐█▌.▐▌▐█▄▪▐███▌▐▀▐█ ▪▐▌▐█▄▪▐█
.▀    ▀█▄▀▪ ▀▀▀▀ ▀▀▀ · ▀  ▀ ·▀▀▀▀ 
▄▄▄▄· ▄▄▄ .▄▄▄▄▄ ▄▄▄·             
▐█ ▀█▪▀▄.▀·•██  ▐█ ▀█             
▐█▀▀█▄▐▀▀▪▄ ▐█.▪▄█▀▀█             
██▄▪▐█▐█▄▄▌ ▐█▌·▐█ ▪▐▌            
·▀▀▀▀  ▀▀▀  ▀▀▀  ▀  ▀             

";

            Console.WriteLine(_logo);
        }

        static int InitAndCheckAnswer()
        {
            int answer = -1;

            try
            {
                answer = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Warning.ShowWarning(0);
                Console.Clear();
            }
            return answer;
        }


        static void ShowMenu(int answer)
        {
            while (true)
            {
                ShowLogo();

                Console.WriteLine("Добро пожаловать в прототип Пошага." +
                    "\n1. Начать игру" +
                    "\n2. Показать правила" +
                    "\n3. Выйти");

                answer = InitAndCheckAnswer();

                switch (answer)
                {
                    default:
                        if (answer != 1)
                            Console.WriteLine("Такого варианта нет");
                        break;
                    case 2:
                        ShowRules();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }

                if (answer == 1)
                {
                    break;
                }
            }

        }

        private static void ShowRules()
        {
            Console.Clear();

            Console.WriteLine("Правила и обьяснение игры:" +
                "\nЭта игра - последовательная боевка с врагами разной сложности." +
                "\nНа выбор дается 3 героя с разной историей и характеристиками " +
                "\n(подробнее о каждом герое в самой игре)" +
                "\n\nЕсть 3 типа врагов: слабые, средние и мощные. " +
                "\nС каждого врага может упасть лут в виде брони или оружия");

            Console.ReadKey();

            Console.Clear();
        }

        static int ChoicePlayer(int answer)
        {
            bool choiced = false;

            while (!choiced)
            {
                Console.Clear();
                ShowLogo();

                Console.WriteLine("Выберите бойца");
                Console.WriteLine("1. Человек - акробат. Выходец из деревни и ловкий боец." +
                    "\nМожет орудовать двумя руками, но хилый. " +
                    "\nПри себе имеет старую одежду и мечи, которые он хотел сдать на металл.");

                Console.WriteLine("\n2. Орк - сильный дурак. Выходец из племени." +
                    "\nМожет бить со страшной силой, имеет повышенное здоровье." +
                    "\nПри себе носит одежду и старый молот");

                Console.WriteLine("\n3. Эльф. Вышел из дома." +
                    "\nМожет уклоняться и не получать урон. Самый слабый из всей тройки" +
                    "\nПри себе носит одежду и меч" +
                    "\n\nЗа кого будем играть?");

                answer = InitAndCheckAnswer();

                switch (answer)
                {
                    default:
                        Console.WriteLine("Такого варианта нет");
                        break;
                    case 1:
                        PlayerHuman playerHuman = new PlayerHuman("", 400, 400);
                        choiced = true;
                        break;
                    case 2:
                        PlayerOrk playerOrk = new PlayerOrk("", 700, 700);
                        choiced = true;
                        break;
                    case 3:
                        //PlayerElf playerElf = new PlayerElf("", 200, 200)
                        choiced = true;
                        break;
                }
            }

            return answer;
        }
    }
}



