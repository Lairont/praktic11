using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    /// <summary>
    /// Задача 13. Заполните одномерный массив числовыми данными случайным образом из промежутка [ - 50;50].
    /// Подсчитайте количество элементов массива, кратных 3 (размерность массива равна 15).
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Inp();
            Count(array);
            Console.ReadLine();
        }
        static int[] Inp()
        {
            int[] array = new int[15];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = rnd.Next(-50, 50);
            }
            return array;
        }
        static void Count(int[]array)
        {
            
            foreach(var number in array)
            {
                if(number%3==0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
