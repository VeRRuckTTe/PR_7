/******************************************************************************/
/* Практическая работа №8                                                     */
/* Выполнила: Корнеева В.Е., 2-ИСП                                            */
/* Задание: Составить программу для вычисления функций                        */
/******************************************************************************/
using System;

namespace PR_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Title = "Практическая работа №7";
            Console.WriteLine("Здравствуйте.");
            int a = 0, b = 0, h;
            double result;
            for (; ; )
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Введите a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите h: ");
                    h = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException fEx)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка: {fEx.Message}");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (double i = a; i <= b; i += h)
                {
                    result = 1/Math.Tan(i / 3) + 0.5 * Math.Sin(i);
                    Console.WriteLine($"Значение аргумента: {i}, значение функции: {result}");
                }
                Console.Write("Вы хотите выйти? Y:");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    break;
                Console.Clear();
            }
        }
    }
}

