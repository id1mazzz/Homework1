using System;
using Library;


namespace homework1
{
    internal class ConsoleProgram
    {
        /// <summary>
        /// Считывание числа с консоли
        /// </summary>
        /// <returns></returns>
       

        static void Main(string[] args)
        {
            GetStringSquare generator = new GetStringSquare();
            Console.WriteLine("1. Введите число");

            int n = Convert.ToInt32(Console.ReadLine());
            generator.GetNumberSequence(n);


            Console.WriteLine("\n2. Введите нечетное число");

            int N = Convert.ToInt32(Console.ReadLine());
            generator.DisplaySquare(N);
        }
    }
}

