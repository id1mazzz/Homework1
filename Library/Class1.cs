using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;


namespace Library
{
    public class ZadanieOne
    {
        public void One()
        {
            Console.Write("Введите число N: ");
            int n = int.Parse(Console.ReadLine());
            string result = string.Join(", ", Enumerable.Range(1, n));
            Console.WriteLine(result);
        }
    }
    public class ZadanieTwo
    {
        public static void Two()
        {
            Console.Write("Введите нечетное число N: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0) // If N is an even number, exit the function.
            {
                Console.WriteLine("Вы ввели четное N.");
                return;
            }
            double enter = n / 2 + 1;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (row == enter && col == enter) Console.Write(" ");
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
