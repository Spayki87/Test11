using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сумма_чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int number = random.Next(0, 101);
            int multiples1 = 3;
            int multiples2 = 5;
            int sumMultiples1 = 0;
            int sumMultiples2 = 0;
            int sumAllNumbers = 0;

            Console.WriteLine("Рандомное число: " + number);

            for (int i = 1; i <= number; i++)
            {
                if (i % multiples1 == 0 || i % multiples2 == 0)
                {
                    Console.WriteLine(i);
                    sumAllNumbers  += i;
                }
            }

            Console.WriteLine("Сумма всех чисел: " + sumAllNumbers);
        }
    }
}
