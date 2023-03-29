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
        /// <summary>
        /// Формирование и возврат строки от 1 до заданного числа.
        /// </summary>
        /// <param name="n">Количество чисел в последовательности.</param>
        public void GetSequence()
        {
            Console.Write("Введите число N: ");
            int n = int.Parse(Console.ReadLine());
            string result = string.Join(", ", Enumerable.Range(1, n));
            Console.WriteLine(result);
        }

        /// <summary>
        /// Вывод на экран квадрата из # с указанным количеством строк.
        /// </summary>
        /// <param name="N">Высота квадрата (количество строк). </param>
        public void ShowSquare()
        {
            Console.Write("Введите нечетное число N: ");
            int N = int.Parse(Console.ReadLine());
            if (N % 2 == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(N), "N должно быть нечетным");
                
            }

            double enter = N / 2 + 1;

            for (int row = 1; row <= N; row++)
            {
                for (int column = 1; column <= N; column++)
                {
                    if (row == enter && column == enter)
                    {
                        Console.Write(" ");
                    }

                    else
                    {
                        Console.Write("#");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
