using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal interface ILoot
    {
        /// <summary>
        /// Метод для описания добавления предмета
        /// </summary>
        void AddItem();

        /// <summary>
        /// Метод для описания удаления предмета
        /// </summary>
        void RemoveItem();

        /// <summary>
        /// Метод для описания использования предмета
        /// </summary>
        void UseItem();
    }
}
