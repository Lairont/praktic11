using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    /// <summary>
    /// Задача 10. Удаление всех четных элементов из массива.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = { 1, 5, 6, 8, 9, 4, 22, 2, 3 };
            omas = omas.Where(x => x % 2 != 0).ToArray();
            foreach (var el in omas)
            {
                Console.WriteLine(el);
            }
            Console.ReadLine();
        }
    }
}
