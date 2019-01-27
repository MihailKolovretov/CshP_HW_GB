using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work3
{
    /// <summary>
    /// Класс подсчета суммы всех нечетных положительных чисел 
    /// </summary>
    public static class dig
    {

        public static void sumdig()
        {
            int num, outputData;
            outputData = 0;
            Console.WriteLine("Введите числа");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0 && num % 2 != 0)
            {
                outputData = outputData + num;
            }


            while (num != 0)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0 && num % 2 != 0)
                {
                    outputData = outputData + num;
                }
            }
            Console.WriteLine(outputData);
            Console.ReadLine();
        }
    }
}
