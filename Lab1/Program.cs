using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Индивидуальное задание.
             * Часть 1 */

            Console.WriteLine("Лабораторная работа №1");
            Console.WriteLine("Выполнил: Ленков Даниил Владимирович");
            Console.WriteLine("Группа: ИНС-б-о-19-1, шифр специальности: 09.03.02");
            Console.WriteLine("Дата рождения: 15.09.2001");
            Console.WriteLine("Населенный пункт постоянного места жительства: г.Ставрополь");
            Console.WriteLine("Любимый предмет в школе: информатика");
            Console.WriteLine("Краткое описание увлечений, хобби, интересов: чтение книг, " +
                "сборка головоломок, изучение программирования.\n\n");

            // Часть 2.

            int b = 3, t = 5, x = -25, w = 17;
            float w111 = 12;
            double y = 1.8, Se;
            Se = w111 + b * t - x + y * w;
            Console.WriteLine("Выражение: Se = w111 + bt - x + y * w");
            Console.WriteLine($"Вычисление: Se = {w111} + {b} * {t} - {x} + {y} * {w}");
            Console.WriteLine("Ответ: Se = " + Se);

            Console.ReadKey();
        }
    }
}