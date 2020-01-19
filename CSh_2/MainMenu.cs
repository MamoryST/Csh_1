using System;

namespace CSh_2
{
    class MainMenu
    {
        static void Task_1()
        {
            Console.Clear();
            int a = new Random().Next(1, 100); //генератор числа от 1 до 100
            int b = Library.GenIntNum(); //тот же генератор, но как отдельный метод
            int c = Library.GenIntNum();
            Console.WriteLine($"{a}\t{b}\t{c}");
            Console.WriteLine($"Минимальное из 3-х чисел: { Library.MinNum(a, b, c)}");
            Console.WriteLine("Для выхода в меню нажмите Enter");
            Console.ReadKey(); //Задержка экрана
        }
        static void Task_2()
        {
            Console.Clear();
            int a = Library.GenIntNum();
            Console.WriteLine($"[{a}] содержит чисел: {Library.Enum(a)} ");
            Console.WriteLine("Для выхода в меню нажмите Enter");
            Console.ReadKey(); //Задержка экрана
        }
        static void Task_3()
        {
            Console.Clear();
            int num;
            int sum = 0;
            do
            {
                Console.Write("Введите целое число(0 - для выхода): ");
                num = int.Parse(Console.ReadLine());
                if (num % 2 != 0) sum += 1;
            } while (num != 0);
            Console.WriteLine($"количество нечетных чисел: {sum}");
            Console.WriteLine("Для выхода в меню нажмите Enter");
            Console.ReadKey(); //Задержка экрана
        }
        static void Task_4()
        {
            Console.Clear();
            string login, password;
            short enTry = 3; //Счетчик попыток
            bool accessGranting = false;//Флаг для допуска 

            do
            {
                Console.Clear();
                Console.WriteLine($"Число попыток: {enTry}");
                Console.Write("Введите логин: "); login = Console.ReadLine();
                Console.Write("Введите пароль: "); password = Console.ReadLine();
                if (Library.UserEntering(login, password))
                {
                    accessGranting = true;
                    break;
                }
                else enTry -= 1;
            } while (enTry >= 1);

            //if (accessGranting) Console.WriteLine("Welcome, User!");
            //else Console.WriteLine("Access deny!!!");
            //то же самое, но через тернаррный оператор
            Console.WriteLine(accessGranting ? "Welcome, Oniichan!^-^" : "Access deny!!!");

            Console.WriteLine("Для выхода в меню нажмите Enter");
            Console.ReadKey(); //Задержка экрана
        }
        static void Task_5()
        {
            Console.Clear();
            double height, weight;
            double bmi;
            Console.WriteLine("!!!Индекс массы тела следует применять с осторожностью, исключительно для ориентировочной оценки!!!");
            Console.Write("Введите ваш рост(м, пример: 1,68): "); height = Double.Parse(Console.ReadLine());
            Console.Write("Введите ваш вес(кг, пример: 55,5): "); weight = Double.Parse(Console.ReadLine());

            bmi = Library.BodyMassIndex(height, weight);
            Console.WriteLine($"Ваш индекс массы тела: {bmi}");

            if (bmi > 0 && bmi <= 16) Console.WriteLine("Выраженный дефицит массы тела.");
            else if (bmi > 16 && bmi <= 18.5) Console.WriteLine("Недостаточная (дефицит) масса тела.");
            else if (bmi > 18.5 && bmi <= 25) Console.WriteLine("Норма.");
            else if (bmi > 25 && bmi <= 30) Console.WriteLine("Избыточная масса тела (предожирение).");
            else if (bmi > 30 && bmi <= 35) Console.WriteLine("Ожирение.");
            else if (bmi > 35 && bmi <= 40) Console.WriteLine("Ожирение резкое");
            else if (bmi > 40) Console.WriteLine("Очень резкое ожирение.");
            else Console.WriteLine("вводимые данные ошибочны. Перепроверьте!");

            Console.WriteLine("Для выхода в меню нажмите Enter");
            Console.ReadKey(); //Задержка экрана
        }
        static void Task_6()
        {

        }
        static void Main(string[] args)
        {
            string select;
            do
            {
                Console.Clear();
                Console.WriteLine("\n-----Упражнения к ДЗ №2-----\n" +
                "1) Минимальное из 3-х чисел\n" +
                "2) Количество цифр в числе\n" +
                "3) Ввод чисел, пока не будет введен 0. Подсчитать сумму всех нечетных чисел\n"+
                "4) Реализация метода проверки логина и пароля\n" +
                "5) расчет индекса массы тела\n" +
                "6) \"Хорошие\" числа\n" +
                "Для выхода введите слово \"exit\" или 0!");
                select = Console.ReadLine();
                switch (select)
                {
                    case "1": 
                        { 
                            Task_1(); 
                            break; 
                        }
                    case "2":
                        {
                            Task_2();
                            break; 
                        }
                    case "3":
                        {
                            Task_3();
                            break;
                        }
                    case "4":
                        {
                            Task_4();
                            break;
                        }
                    case "5":
                        {
                            Task_5();
                            break; 
                        }
                    case "6": break;
                    case "7": break;
                }
            } while (select != "0" && select != "exit");
        }
    }
}
