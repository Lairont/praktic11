using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    /// <summary>
    /// Задача 12. Умножение всех элементов массива на определенное число.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 7, 6, 5, 4, 3, 2, 7 };
            var result = array.Select(x => x * 2);
            foreach(var el in result)
            {
                Console.WriteLine(el);
            }
            Console.ReadLine();
        }
     
    }
}
