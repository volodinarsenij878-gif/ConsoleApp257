using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program98
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите расход топлива на 100 км (л): ");
            if (double.TryParse(Console.ReadLine(), out double fuel) && fuel >= 0)
            {
                string verdict;
                if (fuel < 6)
                {
                    verdict = "экономичный";
                }
                else if (fuel <= 10)
                {
                    verdict = "средний";
                }
                else
                {
                    verdict = "прожорливый";
                }

                Console.WriteLine($"Вердикт: {verdict} (расход: {fuel:F1} л/100км)");
            }
            else
            {
                Console.WriteLine("Ошибка: расход должен быть неотрицательным числом.");
            }
        }
    }
}