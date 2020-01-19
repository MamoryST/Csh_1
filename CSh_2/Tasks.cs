using System;
using System.Collections.Generic;
using System.Text;

namespace CSh_2
{
    class Tasks
    {
        /// <summary>
        /// Минимальное из 3-х целых чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int MinNum(int a, int b, int c)
        {
            if (a < b && a < c) return a;
            else if (b < c) return b;
            else return c;
        }
        public static void EnteringNum()
        {
            Console.Write("Введите 1-е число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите 2-е число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("ВВедите третье число: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"Минимальное из этих чисел: {MinNum(a, b, c)}");
        }
    }
}
