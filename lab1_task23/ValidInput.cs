using System;

namespace Validation
{
    class InputDataWithCheck
    {
        static public double InputDoubleWithValidation() // Ввод целого числа с проверкой правильности ввода, в том числе принадлежности к указанному диапазону.                                                                                         
        {
            bool ok = false;
            double a;
            string value;
            do
            {
                Console.WriteLine("Введите вещественное число (при ненулевой дробной части через запятую)");
                value = Console.ReadLine();
                ok = double.TryParse(value, out a);
                //Console.WriteLine(value);
                if (!ok)
                {
                    ConsoleColor tmp = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nВведенные данные имеют неверный формат");
                    Console.WriteLine("Повторите ввод\n");
                    Console.ForegroundColor = tmp;
                }
            } while (!ok);
            Console.WriteLine("Вводе прошёл успешно!\n");
            return a;
        }

    }

}