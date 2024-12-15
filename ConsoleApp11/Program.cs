using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    /// <summary>
    /// Задача 11. Сумма всех элементов массива.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = { 1, 3, 5, 7, 4, 23, 4, 5, 7 };
            int sum = omas.Sum();
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
