using System;
using System.Collections.Generic;
using System.Text;

namespace CSh_2
{
    class Library
    {
        /// <summary>
        /// Минимальное из 3-х целых чисел
        /// </summary>
        /// <param name="a">первое число</param>
        /// <param name="b">второе число</param>
        /// <param name="c">третье число</param>
        /// <returns></returns>
        static public int MinNum(int a, int b, int c)
        {
            if (a < b && a < c) return a;
            else if (b < c) return b;
            else return c;
        }
        /// <summary>
        /// количество чисел в целом числе
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static public int Enum(int a)
        {
            int sumOfN = 0;
            while(a != 0)
            {
                sumOfN += 1;
                a /= 10;
            }
            return sumOfN;
        }
        /// <summary>
        /// Генерация целого числа от 1 до 100
        /// </summary>
        /// <returns></returns>
        static public int GenIntNum()
        {
            return new Random().Next(1, 100);
        }
        /// <summary>
        /// Проверка правильности ввода логина и пароля
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static public bool UserEntering(string login, string password)
        {
            if (login == "root" && password == "GeekBrains") return true;
            else return false;
        }
        static public double BodyMassIndex(double height, double weight)
        {
            return (weight / (height * height));
        }
    }
}
