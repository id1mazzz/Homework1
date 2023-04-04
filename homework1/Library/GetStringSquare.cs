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
        public int GetSequence(int n)
        {
            for (int result = 1; result <= n; result++)
            {
                Console.Write(result + ",");
            }

            return n;
        }
        private const int MinN = 0;
        /// <summary>
        /// Вывод на экран квадрата из # с указанным количеством строк.
        /// </summary>
        /// <param name="n">Cторона квадрата. </param>
        public int ShowSquare(int n)
        {
            if(n < MinN)
            {
                throw new ArgumentOutOfRangeException(nameof(n), $"Размер стороны не может быть отрицательным");
            }

            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if ((j == 0 && i == 0) || (j == n - 1 && i == 0) || (j == 0 && i == n - 1) || (j == n - 1 && i == n - 1))
                        {
                            Console.Write(" ");
                        }

                        else
                        {
                            if (i == n / 2 && j == n / 2)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
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
}
