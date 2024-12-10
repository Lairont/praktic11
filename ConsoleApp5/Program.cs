using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        /// <summary>
        /// Задача 6. Подсчет количества вхождений определенного числа в массив.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3, 4, 2, 2, 5, 6, 2 };
            int tar = 2;
            int count = array.Count(i => i == tar);
            int cont = array.Count(i => i == tar);
            Console.WriteLine($"Число {tar} встречается {count} раз(а) в массиве.");
            Console.ReadLine();
        }
    }
}
