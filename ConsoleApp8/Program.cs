using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    /// <summary>
    /// Задача 8. Изменение размера массива.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 7, 56, 9, 3, 6, 0 };
            Array.Resize(ref array, 4);
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}