/***********************************************************
 *                                                         *
 *     Домашнее задание C#1 занятие 2                      *
 *     Исполнил: Панченко Михаил                           *
 *                                                         *
 **********************************************************/
using home_work3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work3
{
    /// <summary>
    /// Cтруктура для работы с комплексными числами:
    /// </summary>
    struct Complex
    {
        public double im;// мнимая часть 
        public double re;//целая часть
        /// <summary>
        /// Функция сложения комплексных чисел
        /// </summary>
        /// <param name="x">комплексное число</param>
        /// <returns>результат сложения</returns>
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        /// <summary>
        /// Функция произведения комплексных чисел
        /// </summary>
        /// <param name="x">число</param>
        /// <returns>результат произведения комплексного числа</returns>
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        /// <summary>
        /// Функция вычитания кмплексных чисел
        /// </summary>
        /// <param name="x">комплексное число</param>
        /// <returns>результат разности комплексных чисел</returns>
        public Complex _subtraction(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;
            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;
            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());
            result = complex1._subtraction(complex2);
            Console.WriteLine(result.ToString());
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0.\n Подсчитать сумму всех нечетных положительных чисел:");
            dig.sumdig();
            Console.ReadKey();
            Console.Clear();

            Fraction x = new Fraction(1, 2);
            Fraction y = new Fraction(2, 3);
            Fraction z = new Fraction(311, 5222);

            Console.WriteLine(x.ToString() + " + " + y.ToString() + " = " + x.Plus(y).ToString());
            Console.WriteLine(x.ToString() + " - " + y.ToString() + " = " + x.Minus(y).ToString());
            Console.WriteLine(x.ToString() + " * " + y.ToString() + " = " + x.Multi(y).ToString());
            Console.WriteLine(x.ToString() + " / " + y.ToString() + " = " + x.Division(y).ToString());
            Console.WriteLine(x.ToString() + " + " + z.ToString() + " = " + x.Plus(z).ToString());
            Console.WriteLine(x.ToString() + " - " + z.ToString() + " = " + x.Minus(z).ToString());
            Console.WriteLine(x.ToString() + " * " + z.ToString() + " = " + x.Multi(z).ToString());
            Console.WriteLine(x.ToString() + " / " + z.ToString() + " = " + x.Division(z).ToString());

            Console.ReadKey();

        }
    }
}
