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
            Player igor = new Player(GetName(), 5);
            Sword sword = new Sword("Меч", 15, 15);

            Console.WriteLine(igor);
            Console.WriteLine(sword);
            Console.ReadKey();

            PrintAllObjects();
        }

        static string GetName()
        {
            Random random = new Random();

            string[] names = { "Игорь", "Васян", "Вано", "Кирилл", "Шрам", "Неизвестный" };

            string name = names[random.Next(0, names.Length)];

            return name;
        }

        static void PrintAllObjects()
        {
            Random random = new Random();

            Player[] players = new Player[2];

            WeakEnemy weakEnemy = new WeakEnemy("", random.Next(10, 30));
            MediumEnemy mediumEnemy = new MediumEnemy("", random.Next(25, 50));
            StrongEnemy bandit = new StrongEnemy("Бандит", random.Next(50, 80));

            Barrel barrel = new Barrel("Бочка", 32);
            Chest chest = new Chest("Сундук", 21);
            Crate crate = new Crate("Ящик", 21);

            Chestplate chestplate = new Chestplate("Железная кираса", 20);
            Helmet helmet = new Helmet("Железный шлем", 30);

            Hammer hammer = new Hammer("Железный молот", 3, 5);
            Sword sword = new Sword("Железный меч", 5, 5);

            Console.WriteLine(barrel);
            Console.WriteLine(chest);
            Console.WriteLine(crate);

            Console.WriteLine(weakEnemy);
            Console.WriteLine(mediumEnemy);
            Console.WriteLine(bandit);

            Console.WriteLine(chestplate);
            Console.WriteLine(helmet);

            Console.WriteLine(hammer);
            Console.WriteLine(sword);

            Console.ReadKey();
        }
    }
}
