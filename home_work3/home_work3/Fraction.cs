using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work3
{
    public class Fraction
    {
        int numerator;
        int denominator;

       /// <summary>
       /// инициализация переменных
       /// </summary>
        public Fraction()
        {
            numerator = 0;
            denominator = 0;
        }

        /// <summary>
        /// функция класса с числителем и знаменателем
        /// </summary>
        public Fraction(int num, int denom)
        {
            numerator = num;
            denominator = denom;
        }

        /// <summary>
        /// Функция сложения дробей
        /// </summary>
        /// <param name="x2">второе число (слагаемое)</param>
        /// <returns>Результат сложения</returns>
        public Fraction Plus(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.numerator = numerator * x2.denominator + x2.numerator * denominator;
            x3.denominator = denominator * x2.denominator;
            Reduce(ref x3.numerator, ref x3.denominator);
            return x3;
        }

        /// <summary>
        /// Функция вычитания дробей
        /// </summary>
        /// <param name="x2">вычитаемое</param>
        /// <returns>результат вычитатния дробей</returns>
        public Fraction Minus(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.numerator = numerator * x2.denominator - x2.numerator * denominator;
            x3.denominator = denominator * x2.denominator;
            Reduce(ref x3.numerator, ref x3.denominator);
            return x3;
        }

        /// <summary>
        /// Фунция умножения дробей
        /// </summary>
        /// <param name="x2">второе число (множитель)</param>
        /// <returns>Результат умножения дробей</returns>
        public Fraction Multi(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.numerator = numerator * x2.numerator;
            x3.denominator = denominator * x2.denominator;
            Reduce(ref x3.numerator, ref x3.denominator);
            return x3;
        }

        /// <summary>
        ///Фунция деления дробей
        /// </summary>
        /// <param name="x2">делитель</param>
        /// <returns>Результат деления добей</returns>
        public Fraction Division(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.numerator = numerator * x2.denominator;
            x3.denominator = denominator * x2.numerator;
            Reduce(ref x3.numerator, ref x3.denominator);
            return x3;
        }

        /// <summary>
        /// Функция сокращения дробей
        /// </summary>
        /// <param name="a">числитель</param>
        /// <param name="b">знаменатель</param>
        public void Reduce(ref int a, ref int b)
        {
            for (int i = 2; i < Math.Min(a, b); i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    a /= i;
                    b /= i;
                    i = 1; // начинаем цикл с начала
                }
            }
        }

        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
    }
}

