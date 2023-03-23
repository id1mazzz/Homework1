using System;
using homework1;
using Library;


namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            ZadanieOne first = new ZadanieOne();
            int nomer;
            do
            {
                Console.Clear();
                Console.WriteLine("Введите номер задания:");
                Console.WriteLine("1. Строка вида 1,2,3...N");
                Console.WriteLine("2. Квадрат из #");
                if (int.TryParse(Console.ReadLine(), out nomer))
                {
                    switch (nomer)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("1. Строка вида 1,2,3...N");
                            first.One();
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("2. Квадрат из #");
                            ZadanieTwo.Two();
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Неверный номер!");
                            Console.ReadKey();
                            break;
                    }
                }
            }
            while (nomer != 0);
        }
    }
}
