using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    /// <summary>
    /// Задача 6. Подсчет количества вхождений определенного числа в массив.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] omas = { 1, 3, 5, 7, 5, 2, 3, 4, 5, 6 };
            int count = omas.Count(x => x == 5);
            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
