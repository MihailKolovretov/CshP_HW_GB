/***********************************************************
 *                                                         *
 *     Домашнее задание C#1 занятие 2                      *
 *     Исполнил: Панченко Михаил                           *
 *                                                         *
 **********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work2
{

    class Program
    {
        private static int MinNum(int a, int b, int c)// Метод, возвращающий минимальное из трех чисел
        {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < a && b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        private static int NumDig(int n)// Метод подсчета количества цифр числа
        {
            int s = 0;
            for (int i = 1; n > 0; i++)
            {
                n = n / 10;
               s++;
            }
            return s;
        }



        static void Main(string[] args)
        {
            //задание1. Выбор наименьшего числа из трех
            Console.WriteLine("Задание 1. Минимальное из трех чисел:");
            Console.WriteLine("Введите a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Наименьшее из трех введенных чисел равно: {MinNum(a, b, c)}");
            Console.ReadLine();
            Console.Clear();
            //Задание2. подсчет количества цифр числа
            Console.WriteLine("Задание 2.Gдсчет количества цифр:");
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Количество цифр в введеном числе равно: {NumDig(n)}");
            Console.ReadLine();
            Console.Clear();
            //Задание3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел
            Console.WriteLine("Задание3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел:");
            int num = 0;
            int sum = 0;
            do
            {
                Console.WriteLine("Введите число");
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2 == 1)
                {
                    sum+=num;
                }
            } while (num != 0);
            Console.WriteLine("Сумма всех нечетных положительных чисел :" + sum);
            Console.ReadKey();
            Console.Clear();
            //Задание4. Реализовать метод проверки логина и пароля. 
            string log="root";
            string pas ="password";
            int i = 0;
            do
            {
                Console.WriteLine("Введите логин");
                string login = Console.ReadLine();
                if (log == login)
                {
                    Console.WriteLine("логин принят, введите пароль");
                    Console.WriteLine("Введите пароль");
                    string password = Console.ReadLine();
                    if (pas == password)
                    {
                        Console.WriteLine("Доступ разрешен");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Пароль не верен");
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("логин не верен");
                    Console.ReadKey();
                    i++;
                }
            } while (i < 3);
            Console.ReadKey();
            Console.Clear();
            // как то сложно все получилось, но я думаю дело практики
            //Задание5. Написать программу, которая запрашивает массу и рост человека
            double BodyIndex = 0;
            Console.WriteLine("Введите Ваш рост");
            double growth = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Ваш вес");
            double weight = double.Parse(Console.ReadLine());
            Console.Clear();

            //Задание 5. вычисление индекса массы тела
            BodyIndex = weight / (growth * growth);
            Console.WriteLine($"индекс массы тела {BodyIndex}");
            if (BodyIndex < 18.5)
            {
                Console.WriteLine("недостаточная масса тела");
                Console.ReadKey();
                Console.Clear();
            }
            else if (BodyIndex > 18.5 && BodyIndex < 24.99)
            {
                Console.WriteLine("Вы в норме, так держать");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Избыточная масса тела");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
