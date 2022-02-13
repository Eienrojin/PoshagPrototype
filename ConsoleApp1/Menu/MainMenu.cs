/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class MainMenu
    {
        private static int _answer;
        private static bool _safe = true;
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

        static void InitAndCheckAsw()
        {
            try
            {
                _answer = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Warning.ShowWarning(0);
                Console.Clear();
                _safe = false;
            }
        }

        static void ShowMenu()
        {
            while (true)
            {
                _safe = true;

                ShowLogo();

                Console.WriteLine("Добро пожаловать в прототип Пошага." +
                    "\n1. Начать игру" +
                    "\n2. Показать правила" +
                    "\n3. Выйти");

                InitAndCheckAsw();

                if (_safe)
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

        static void ShowRules()
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

        static bool ChoicePlayer()
        {
            bool choiced = false;

            while (!choiced)
            {
                _safe = true;

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

                InitAndCheckAsw();

                if (_safe)
                {
                    switch (_answer)
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
            }
        }
    }
}
*/