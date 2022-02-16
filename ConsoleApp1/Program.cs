//Что имеем:
//Бой одного игрока с врагом определенного типа
//Возможно пройти игру до конца
//Инвентарь не работает
//Несколько багов интерфейса

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
            MainMenu.ChoicePlayer();

            Console.Clear();
            Console.WriteLine("Выбора нет, автор не смог прописать");

            PlayerHuman player = new PlayerHuman("", 300, 300);
            player.GetStartInventory();

            Battle.Fight(player);

            Console.WriteLine("Конец игры, нажмите любую клавишу, чтобы выйти");
            Console.ReadKey();
        }
    }
}