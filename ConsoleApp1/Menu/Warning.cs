using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class Warning
    {
        /// <summary>
        /// Метод выводящий сообщение об ошибке о неправильном значении
        /// </summary>
        /// <param name="typeOfDate">Тип проверяемых данных:
        /// <br> 0 - int </br>
        /// <br> 1 - string </br> </param>
        public static void ShowWarning(int typeOfDate)
        {
            switch(typeOfDate)
            {
                default:
                    Console.WriteLine("Неизвестное значение");
                    break;
                case 0:
                    Console.WriteLine("Вы ввели неправильное числовое значение значение." +
                        "Попробуйте ещё раз");
                    break;
                case 1:
                    Console.WriteLine("Вы ввели неправильное текстовое значение значение." +
                        "Попробуйте ещё раз");
                    break;
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Метод выводящий сообщение об ошибке о выходе за пределы листа
        /// </summary>
        public static void ShowOutOfRange()
        {
            Console.WriteLine("Нет предмета под таким номером!");
        }
    }
}
