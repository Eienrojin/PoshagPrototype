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

        }

        void PrintAllObjects()
        {
            Random random = new Random();

            Player player = new Player("Игорь", 300);
            Player player2 = new Player("Васян", 100);
            Player player3 = new Player("Вано", 500);

            WeakEnemy rat = new WeakEnemy("Крыса", random.Next(10, 30));
            MediumEnemy goblin = new MediumEnemy("Гоблин", random.Next(25, 50));
            StrongEnemy bandit = new StrongEnemy("Бандит", random.Next(50, 80));

            Barrel barrel = new Barrel("Бочка", 32);
            Chest chest = new Chest("Сундук", 21);
            Crate crate = new Crate("Ящик", 21);

            Chestplate chestplate = new Chestplate("Железная кираса", 20);
            Helmet helmet = new Helmet("Железный шлем", 30);

            Hammer hammer = new Hammer("Железный молот", 3, 5);
            Sword sword = new Sword("Железный меч", 5, 5);

            Console.WriteLine(player);
            Console.WriteLine(player2);
            Console.WriteLine(player3);

            Console.WriteLine(barrel);
            Console.WriteLine(chest);
            Console.WriteLine(crate);

            Console.WriteLine(rat);
            Console.WriteLine(goblin);
            Console.WriteLine(bandit);

            Console.WriteLine(chestplate);
            Console.WriteLine(helmet);

            Console.WriteLine(hammer);
            Console.WriteLine(sword);

            Console.ReadKey();
        }
    }
}
