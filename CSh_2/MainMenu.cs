using System;

namespace CSh_2
{
    class MainMenu
    {
        static void Main(string[] args)
        {
            int e;
            do
            {
                Console.WriteLine("\n-----Упражнения к ДЗ №2-----\n" +
                "1) Минимальное из 3-х чисел\n" +
                "2) Количество цифр в числе\n" +
                "8) Очистить экран\n" +
                "Для выхода введите любой другой символ!");
                e = int.Parse(Console.ReadLine());
                switch (e)
                {
                    case 1:
                        {
                            Tasks.EnteringNum();
                            break;
                        }
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    case 5: break;
                    case 6: break;
                    case 7: break;
                    case 8: Console.Clear(); break;
                }
            } while (e >= 1 && e <= 8);
        }
    }
}
