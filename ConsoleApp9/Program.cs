using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
    /// <summary>
    /// Задача 9. Поиск индекса элемента.
    /// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 56, 7, 3, 7, 12, 67, 4, 5, 2, 6, 9, };
            int index = Array.IndexOf(array, 12);
            Console.WriteLine(index);     
            Console.ReadLine();
        }
    }
}
