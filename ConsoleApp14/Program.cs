using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// Задача 14. Дан курс рубля России за январь 2023 года. Рассчитать:
    /// а) среднее значение КВ(СКВ);
    /// б) максимальное значение КВ(МаксКВ);
    /// в) минимальное значение КВ(МинКВ);
    /// г) день с максимальным значением КВ(МаксКВД);
    /// д) день с минимальным значением КВ(МинКВД).
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] course = Inp();
            Average(course);
            Maxday(course);
            Minday(course);
            Console.ReadLine();
        }
        static double[] Inp()
        {
            double[] course = { 70.2, 70.3, 70.3, 70.3, 70.3, 70.3, 70.3, 70.3, 70.3, 69.6, 69.0, 67.8, 67.6, 67.6, 67.6,
                                68.3, 68.7, 68.9, 68.8, 68.7, 68.7, 68.7, 68.7, 68.6, 68.7, 68.9, 69.1, 69.3, 69.3, 69.3, 69.6 };
            return course;
        }
        static void Average(double[] course)
        {
            double average = course.Average();
            Console.WriteLine($"СКВ:{average:F1}");

        }
        static double Max(double[] course)
        {
            double max = course.Max();
            Console.WriteLine($"МаксКВ:{max}");
            return max;
        }

        static double Min(double[] course)
        {
            double min = course.Min();
            Console.WriteLine($"МинКВ:{min}");
            return min;
        }

        static void Maxday(double[] course)
        {
            double max = Max(course);
            int maxDay = Array.IndexOf(course, max) + 1;
            Console.WriteLine($"МаксКВД:{maxDay}");
        }
        static void Minday(double[] course)
        {
            double min = Min(course);
            int minDay = Array.IndexOf(course, min) + 1;
            Console.WriteLine($"МинКВД:{minDay}");
        }
    }
}
