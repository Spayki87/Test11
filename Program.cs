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
            int divider1 = 3;
            int divider2 = 5;
            int sumMultiples1 = 0;
            int sumMultiples2 = 0;
            int sumAllNumbers = 0;

            Console.WriteLine("Рандомное число: " + number);

            for (int i = 1; i <= number; i++)
            {
                if (i % divider1 == 0 || i % divider2 == 0)
                {
                    Console.WriteLine(i);
                    sumAllNumbers  += i;
                }
            }

            Console.WriteLine("Сумма всех чисел: " + sumAllNumbers);
        }
    }
}
