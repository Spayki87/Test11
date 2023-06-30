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

            int minNumber = 0, maxNumber = 100;
            int number = random.Next(minNumber, maxNumber + 1);
            int divider1 = 3;
            int divider2 = 5;
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
