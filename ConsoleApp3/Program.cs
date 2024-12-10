using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        /// <summary>
        /// Задача 3. Найти максимальное и минимальное значение в массиве.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] omas = { 3, 7, 8, 12, 4 };
            int max = omas.Max();
            int min = omas.Min();
            Console.WriteLine($"Max= {max}\nMin= {min}");
            Console.ReadLine();
        }
    }
}
