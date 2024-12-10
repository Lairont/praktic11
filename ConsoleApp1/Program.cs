using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// Задача 1. Определить количество элементов одномерного массива.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] omas = { 1, 3, 5, 6, 2 };
            Console.WriteLine($"Размер: {omas.Length}") ;
            string[] mas = { "Антон","Данил","Никита","Артем" };
            int size = mas.Length;
            Console.WriteLine($"Размер: {size}");
            Console.ReadLine();
        }
    }
}
