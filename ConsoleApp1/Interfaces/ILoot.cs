using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal interface ILoot
    {
        /* /// <summary>
          /// Метод для описания добавления предмета
          /// </summary>
          void AddItem(ILoot obj);*/

        /// <summary>
        /// Метод для описания удаления предмета
        /// </summary>
        void RemoveItem(int index, List<ILoot> obj);

        /// <summary>
        /// Метод для описания использования предмета
        /// </summary>
        void UseItem();
    }
}
