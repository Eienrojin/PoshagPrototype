using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class MainMenu
    {
        private static void ShowLogo()
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

        public static void ShowMenu()
        {
            while (true)
            {
                int _answer = -1;
                bool safe = true;

                ShowLogo();

                Console.WriteLine("Добро пожаловать в прототип Пошага." +
                    "\n1. Начать игру" +
                    "\n2. Показать правила" +
                    "\n3. Выйти");

                try
                {
                    _answer = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Warning.ShowWarning(0);
                    Console.Clear();
                    safe = false;
                }

                if (safe)
                {
                    switch (_answer)
                    {
                        default:
                            if(_answer != 1)
                                Console.WriteLine("Такого варианта нет");
                            break;
                        case 2:
                            ShowRules();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                    }

                    if (_answer == 1)
                    {
                        break;
                    }
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
    }
}
