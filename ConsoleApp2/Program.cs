using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        /// <summary>
        /// Задача 2. Обнулить заданный диапазон элементов в одномерном массиве.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] omas = Inp(Size());
            Array.Clear(omas, 1, 3);
            Out(omas);
            Console.ReadLine();
        }
        static int Size()
        {
            Console.Write("Размер однородного массива= ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Error");
            }
            return size;
        }
        static int[] Inp(int size)
        {
            int[] omas = new int[size];
            for(int i=0;i<omas.Length;i++)
            {
                Console.Write($"Введите {i + 1} значение: ");
                omas[i] = int.Parse(Console.ReadLine());
            }
            return omas;
        }
        static void Out(int[] omas)
        {
            foreach(var element in omas)
            {
                Console.WriteLine(element);
            }
        }
    }
}
