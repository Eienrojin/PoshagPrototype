using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class Player : Unit
    {
        public Player(string name, int health) : base(name, health)
        {
            if (name == "")
            {
                Name = GetName();
            }
        }

        public void Destroy()
        {
            GameOver.ShowGameOver();
        }

        public void AskLowHP()
        {
            string answer;

            //Тестовая реализация сообщения о скорой смерти и предложения вылечиться
            if (Health < Health*0.3)
            {
                Console.WriteLine("Осталось мало здоровья! Хотите принять лекарство?" +
                    "\n - Да" +
                    "\n - Нет\n");

                answer = Console.ReadLine().Trim().ToLower();

                if (answer == "да")
                {
                    //Логика лечения
                }
                else if (answer == "нет")
                {
                    Console.WriteLine("Чтож, тогда удачи");
                }
                else
                {
                    //Функция, которая выдает "Не понял что ты хочешь"
                }
            }
        }

        public void GetDamage(int damage)
        {
            throw new NotImplementedException();
        }

        public void Cure(int treatment)
        {
            throw new NotImplementedException();
        }

        string GetName()
        {
            Random random = new Random();

            string[] names = { "Игорь", "Васян", "Вано", "Кирилл", "Шрам", "Неизвестный" };

            string name = names[random.Next(0, names.Length)];

            return name;
        }

        public override string ToString()
        {
            return $"Вы - {Name}\n Здоровье = {Health}\n";
        } 
    }
}
