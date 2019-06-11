using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_methods;

namespace InfSum
{
    class Program
    {
        static double Summa(int i)
        {
            double sum = Math.Pow(-1, i + 1) / (Math.Pow(i, 3) + 3 * Math.Pow(i, 2) + 2 * i);
            return sum;
        }
        static void Main()
        {
            int i = 0;
            double sum = 0;
            Color.Print(" Введите заданную точность e = ", ConsoleColor.Yellow);
            double e = Number.Check(0.000000001, 1);
            do
            {
                i++;
                sum = sum + Summa(i);
            }
            while (Math.Abs(Summa(i)) >= e);
            Color.Print("\n Сумма = " + sum + " с точностью е = " + e + " (последнее слaгаемое " + Summa(i) + ")", ConsoleColor.Green);
            Console.ReadKey();
        }
    }
}
