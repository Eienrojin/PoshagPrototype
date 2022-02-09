using System;
using System.Collections.Generic;

namespace PoshagPrototype
{
    /// <summary>
    /// Абстрактный класс Добыча
    /// </summary>
    internal class Loot : ILoot
    {
        public void RemoveItem(int index, List<ILoot> obj)
        {
            while (true)
            {
                bool isSafe = true;

                Console.WriteLine("Введите номер предмета, который вы хотите выкинуть (вернуть предмет назад нельзя!)");

                try
                {
                    index = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    isSafe = false;
                    Warning.ShowWarning(0);
                }

                if (isSafe)
                {
                    break;
                }
            }

            if (index >= 0 || index <= obj.Count)
            {
                obj.RemoveAt(index);
            }
            else
            {
                Warning.ShowOutOfRange();
            }
        }

        public void UseItem()
        {
            throw new NotImplementedException();
        }
    }
}