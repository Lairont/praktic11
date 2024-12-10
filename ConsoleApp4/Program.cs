using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        /// <summary>
        ///   Задача 4. Сортировка массива по возрастанию.
        ///   Задача 5. Реверс массива.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] omas = { "Арбуз", "Мандарин", "Яблоко"};
            Array.Reverse(omas);
            foreach(var element in omas)
            {
                Console.WriteLine(element);
            }
            Array.Sort(omas);
            foreach (var element in omas)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}
