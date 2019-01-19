/***********************************************************
 *                                                         *
 *     Домашнее задание C#1 занятие 1                      *
 *     Исполнил: Панченко Михаил                           *
 *                                                         *
 **********************************************************/    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work1
{
    class Program
    {
        //метод определения расстояния между двумя точками
        static double R (double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }


        //вывод 
        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }




        static void Main(string[] args)
        {
            //переменные для преобразования из строковых в целочисленные данные
            int _age = 0;
            double _growth = 0;
            double _weight = 0;
            double BodyIndex = 0;
           

            //ввод исходных данных
            Console.WriteLine("Введите Ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Вашу фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите город вашего проживания");
            string city = Console.ReadLine();
            Console.WriteLine("Введите Ваш возраст");
            string age = Console.ReadLine();
            _age = Convert.ToInt32(age);
            Console.WriteLine("Введите Ваш рост");
            string growth = Console.ReadLine();
            _growth = Convert.ToDouble(growth);
            Console.WriteLine("Введите Ваш вес");
            string weight = Console.ReadLine();
            _weight = Convert.ToDouble(weight);
            Console.Clear();

            //вычисление индекса массы тела
            BodyIndex = _weight / (_growth * _growth);
           

            // вывод на консоль
            Console.WriteLine($"Ваше имя: { name} \nВаша фамилия: { surname} \nВаш возраст: { _age} \nВаш рост: {_growth} \nВаш вес: {_weight} \nИндекс массы тела:{BodyIndex}");
            Console.ReadKey();
            Console.Clear();



            //ввод точек
            Console.WriteLine("Определение расстояния между двумя точками\n");
            Console.WriteLine("Введите X1");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите X1");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите X1");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите X1");
            double y2 = double.Parse(Console.ReadLine());
            Console.Clear();

            // вызов метода определения двух точек
            Console.WriteLine($"расстояние между точками = " + R(x1,x2,y1,y2));

            Console.ReadKey();
            Console.Clear();

            // обмен значениями двух переменных без использования третьей переменной
            Console.WriteLine("Введите а");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            Console.WriteLine("a = " + a + " b = " + b);
            b = a - b;
            Console.WriteLine("b = " + b + " a = " + a);
            a = a - b;
            Console.WriteLine("a = " + a + " b = " + b);
            Console.ReadKey();
            Console.Clear();

            // программа вывода имени и города
            Print(name, 38, 9);
            my_metod.Print(city, 38, 10);
                       
            // 


            my_metod.Pause();
        }
    }
}
