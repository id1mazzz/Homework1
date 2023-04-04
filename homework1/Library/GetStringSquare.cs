using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;


namespace Library
{
    /// <summary>
    /// Формирование определенных последовательностей символов.
    /// </summary>
    public class GetStringSquare
    {
        private const int MinimumSideLength = 0;

        /// <summary>
        /// Формирует и возвращает строку чисел от 1 до заданного числа, разделенных запятой.
        /// </summary>
        /// <param name="n">Количество чисел в последовательности.</param>
        /// <returns>Строка, содержащая последовательность чисел от 1 до n, разделенных запятой.</returns>
        public string GetNumberSequence(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), $"Размер строки не может быть меньше нуля");
            }
            var sequence = string.Join(", ", Enumerable.Range(1, n));
            Console.WriteLine(sequence);
            return sequence;
        }

        /// <summary>
        /// Выводит на экран квадрат из # с указанным количеством строк.
        /// </summary>
        /// <param name="sideLength">Cторона квадрата.</param>
        /// <returns>0, если квадрат был успешно выведен на экран.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Вызывается, если размер стороны меньше нуля.</exception>
        public int DisplaySquare(int sideLength)
        {
            if (sideLength < MinimumSideLength)
            {
                throw new ArgumentOutOfRangeException(nameof(sideLength), $"Размер стороны не может быть меньше нуля");
            }
            if (sideLength % 2 == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(sideLength), $"Размер стороны должен быть нечетным");
            }

            for (var i = 0; i < sideLength; i++)
            {
                for (var j = 0; j < sideLength; j++)
                {
                    if ((j == 0 && i == 0) || 
                        (j == sideLength - 1 && i == 0) || 
                        (j == 0 && i == sideLength - 1) || 
                        (j == sideLength - 1 && i == sideLength - 1))
                    {
                        // Выводим пробел в углах квадрата
                        Console.Write(" ");
                    }
                    else
                    {
                        if (i == sideLength / 2 && j == sideLength / 2)
                        {
                            // Выводим пробел в центре квадрата
                            Console.Write(" ");
                        }
                        else
                        {
                            // Выводим #
                            Console.Write("#");
                        }
                    }
                }
                Console.WriteLine();
            }
            return 0;
        }
    }
}
