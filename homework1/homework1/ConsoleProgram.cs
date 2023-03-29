using System;
using homework1;
using Library;


namespace homework1
{
    class ConsoleProgram
    {
        static void Main(string[] args)
        {
            GetStringSquare librarysClass = new GetStringSquare();
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
                            librarysClass.GetSequence();
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("2. Квадрат из #");
                            librarysClass.ShowSquare();
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
