using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// Задача 4. Сортировка массива по возрастанию.
    /// Задача 5. Реверс массива.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };
            Array.Sort(people);
            foreach (var element in people)
            {
                Console.WriteLine(element);
            }
            Array.Reverse(people);
            foreach (var element in people)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

        }
    }
}
