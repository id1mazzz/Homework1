using System;
using Library;


namespace homework1
{
    internal class ConsoleProgram
    {
        static void Main(string[] args)
        {
            GetStringSquare x = new GetStringSquare();

            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            x.GetNumberSequence(n);

            Console.WriteLine("\n Введите нечетное число");
            int N = Convert.ToInt32(Console.ReadLine());
            x.DisplaySquare(N);
        }
    }
}

